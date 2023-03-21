var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
var x = 0;
var y = 0;

var interval = setInterval(() => {
    ctx.beginPath();
    ctx.moveTo(x, y);
    x += 5;
    y += 5;
    ctx.lineTo(x, y);
    ctx.lineWidth = 5;
    ctx.strokeStyle = "#455648";
    ctx.stroke();

    if (x > canvas.width) {
        clearInterval(interval);
        alert("Animation end");
    }
}, 50);