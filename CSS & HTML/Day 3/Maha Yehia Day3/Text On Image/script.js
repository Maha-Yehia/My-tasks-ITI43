var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
var img = new Image();
img.src = "star-1096935_1920 (1).jpg";

img.onload = function () {
    ctx.drawImage(img, 0, 0, 800, 600);
    ctx.font = " bold 50pt Arial";
    ctx.fillStyle = "white";
    ctx.shadowColor = "black";
    ctx.shadowOffsetX = 6;
    ctx.shadowOffsetY = 6;
    ctx.fillText("Come to Egypt", 230, 530);

};