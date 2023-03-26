

var a = parseFloat(prompt("Please enter the first number", "Enter a new number"));
var b = parseFloat(prompt("Please enter the second number", "Enter a new number"));
var c = parseFloat(prompt("Please enter the third number", "Enter a new number"));
var d = parseFloat(prompt("Please enter the fourth number", "Enter a new number"));
var f = parseFloat(prompt("Please enter the fifth number", "Enter a new number"));

var arr = [a, b, c, d, f];

function displayValues() {
    document.write('You have entered the values of '.fontcolor("red") + arr + '<br>');
}

displayValues();

function SortingDes() {

    arr.sort(function (a, b) { return b - a });

    document.write('Your values after being sorted descending '.fontcolor("red"), arr + '<br>');
}
SortingDes();

function SortingAsc() {

    arr.sort(function (a, b) { return a - b });

    document.write('Your values after being sorted ascending '.fontcolor("red"), arr + '<br>');
}

SortingAsc();