#include <iostream>
#include "E:\MAHA\SD ITI\Programs\Code Blocks\MinGW\include\graphics.h"
//#include "E:\MAHA\SD ITI\Programs\Code Blocks\MinGW\include\winbgim.h"
#include<conio.h>

using namespace std;

class point
{
    int x , y ;

public :

///constructors & destructor
    point ()
    {
        x = y = 0 ;
      //  cout<<"Point Parameterless constructor "<<endl ;
    }

    point (int _x ,int _y)
    {
        x = _x ;
         y = _y ;
       // cout<<"Point constructor with parameters"<<endl ;
    }

    ~point ()
    {
        //cout<<"Point destructor"<<endl ;
    }

    ///setters & getters

void setX(int _x){x = _x ; }
void setY(int _y){y = _y ; }

int getX(){return x ; }
int getY(){return y ; }


   void show()
   {
       cout<<"("<<x<<","<<y<<")"<<endl ;
   }

};

class rect
{
    point ul ; ///Composition
    point lr ; ///Composition
    int color ;

public :

    rect ()
    {
int color = 0 ;
 // cout<<"Rect Parameterless constructor "<<endl ;
    }

    /// constructors chaining
rect (int x1 , int y1 , int x2 ,int y2 , int clr)
: ul(x1,y1) , lr(x2,y2)
    {
        color = clr ;
  //cout<<"Rect Parameter constructor "<<endl ;
    }

    ~rect ()
    {
          // cout<<"Rect destructor"<<endl ;
    }

void draw ()
{
    ///from graphics.h
    setcolor(color) ;
    rectangle(ul.getX(), ul.getY() , lr.getX() , lr.getY() ) ;
}


};

class Line
{

point first ; ///Composition
point sec ; ///Composition
int color ;

public :

    Line ()
    {
color = 0 ;
  //cout<<"line Parameterless constructor "<<endl ;
    }

    /// constructors chaining
Line (int x1 , int y1 , int x2 ,int y2 ,int col)
: first(x1,y1) , sec(x2,y2)
    {
color = col ;
 // cout<<"line Parameter constructor "<<endl ;
    }
    ~Line ()
    {
         //  cout<<"line destructor"<<endl ;
    }

void draw ()
{
    ///from graphics.h
    setcolor(color) ;
    line(first.getX(), first.getY() , sec.getX() , sec.getY()) ;
}

};


class Circle
{

point cent ; ///Composition
int radius ;

public :

    Circle ()
    {
  //cout<<"circle Parameterless constructor "<<endl ;
    }

    /// constructors chaining
Circle (int x1 , int y1 , int _radius )
: cent(x1,y1)
    {
        radius = _radius ;
  //cout<<"circle Parameter constructor "<<endl ;
    }

    ~Circle ()
    {
          // cout<<"circle destructor"<<endl ;
    }

void draw ()
{
    ///from graphics.h
    circle(cent.getX(), cent.getY() ,radius) ;
}
};




int main()
{
 initgraph() ;

    rect r1(370,355,480,384,7) ;
    r1.draw() ;


    rect r2(420,260,437,355,7) ;
    r2.draw() ;

    //Triangle
      Line l3 (390,364,382,374,7) ;
     l3.draw() ;

      Line l4 (390,364,400,376,7) ;
     l4.draw() ;

      Line l5 (382,374,400,376,7) ;
     l5.draw() ;



    Circle c1 (428,220,77) ;
      c1.draw() ;

      Line l1 (410,160,390,211,7) ;
     l1.draw() ;

Line l2 (445,160,465,211,7) ;
     l2.draw() ;
 Circle c2 (428,155,33) ;
      c2.draw() ;

    return 0;
}
