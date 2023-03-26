
var clr;
function changeClr() {
    var red = document.getElementById("red").value;
    var green = document.getElementById("green").value;
    var blue = document.getElementById("blue").value;
    clr = 'rgb(' + red + ',' + green + ',' + blue + ')';
    // console.log(clr)
    document.getElementById("text").style.color = clr;
}
