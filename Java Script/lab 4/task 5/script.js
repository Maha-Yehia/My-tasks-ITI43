
var opr,
    x;

function EnterNumber(num) {
    document.querySelector('#Answer').value += num;

}

function EnterOperator(operator) {
    x = parseFloat(document.querySelector("#Answer").value);
    document.querySelector("#Answer").value = '';
    opr = operator;
}
function EnterEqual() {
    y = parseFloat(document.querySelector("#Answer").value);

    if (opr == '+') {
        res = document.querySelector("#Answer").value = (x + y);
    }
    else if (opr == '-') {
        res = document.querySelector("#Answer").value = (x - y);
    }
    else if (opr == '*') {
        res = document.querySelector("#Answer").value = (x * y);
    }
    else if (opr == '/') {
        res = document.querySelector("#Answer").value = (x / y);
    }

}

function EnterClear() {

    // clear number by number 
    var z = document.querySelector("#Answer").value;
    document.querySelector("#Answer").value = z.substr(0, z.length - 1);

    // if we need to clear the whole number
    //document.querySelector("#Answer").value = '' ; 
}