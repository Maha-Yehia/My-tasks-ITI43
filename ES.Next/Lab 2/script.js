console.log("task1");
function fun(course) {
    var myCourse = {
        courseName: "ES6",
        courseDuration: "3days",
        courseOwner: "JavaScript"
    }

    var result = Object.assign({}, myCourse, course)
    if (Object.keys(result).length != Object.keys(myCourse).length) {
        throw new Error("invalid arguments");
    }
    return result;

}
console.log(fun({
    courseName: "WPF",
    courseDuration: "7days",
    courseOwner: "ITI"

}));

// console.log(fun({
//     courseName : "C#" , 

// }));
// console.log(fun({
//     name : "C#" , 
//     name1 : "C#" , 
//     name2 : "C#" , 

// }));

console.log("task2-1");
function* fun1(n) {
    var first = 0, second = 1, i = 0;
    while (i < n) {
        var output = first;
        var temp = first + second;
        first = second;
        second = temp;
        i++;
        yield output;

    }
}
var iter = fun1(5);
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());


console.log("task2-2");
function* fun2(n) {
    var first = 0, second = 1, i = 0;
    while (first <= n) {
        var output = first;
        var temp = first + second;
        first = second;
        second = temp;
        yield output;

    }
}
var iter2 = fun2(5);
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());

console.log("task3");

var obj = {
    [Symbol.replace]: function (str, length) {
        if (str.length > length) {
            return str.substring(0, length) + "...";
        }
        else return str;
    }
}
console.log("abcdefghijklmnoqrstuvwxyz".replace(obj, 15));

console.log("task4");
var objIter = {
    prop1: "val1",
    prop2: "val2",
    prop3: "val3",
    prop4: "val4",
    prop5: "val5",
    prop6: "val6",
    fun: function* () {
        var keys = Object.keys(this);
        for (let item of keys) {
            if (item != "fun") {
                yield [item, this[item]];
            }
        }
    }
}

for (let iterate of objIter.fun()) {
    console.log(iterate);
}