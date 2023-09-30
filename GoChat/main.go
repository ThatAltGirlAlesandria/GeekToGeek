package main

import (
	"net/http"

	"github.com/gorilla/mux"
	"github.com/gorilla/sessions"
	"github.com/gorilla/websocket"
)

var (
	upgrader = websocket.Upgrader{
		ReadBufferSize:  1024,
		WriteBufferSize: 1024,
	}
	store = sessions.NewCookieStore([]byte("your-secret-key"))
)

func main() {
	router := mux.NewRouter()

	// Serve static files
	router.PathPrefix("/static/").Handler(http.StripPrefix("/static/", http.FileServer(http.Dir("static"))))

	// Define routes for authentication
	router.HandleFunc("/login", loginHandler).Methods("GET", "POST")
	router.HandleFunc("/logout", logoutHandler).Methods("GET")

	// Define routes for the chat room
	router.HandleFunc("/", indexHandler)
	router.HandleFunc("/ws", wsHandler)

	http.Handle("/", router)

	// Start the server
	port := ":8080"
	http.ListenAndServe(port, nil)
}
