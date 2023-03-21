var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");

var skyGradient = ctx.createLinearGradient(0, 0, 0, canvas.height);
skyGradient.addColorStop(0, "lightblue");
skyGradient.addColorStop(0.5, "white");

var grassGradient = ctx.createLinearGradient(0, canvas.height / 2, 0, canvas.height);
grassGradient.addColorStop(0, "green");
grassGradient.addColorStop(1, "white");


ctx.fillStyle = skyGradient;
ctx.fillRect(0, 0, canvas.width, canvas.height / 2);


ctx.lineWidth = 5;
ctx.beginPath();
ctx.moveTo(150, 320);
ctx.lineTo(150, 150);
ctx.lineTo(500, 150);
ctx.lineTo(500, 320);


ctx.fillStyle = grassGradient;
ctx.fillRect(0, canvas.height / 2, canvas.width, canvas.height / 2);


ctx.stroke();