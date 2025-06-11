#include <gtk/gtk.h>
#include <mosquitto.h>
#include <stdio.h>
#include <stdlib.h>

#define MQTT_HOST "test.mosquitto.org"
#define MQTT_PORT 1883
#define TOPIC "cip"

struct mosquitto *mosq;
GtkWidget *entry, *label;

// MQTT Callback for incoming messages
void on_message(struct mosquitto *mosq, void *obj, const struct mosquitto_message *msg) {
    gchar *received_msg = g_strdup_printf("Received: %s", (char *)msg->payload);
    gtk_label_set_text(GTK_LABEL(label), received_msg);
    g_free(received_msg);
}

// Function to publish MQTT message
void on_button_clicked(GtkWidget *widget, gpointer data) {
    const gchar *message = gtk_entry_get_text(GTK_ENTRY(entry));
    if (mosquitto_publish(mosq, NULL, TOPIC, strlen(message), message, 0, false) != MOSQ_ERR_SUCCESS) {
        gtk_label_set_text(GTK_LABEL(label), "Failed to send message!");
    } else {
        gchar *sent_msg = g_strdup_printf("Sent: %s", message);
        gtk_label_set_text(GTK_LABEL(label), sent_msg);
        g_free(sent_msg);
    }
}

// MQTT Non-blocking loop inside GTK timer
gboolean mqtt_timer_callback(gpointer data) {
    mosquitto_loop(mosq, 0, 1);
    return TRUE;
}

int main(int argc, char *argv[]) {
    gtk_init(&argc, &argv);
    mosquitto_lib_init();

    // Initialize MQTT
    mosq = mosquitto_new(NULL, true, NULL);
    if (!mosq) {
        g_printerr("Failed to initialize MQTT client!\n");
        return 1;
    }

    mosquitto_message_callback_set(mosq, on_message);
    if (mosquitto_connect(mosq, MQTT_HOST, MQTT_PORT, 60) != MOSQ_ERR_SUCCESS) {
        g_printerr("Failed to connect to MQTT Broker!\n");
        return 1;
    }
    mosquitto_subscribe(mosq, NULL, TOPIC, 0);

    // Load UI from Glade
    GtkBuilder *builder;
    GError *error = NULL;

    builder = gtk_builder_new();
    if (!gtk_builder_add_from_file(builder, "cip.glade", &error)) {
        g_printerr("Error loading Glade file: %s\n", error->message);
        return 1;
    }

    GtkWidget *window = GTK_WIDGET(gtk_builder_get_object(builder, "window1"));
    entry = GTK_WIDGET(gtk_builder_get_object(builder, "entry1"));
    label = GTK_WIDGET(gtk_builder_get_object(builder, "label1"));
    GtkWidget *button = GTK_WIDGET(gtk_builder_get_object(builder, "button1"));

    if (!window || !entry || !label || !button) {
        g_printerr("Failed to load widgets\n");
        return 1;
    }

    g_signal_connect(button, "clicked", G_CALLBACK(on_button_clicked), entry);
    g_signal_connect(window, "destroy", G_CALLBACK(gtk_main_quit), NULL);

    gtk_widget_show_all(window);
    g_timeout_add(100, mqtt_timer_callback, NULL);
    gtk_main();

    mosquitto_destroy(mosq);
    mosquitto_lib_cleanup();

    return 0;
}


