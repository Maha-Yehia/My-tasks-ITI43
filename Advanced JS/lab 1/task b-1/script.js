var arr = [];

var fun1 = function () {
    arr.reverse.apply(arguments);
}





var fun2 = function () {
    arr.reverse.call(arguments);
}

console.log(fun1(1, 2, 3, 4, 5, 6, 7));
console.log(fun2(1, 2, 3, 4, 5, 6, 7));

