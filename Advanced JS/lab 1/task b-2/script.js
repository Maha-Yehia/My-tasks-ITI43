var adding = function () {
    //arguments collection 
    var a = arguments[0];
    var b = arguments[1];

    var err = new Error("Please enter two parameters only!");
    if (arguments.length < 2 || arguments.length > 2 || arguments.length == 0) {
        throw (err);
    }


    var err2 = new Error("Not a number");

    if (typeof a != "number" || typeof b != "number") {
        throw (err2);
    }


    return a + b;
}


alert(adding("maha", 1));
//alert(adding(1, "maha"));
//alert(adding());
//alert(adding(1, 2, 3));
