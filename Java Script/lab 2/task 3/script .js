function calcAreaOfCircle() {
    var rad = parseInt(prompt("Enter circle's radius", "Type radius here"));
    const pi = Math.PI.toFixed(2);
    var area = pi * Math.pow(rad, 2);
    alert(area);
}
calcAreaOfCircle();

function calcSquareRoot() {
    var x = parseInt(prompt("enter a new number", "Type your value here"));
    var y = Math.sqrt(x);
    alert(y);
}
///calcSquareRoot();

function calcCos() {
    var x = parseInt(prompt("enter an angle", "Type your value here"));
    const pi = Math.PI.toFixed(2);
    var radX = x * pi / 180
    var y = Math.cos(radX);
    alert('the cos of ' + x + ' is ' + (y.toFixed(2)));
}

///calcCos(); 