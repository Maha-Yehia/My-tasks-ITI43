console.log("task1")
let x = 3, y = 5;
console.log('x =', x, ",", 'y =', y);
[x, y] = [y, x];
console.log('x =', x, ",", 'y =', y);
console.log("task2")
function fun(...args) {
    return [min = Math.min(...args), max = Math.max(...args)]
}
var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
var [min, max] = fun(...arr)
console.log("Min=", min, ",", "Max=", max);

console.log("task3")
var fruits = ["apple", "strawberry", "banana", "orange", "mango"];
var isString = function (arr) {
    return arr.every(word => typeof word == "string");
}
console.log("every element is a string", isString(fruits));
var startWithA = function (arr) {
    return arr.some(word => word.startsWith('a'));
}
console.log("some element starting with a", startWithA(fruits));


var startBorS = function (arr) {
    return arr.filter(word => (word.startsWith('b') || word.startsWith('s')))
}
console.log("word starts with b or s", startBorS(fruits));

var like = fruits.map(word => "I like " + word);

console.log(like);
like.forEach(sentance => console.log(sentance))
