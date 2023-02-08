var generator =
{
    getSetGen: function () {

        for (var i in this) {
            this['get' + i] = (function (val) {
                return function () { console.log(this[val]); }
            })(i);

            this['set' + i] = (function (val) {
                return function () {
                    for (var i = 0; i < arguments.length; i++) {
                        this[val] = arguments[i];
                    }
                }
            })(i);
        }
    }
};


var user = { Name: "maha", Age: "25" }
generator.getSetGen.apply(user);

console.log(user.getName());
user.setName("yehia");
console.log(user.getName());

console.log(user.getAge());
user.setAge(30);
console.log(user.getAge());


var obj = { ID: "SD-10", location: "SV", addr: "123 st." };

generator.getSetGen.apply(obj);

console.log(obj.getID());
obj.setID("SD-43");
console.log(obj.getID());
