const app = require('express')();
const http = require('http').createServer(app);
const io = require('socket.io')(http);
const dotenv = require('dotenv').config();
var queue;
var rooms = [];


app.get('/', function(req, res){
  res.sendFile(__dirname + '/static/index.html');
});

io.sockets.on('connection',function(socket) {
  
  socket.on('play', function(selected){
    if(selected == 0 || selected == 1 || selected == 2) {
        let room = rooms.find((r) => {return r.players[0].id == socket.id || r.players[1].id == socket.id});
        if(room) {
          if(room.selected != -1) {
              let adv = room.players.find((x) => x != socket);
              if(selected == room.selected) {
                  socket.emit("tie");
                  adv.emit("tie");
              }
              else {
                  let win = (selected - room.selected) % 3;
                  socket.emit(win == 1 ? "win" : "lose");
                  adv.emit(win != 1 ? "win" : "lose");
              }
              rooms = rooms.filter((r) => room != r);
          }
          else {
              room.selected = selected;
          }
        }
    }
  });
  
  socket.on('join', function(username){
      if(username) {
          if(queue) {
              rooms.push(
                {'players': [socket, queue.socket], 'selected': -1}
              );
              socket.emit("found", queue.username);
              queue.socket.emit("found", username);
              queue = null;
          }
          else {
              queue = {'username': username, 'socket': socket};
              socket.emit("waiting");
          }
      }
  });
});

http.listen(process.env.PORT, function(){
  console.log('listening on *:' + process.env.PORT);
});