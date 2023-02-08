var adding = function () {
    //arguments collection 
    var sum = 0;

    if (arguments.length == 0) {
        var err = new Error("No parameters");
        throw (err);
    }
    var err2 = new Error("Not a number");
    for (var i = 0; i < arguments.length; i++) {
        if (typeof arguments[i] != "number") {
            throw (err2);
        }
        else {
        } sum += arguments[i];

    }
    return sum;
}


alert(adding(5, 7, 'maha'));
