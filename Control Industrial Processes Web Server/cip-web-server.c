#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <arpa/inet.h>

#define PORT 2700
#define BUFFER_SIZE 1024
#define INDEX_FILE "cip.html"

void handle_client(int client_socket) {
    char buffer[BUFFER_SIZE];
    FILE *file = fopen(INDEX_FILE, "r");

    if (file == NULL) {
        sprintf(buffer, "HTTP/1.1 404 Not Found\r\n\r\nFile not found.");
        write(client_socket, buffer, strlen(buffer));
    } else {
        sprintf(buffer, "HTTP/1.1 200 OK\r\nContent-Type: text/html\r\n\r\n");
        write(client_socket, buffer, strlen(buffer));

        while (fgets(buffer, BUFFER_SIZE, file)) {
            write(client_socket, buffer, strlen(buffer));
        }
        fclose(file);
    }
    close(client_socket);
}

int main() {
    int server_socket, client_socket;
    struct sockaddr_in server_addr, client_addr;
    socklen_t addr_size = sizeof(client_addr);

    server_socket = socket(AF_INET, SOCK_STREAM, 0);
    if (server_socket < 0) {
        perror("Socket creation failed");
        return 1;
    }

    server_addr.sin_family = AF_INET;
    server_addr.sin_addr.s_addr = INADDR_ANY;
    server_addr.sin_port = htons(PORT);

    if (bind(server_socket, (struct sockaddr*)&server_addr, sizeof(server_addr)) < 0) {
        perror("Bind failed");
        return 1;
    }

    if (listen(server_socket, 5) < 0) {
        perror("Listen failed");
        return 1;
    }

    printf("Server running on http://localhost:%d\n", PORT);

    while ((client_socket = accept(server_socket, (struct sockaddr*)&client_addr, &addr_size)) >= 0) {
        handle_client(client_socket);
    }

    close(server_socket);
    return 0;
}

