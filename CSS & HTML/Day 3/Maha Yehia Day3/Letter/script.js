var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");

var outerGradient = ctx.createRadialGradient(canvas.width / 2, canvas.width / 2, canvas.width / 3, canvas.width / 4, canvas.width / 4, 0);
outerGradient.addColorStop(0, "lightblue");
outerGradient.addColorStop(1, "blue");

var innerGradient = ctx.createRadialGradient(canvas.width / 2, canvas.width / 2, canvas.width / 4, canvas.width / 4, canvas.width / 4, 0);
innerGradient.addColorStop(0, "lightblue");
innerGradient.addColorStop(1, "blue");

ctx.beginPath();
ctx.arc(canvas.width / 2, canvas.width / 2, canvas.width / 3, 0, 2 * Math.PI);
ctx.fillStyle = outerGradient;
ctx.fill();

ctx.beginPath();
ctx.arc(canvas.width / 2, canvas.width / 2, canvas.width / 4, 0, 2 * Math.PI);
ctx.fillStyle = innerGradient;
ctx.fill();


ctx.font = "200px Arial";
ctx.fillStyle = "white";
ctx.textAlign = "center";
ctx.textBaseline = "middle";
ctx.fillText("M", canvas.width / 2, canvas.width / 2);