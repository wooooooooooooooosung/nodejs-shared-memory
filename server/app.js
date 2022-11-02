var edge = require('edge-js');
var app = require('express')();
var server = require('http').createServer(app);
var io = require('socket.io')(server);

var shm = edge.func('./Resources/CreateOrOpenSHM.dll');

app.get('/', function(req, res) {
    res.sendFile(__dirname + '/index.html');
});

io.on('connection', function(socket) {
    socket.on('createOrOpenSHM', function(data) {
        shm(data, function(error, result) {
            if (error) throw error;
            // if (result === 'SUCCESS') 
        });
    });
});

server.listen(3000, function() {
    console.log('[Log] 서버 시작');
});