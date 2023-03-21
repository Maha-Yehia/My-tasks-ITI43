#include <iostream>

using namespace std;

class GeoShow
{
    protected :
    int dim1 , dim2 ;
public :
    GeoShow()
    {cout<<"parameterless constructor"<<endl ;}
    GeoShow(int d1 , int d2)
    {
        dim1 = d1 ;
        dim2 = d2 ;
        cout<<"parameter constructor"<<endl ;
    }
    GeoShow(int d1)
    {
        dim1 = dim2 = d1 ;
        cout<<"one parameter constructor"<<endl ;
    }
    ~GeoShow()
    {cout<<"destructor"<<endl ;}
void setDim1 (int d1){dim1 = d1 ;}
void setDim2 (int d2){dim2 = d2 ;}
int getDim1() {return dim1 ;}
int getDim2() {return dim2 ;}
};

class Rect : public GeoShow
{
    public :
    Rect ()  {cout<<"Rect parameterless constructor"<<endl ;}
    Rect (int d1 , int d2) : GeoShow (d1 , d2)
    {
         {cout<<"Rect parameter constructor"<<endl ;}
    }
     Rect (int d1) : GeoShow (d1)
    {
        setDim1(d1) ; setDim2(d1) ;
         {cout<<"Rect parameter constructor"<<endl ;}
    }

    ~Rect() {cout<<"Rect destructor"<<endl ;}

    double cArea ()
    {
        return getDim1()*getDim2();
    }
};



class Square : protected Rect
{
    public :
    Square ()  {cout<<"Square parameterless constructor"<<endl ;}
    Square (int d1) : Rect (d1)
    {
         {cout<<"Square parameter constructor"<<endl ;}
    }

    ~Square() {cout<<"Square destructor"<<endl ;}
///override
    double cArea ()
    {
        return getDim1()*getDim2();
       /// return Rect::cArea() ;
    }

    /// override

    setDim1 (int d)
    {
        dim1 = dim2 = d ;

     }
      setDim2 (int d)
    {
        dim1 = dim2 = d ;

     }



};



class Triangle : public GeoShow
{
    public :
    Triangle ()  {cout<<"Triangle parameterless constructor"<<endl ;}
    Triangle (int d1 , int d2) : GeoShow (d1 , d2)
    {
         {cout<<"Triangle parameter constructor"<<endl ;}
    }

    ~Triangle() {cout<<"Triangle destructor"<<endl ;}

    double cArea ()
    {
        return 0.5*getDim1()*getDim2();
    }
};

class Circle : protected GeoShow
{
    public :
    Circle ()  {cout<<"Circle parameterless constructor"<<endl ;}
    Circle (int r) : GeoShow (r)
    {
         {cout<<"Circle parameter constructor"<<endl ;}
    }
    ~Circle() {cout<<"Circle destructor"<<endl ;}

    double cArea ()
    {

        return 3.14*getDim1()*getDim2() ;
    }

    setDim1(int r)
    {
        dim1 = dim2 =r ;
    }
    setDim2(int r)
    {
         dim1 = dim2 =r ;
    }
};

/// Stand alone function

sumArea (Rect arrOfRect[],Square arrOfSquare[] , Triangle arrOfTri[], Circle arrOfCir[] ,int RectSize ,  int SquareSize ,  int TriSize , int CirSize )
{
///for rect
double sumRect = 0 ;
for (int i = 0 ; i<RectSize ; i++)
{
   sumRect +=arrOfRect[i].cArea() ;
}

///for square
double sumSquare = 0 ;
for (int i = 0 ; i<SquareSize ; i++)
{
   sumSquare +=arrOfSquare[i].cArea() ;
}

///for Triangle
double sumTriangle = 0 ;
for (int i = 0 ; i<TriSize ; i++)
{
   sumTriangle +=arrOfTri[i].cArea() ;
}

///for Circle
double sumCircle = 0 ;
for (int i = 0 ; i<CirSize ; i++)
{
   sumCircle +=arrOfCir[i].cArea() ;
}

double sum= sumRect+sumSquare+sumTriangle+sumCircle ;
return  sum ;


}






int main()
{

Rect *r = new Rect [2] ;
Square *s = new Square [2] ;
Triangle *t = new Triangle[2] ;
Circle *c = new Circle [2] ;

c[0].setDim1(5) ;
c[1].setDim1(5) ;
r[0].setDim1(2) ;
r[0].setDim2(4) ;

cout<<sumArea(r,s,t,c,2,2,2,2)<<endl ;



Rect r1(3,4) ;
cout<<r1.cArea()<<endl;

Triangle t1(3,4) ;
cout<<t1.cArea()<<endl;

Circle c1(3) ;
cout<<c1.cArea()<<endl;

c1.setDim1(3) ;
cout<<c1.cArea()<<endl;
c1.setDim2(2) ;
cout<<c1.cArea()<<endl;

/*c1.GeoShow::setDim1(20) ;
cout<<c1.cArea()<<endl;*/

Square s1(3) ;
cout<<s1.cArea()<<endl;
s1.setDim2(4) ;
cout<<s1.cArea()<<endl;

/*s1.Rect::setDim1(20) ;
cout<<s1.cArea()<<endl;*/







    return 0;
}
