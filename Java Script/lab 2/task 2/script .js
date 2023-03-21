
var x = parseFloat(prompt("Please enter the first number", "Enter a new number"));
var y = parseFloat(prompt("Please enter the second number", "Enter a new number"));
var z = parseFloat(prompt("Please enter the third number", "Enter a new number"));
var arr = { x, y, z };

function sumNumbers() {
    sum = x + y + z;
    document.write('Sum of the 3 values '.fontcolor("red") + x + '+' + y + '+' + z + ' = ' + sum + '<br>');


}

sumNumbers();
function MultNumbers() {
    sum = x * y * z;
    document.write('Multiplication of the 3 value '.fontcolor("red") + x + '*' + y + '*' + z + ' = ' + sum + '<br>');
}

MultNumbers();
function divNumbers() {
    sum = x / y / z;
    document.write('division of the 3 values '.fontcolor("red") + x + '/' + y + '/' + z + ' = ' + sum.toFixed(2) + '<br>');
}
divNumbers();

