package main

import (
	"net/http"

	"github.com/gorilla/mux"
	"github.com/gorilla/websocket"
)

var (
	upgrader  = websocket.Upgrader{}
	clients   = make(map[*websocket.Conn]bool)
	broadcast = make(chan Message)
)

type Message struct {
	Username string `json:"username"`
	Content  string `json:"content"`
}

func main() {
	router := mux.NewRouter()

	// Serve static files (HTML, JS, CSS)
	router.PathPrefix("/static/").Handler(http.StripPrefix("/static/", http.FileServer(http.Dir("static"))))

	// Define routes
	router.HandleFunc("/", indexHandler)
	router.HandleFunc("/ws", wsHandler)

	http.Handle("/", router)

	// Start the server
	port := ":8080"
	http.ListenAndServe(port, nil)
}
