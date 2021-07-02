"use strict";



// here you need to remember just one line
// to build connection
//silly mistake,,,lets run

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

// next we will call server side method to send messages
connection.on("newmessage", function (user, message) {
    var li = document.createElement("li");
    li.innerHTML = `${user} says ${message}`;
    // you can use jquery here 
    document.getElementById("chatlist").appendChild(li);
});
connection.on("newuser", function (usercount) {
    document.getElementById("users").innerHTML = usercount;
});
connection.on("userdisconnect", function (usercount) {
    document.getElementById("users").innerHTML = usercount;
});
// lets start the connection
connection.start().then(function () {
    // no need to show alert
}).catch(function (err) {
    alert('Not able to start, may be routing not working in startup.cs');
});

// now lets assume we made one button to send message with id sendButton
// and on its click we will send message
document.getElementById("sendButton").addEventListener("click", function (event) {
    // calls server side method to send message
    var user = document.getElementById("username").value;
    var message = document.getElementById("usermessage").value;

    connection.invoke("SendMessage", user, message).catch(function (err) {
        alert('Error in sending message');
    });

});