var vid = document.getElementsByTagName("video")[0]
document.getElementById("playBtn").onclick = function () {
    vid.play();
}

document.getElementById("stopBtn").onclick = function () {
    vid.pause();
}

document.getElementById("muteBtn").onclick = function () {
    vid.muted = true;
}
document.getElementById("unmuteBtn").onclick = function () {
    vid.muted = false;
}
function changeVolume(amount) {
    vid.volume = amount;
}
function changeSpeed(amount) {
    vid.playbackRate = amount;
}
function changeTime(amount) {
    vid.currentTime = amount;
}

function fastNext() {
    vid.currentTime += 10;
}
function next() {
    vid.currentTime += 5;
}
function fastBack() {
    vid.currentTime -= 10;
}
function back() {
    vid.currentTime -= 5;
}

var time = document.getElementById("time");
vid.ontimeupdate = function () {
    ct = parseInt(vid.currentTime);
    var min = parseInt(ct % 3600 / 60);
    var sec = parseInt(ct % 60);
    time.innerText = "0" + min + ':' + sec;
}