#include <gtk/gtk.h>
#include <cairo.h>
#include <math.h>
#include <stdlib.h>
#include <mosquitto.h>
#include <stdio.h>

#define STEAM_PARTICLES 20
#define TOWER_WIDTH 100
#define TOWER_HEIGHT 150
#define MQTT_HOST "test.mosquitto.org"
#define MQTT_PORT 1883
#define TOPIC "cip"

struct mosquitto *mosq;
GtkWidget *entry, *label, *drawing_area;

typedef struct {
    double x, y;
    double alpha;
} SteamParticle;

SteamParticle steam[STEAM_PARTICLES];

// MQTT Callback for incoming messages
void on_message(struct mosquitto *mosq, void *obj, const struct mosquitto_message *msg) {
    gchar *received = g_strdup_printf("Received: %s", (char *)msg->payload);
    gtk_label_set_text(GTK_LABEL(label), received);  // Update GTK label dynamically
    g_free(received);
}

// MQTT Callback for publishing messages
void on_publish(GtkWidget *widget, gpointer data) {
    const gchar *message = gtk_entry_get_text(GTK_ENTRY(entry));
    mosquitto_publish(mosq, NULL, TOPIC, strlen(message), message, 0, false);
}

// MQTT Non-blocking loop inside GTK's timer
gboolean mqtt_timer_callback(gpointer data) {
    mosquitto_loop(mosq, 0, 1); // Non-blocking
    return TRUE;  // Keep running
}

// Cooling tower drawing function
gboolean on_draw_event(GtkWidget *widget, cairo_t *cr, gpointer user_data) {
    int width, height;
    width = gtk_widget_get_allocated_width(widget);
    height = gtk_widget_get_allocated_height(widget);
    
    cairo_translate(cr, width / 2, height / 2);

    // Draw tower
    cairo_set_source_rgb(cr, 0.5, 0.5, 0.5);
    cairo_move_to(cr, -TOWER_WIDTH / 2, TOWER_HEIGHT / 2);
    cairo_line_to(cr, -TOWER_WIDTH / 3, -TOWER_HEIGHT / 2);
    cairo_line_to(cr, TOWER_WIDTH / 3, -TOWER_HEIGHT / 2);
    cairo_line_to(cr, TOWER_WIDTH / 2, TOWER_HEIGHT / 2);
    cairo_close_path(cr);
    cairo_fill(cr);

    // Draw steam particles
    for (int i = 0; i < STEAM_PARTICLES; i++) {
        cairo_set_source_rgba(cr, 1.0, 1.0, 1.0, steam[i].alpha);
        cairo_arc(cr, steam[i].x, steam[i].y, 5, 0, 2 * M_PI);
        cairo_fill(cr);
    }

    return FALSE;
}

// Cooling tower animation function
gboolean update_animation(gpointer data) {
    for (int i = 0; i < STEAM_PARTICLES; i++) {
        steam[i].y -= 2;  // Move upwards
        steam[i].alpha -= 0.02; // Fade out

        if (steam[i].alpha <= 0.0) {
            steam[i].y = 20; // Reset position near the top of the tower
            steam[i].x = (rand() % 40) - 20;
            steam[i].alpha = 1.0;
        }
    }

    gtk_widget_queue_draw(GTK_WIDGET(data));
    return G_SOURCE_CONTINUE;
}

int main(int argc, char *argv[]) {
    gtk_init(&argc, &argv);
    mosquitto_lib_init();

    // MQTT Setup
    mosq = mosquitto_new(NULL, true, NULL);
    mosquitto_message_callback_set(mosq, on_message);
    mosquitto_connect(mosq, MQTT_HOST, MQTT_PORT, 60);
    mosquitto_subscribe(mosq, NULL, TOPIC, 0);

    // GUI Setup
    GtkWidget *window, *vbox, *button;

    window = gtk_window_new(GTK_WINDOW_TOPLEVEL);
    gtk_window_set_title(GTK_WINDOW(window), "Control Industrial Processes");
    g_signal_connect(window, "destroy", G_CALLBACK(gtk_main_quit), NULL);

    vbox = gtk_box_new(GTK_ORIENTATION_VERTICAL, 5);
    gtk_container_add(GTK_CONTAINER(window), vbox);

    drawing_area = gtk_drawing_area_new();
    gtk_widget_set_size_request(drawing_area, 400, 400);
    g_signal_connect(G_OBJECT(drawing_area), "draw", G_CALLBACK(on_draw_event), NULL);
    gtk_box_pack_start(GTK_BOX(vbox), drawing_area, TRUE, TRUE, 0);

    entry = gtk_entry_new();
    gtk_box_pack_start(GTK_BOX(vbox), entry, TRUE, TRUE, 0);

    button = gtk_button_new_with_label("Publish");
    g_signal_connect(button, "clicked", G_CALLBACK(on_publish), NULL);
    gtk_box_pack_start(GTK_BOX(vbox), button, TRUE, TRUE, 0);

    label = gtk_label_new("Waiting for messages...");
    gtk_box_pack_start(GTK_BOX(vbox), label, TRUE, TRUE, 0);

    gtk_widget_show_all(window);

    // Initialize steam particles
    for (int i = 0; i < STEAM_PARTICLES; i++) {
        steam[i].x = (rand() % 40) - 20;
        steam[i].y = 20;
        steam[i].alpha = 1.0;
    }

    // Set timers for animation and MQTT loop
    g_timeout_add(50, update_animation, drawing_area);
    g_timeout_add(100, mqtt_timer_callback, NULL);

    gtk_main();

    mosquitto_destroy(mosq);
    mosquitto_lib_cleanup();

    return 0;
}

