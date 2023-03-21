var canvas = document.getElementsByTagName("canvas")[0];
var ctx = canvas.getContext("2d");

var isTop = false;
var counter = 0;

var interval = setInterval(() => {
    isTop = !isTop;

    ctx.clearRect(0, 0, canvas.width, canvas.height);

    ctx.beginPath();

    ctx.arc(200, 125, 100, 0, Math.PI, isTop);

    ctx.lineWidth = 2;
    ctx.fillStyle = 'black';
    ctx.stroke();

    ctx.closePath();

    ctx.fillStyle = 'yellow';
    ctx.fill();

    counter++;
    if (counter == 10) {
        clearInterval(interval);
        ctx.beginPath();
        ctx.arc(200, 125, 100, 0, 2 * Math.PI);
        ctx.fillStyle = 'yellow';
        ctx.fill();
        ctx.stroke();
    }
}, 500)

