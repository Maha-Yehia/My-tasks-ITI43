var rec = function (w, h) {
    this.width = w;
    this.height = h;
    ar = this.width * this.height
    per = (this.width + this.height) * 2
    this.area = function () {
        console.log("Area = " + ar)
    }

    this.perimeter = function () {
        console.log("perimeter = " + per)
    }

    this.display = function () {
        console.log("Width = " + this.width + ",Height = " + this.height + ", Area = " + ar + ",perimeter = " + per);
    }


};

var r1 = new rec(2, 4);
r1.area();
r1.perimeter();
r1.display();

var r2 = new rec(3, 5);
r2.area();
r2.perimeter();
r2.display(); 