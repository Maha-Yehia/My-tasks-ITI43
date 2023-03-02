class Polygon
{
    #dim1 = 0;
    #dim2 = 0;
    constructor(_dim1, _dim2)
    {
        if(this.constructor.name == "Polygon")
            throw "Cannot create objects from abstract class";
        this.#dim1 = _dim1;
        this.#dim2 = _dim2;
    }
    set Dim1 (_dim1) 
    {
        if(this.constructor.name != "Square" && this.constructor.name != "Circle")
        this.#dim1 = _dim1;
        else
        {
            this.#dim1 = this.#dim2 = _dim1;
        }
    }
    set Dim2 (_dim2) 
    {
        if(this.constructor.name != "Square" && this.constructor.name != "Circle")
        this.#dim2 = _dim2;
        else
        {
            this.#dim1 = this.#dim2 = _dim2;
        }
    }
    get Dim1 () 
    {
        return this.#dim1;
    }
    get Dim2 () 
    {
        return this.#dim2;
    }

    toString()
    {
        return `This is a ${this.constructor.name} and it has the dimensions of ${this.#dim1} and ${this.#dim2}`;
    }
}

class Rectangle extends Polygon
{
    constructor(_dim1, _dim2)
    {
        super(_dim1, _dim2);
    }
    CalcArea() 
    {
        return this.Dim1 * this.Dim2;
    }
    CalcPerimeter() 
    {
        return 2*(this.Dim1 + this.Dim2);
    }
    toString()
    {
        return `${super.toString()}, it has the area of ${this.CalcArea()} and the perimeter of ${this.CalcPerimeter()}`;
    }
    Draw(x,y)
    {
        ctx.beginPath();
        ctx.rect(x, y, this.Dim1, this.Dim2);
        ctx.stroke();
        ctx.fill();
    }
}

class Square extends Rectangle
{
    constructor(_dim)
    {
        super(_dim, _dim);
    }
    CalcArea() 
    {
        return Math.pow(this.Dim1, 2);
    }
    CalcPerimeter() 
    {
        return 4*(this.Dim1);
    }
 
}
class Circle extends Polygon
{
    constructor(radius)
    {
        super(radius, radius);
    }
    CalcArea() 
    {
        return Math.PI * Math.pow(this.Dim1, 2);
    }
    CalcPerimeter() 
    {
        return Math.PI * 2 * this.Dim1;
    }
    toString()
    {
        return `${super.toString()}, it has the area of ${this.CalcArea()} and the perimeter of ${this.CalcPerimeter()}`;
    }
    Draw(x,y)
    {
        ctx.beginPath();
        ctx.arc(x, y, this.Dim1, 0, 2 * Math.PI);
        ctx.stroke();
        ctx.fill();
    }
    
}

class Triangle extends Polygon
{
    constructor(_dim1, _dim2)
    {
        super(_dim1, _dim2);
    }          
    CalcArea() 
    {
        return 0.5 * this.Dim1 * this.Dim2;
    }
    CalcPerimeter() 
    {
        return this.Dim1 + this.Dim2 + this.Dim1;
    }
    toString()
    {
        return `${super.toString()}, it has the area of ${this.CalcArea()} and the perimeter of ${this.CalcPerimeter()}`;
    }
    Draw(x,y)
    {
        ctx.beginPath();
        ctx.moveTo(x, y);
        ctx.lineTo(x, y+this.Dim2);
        ctx.lineTo(x+this.Dim1, y);
        ctx.fill();
    }
    
}


let sq1 = new Square(200);
let rect1 = new Rectangle(200,300);
let tri1 = new Triangle(200,300);
let circ1 = new Circle(100);



console.log(sq1.toString());
console.log(rect1.toString());
console.log(tri1.toString());
console.log(circ1.toString());

var canv = document.getElementById("myCanvas");
var ctx = canv.getContext("2d");
tri1.Draw(20,20);
rect1.Draw(300, 20);
sq1.Draw(600,20);
circ1.Draw(950, 120);

