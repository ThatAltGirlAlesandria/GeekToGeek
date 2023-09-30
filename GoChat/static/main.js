let socket = new WebSocket("ws://" + window.location.host + "/ws");

socket.onmessage = function(event) {
    let msg = JSON.parse(event.data);
    let chat = document.getElementById("chat");
    chat.innerHTML += msg.username + ": " + msg.content + "<br>";
};

function sendMessage() {
    let messageInput = document.getElementById("message");
    let message = messageInput.value;

    if (message.trim() !== "") {
        let msg = {
            username: "You", // Replace with actual username logic
            content: message
        };

        socket.send(JSON.stringify(msg));
        messageInput.value = "";
    }
}
