var canvas = document.getElementsByTagName("canvas")[0];
var ctx = canvas.getContext("2d");

ctx.beginPath();
ctx.fillStyle = "red";

ctx.moveTo(250, 50);
ctx.lineTo(250, 250);
ctx.lineTo(100, 250);
ctx.fill();

ctx.closePath();

ctx.fillStyle = "black";
ctx.font = "20px Arial";

ctx.fillText("a", 180, 270);
ctx.fillText("b", 260, 180);
ctx.fillText("c", 140, 180);