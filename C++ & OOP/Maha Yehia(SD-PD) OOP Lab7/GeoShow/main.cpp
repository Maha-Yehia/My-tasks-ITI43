#include <iostream>

using namespace std;

class GeoShape
{
    protected :
    int dim1 , dim2 ;
public :
    GeoShape()
    {
        //cout<<"parameterless constructor"<<endl ;
        }
   GeoShape(int d1 , int d2)
    {
        dim1 = d1 ;
        dim2 = d2 ;
        //cout<<"parameter constructor"<<endl ;
    }
    GeoShape(int d1)
    {
        dim1 = dim2 = d1 ;
       // cout<<"one parameter constructor"<<endl ;
    }
    ~GeoShape()
    {
        //cout<<"destructor"<<endl ;
        }
void setDim1 (int d1){dim1 = d1 ;}
void setDim2 (int d2){dim2 = d2 ;}
int getDim1() {return dim1 ;}
int getDim2() {return dim2 ;}

virtual double cArea() = 0 ;




};

class Rect : public GeoShape
{
    public :
    Rect ()  {
        //cout<<"Rect parameterless constructor"<<endl ;
        }
    Rect (int d1 , int d2) : GeoShape (d1 , d2)
    {
         {
             //cout<<"Rect parameter constructor"<<endl ;
             }
    }
     Rect (int d1) : GeoShape (d1)
    {
        setDim1(d1) ; setDim2(d1) ;
         {
             //cout<<"Rect parameter constructor"<<endl ;
             }
    }

    ~Rect() {
        //cout<<"Rect destructor"<<endl ;
        }

    double cArea () override
    {
        return getDim1()*getDim2();
    }
};



class Square : public Rect
{
    public :
    Square ()  {
        //cout<<"Square parameterless constructor"<<endl ;
        }
    Square (int d1) : Rect (d1)
    {
         {
             //cout<<"Square parameter constructor"<<endl ;
             }
    }

    ~Square() {
        //cout<<"Square destructor"<<endl ;
        }
///override
    double cArea () override
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



class Triangle : public GeoShape
{
    public :
    Triangle ()  {
        //cout<<"Triangle parameterless constructor"<<endl ;
        }
    Triangle (int d1 , int d2) : GeoShape (d1 , d2)
    {
         {
             //cout<<"Triangle parameter constructor"<<endl ;
             }
    }

    ~Triangle() {
        //cout<<"Triangle destructor"<<endl ;
        }

    double cArea ()override
    {
        return 0.5*getDim1()*getDim2();
    }
};

class Circle : public GeoShape
{
    public :
    Circle ()  {
        //cout<<"Circle parameterless constructor"<<endl ;
        }
    Circle (int r) : GeoShape (r)
    {
         {
             //cout<<"Circle parameter constructor"<<endl ;
             }
    }
    ~Circle() {
        //cout<<"Circle destructor"<<endl ;
        }

    double cArea ()override
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

/// Array of base pointers
double sumArea(GeoShape** GArr , int c)
{
    double sum = 0 ;
    for (int i = 0 ; i<c ; i++)

   sum += GArr[i] ->cArea() ;

return sum ;
}


int main()
{

Rect r[2]= {Rect (3,4) , Rect (5,6) } ;
Square s [2]= {Square (3) , Square (5) } ;
Triangle t[2]={Triangle (3,4) , Triangle (5,6) } ;
Circle c[2]={Circle (3) , Circle (5) } ;


GeoShape* Arr[8] = {r , &r[1] , s, & s[1], t , &t[1] , c , &c[1]} ;
cout<<"total area = "<<sumArea(Arr,8)<<endl ;

    return 0;
}
