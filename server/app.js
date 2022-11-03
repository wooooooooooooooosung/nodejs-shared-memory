var edge = require('edge-js');
var app = require('express')();
var server = require('http').createServer(app);
var io = require('socket.io')(server);


// 메모리 맵 접근 DLL 파일 로드
var createOrOpenSHM = edge.func('./Resources/CreateOrOpenSHM.dll');
var getSHMDataValues = edge.func('./Resources/getSHMDataValues.dll');

app.get('/', function(req, res) {
    res.sendFile(__dirname + '/index.html');
});

io.on('connection', function(socket) {

    // 공유 메모리 맵 생성 또는 접근(이미 만들어져있으면)
    socket.on('createOrOpenSHM', function(data) {
        createOrOpenSHM(data, function(error, result) {
            if (error) { 
                console.log("[Fail] 메모리 맵 생성 실패, " + error);
                // alert
                socket.emit('showPopup', '메모리 맵 생성을 실패했습니다.');
                throw error; 
            }
            if (result === 'SUCCESS') {
                console.log("[Success] 메모리 맵 생성 성공");
                // alert
                socket.emit('showPopup', '메모리 맵 생성을 성공했습니다.');
                
                // 공유 메모리 생성 또는 접근에 성공했다면
                // 초기 값 가져오기
                // 이미 만들어진 맵일 경우 초기값이 0이 아닐 수 있기에 값 조회해야함
                getSHMDataValues(data, function(gError, gResult) {
                    if (gError) throw gError;

                    // 초기 DLL 파일 Call은 실패하지 않을거 같아서 if문 추가하지 않음
                    console.log("[Success] 메모리 맵 데이터 값 조회 성공")
                    console.log("[Log] 메모리 값 : " + gResult);
                    socket.emit('getMemoryMapDataValues', gResult);
                });
            }
        });
    });

    // 공유 메모리 맵 데이터 값 가져오기
    socket.on('getMemoryMapDataValues', function(data) {
        getSHMDataValues(data, function(error, result) {
            if (error) { 
                console.log("[Fail] 메모리 맵 데이터 값 조회 실패, " + error);
                // alert
                socket.emit('showPopup', '메모리 맵 생성을 실패했습니다.');
                throw error;
            }
            console.log("[Success] 메모리 맵 데이터 값 조회 성공")
            console.log("[Log] 메모리 값 : " + result);
            socket.emit('getMemoryMapDataValues', result);
        });
    });
});

server.listen(3000, function() {
    console.log('[Log] 서버 시작');
});
