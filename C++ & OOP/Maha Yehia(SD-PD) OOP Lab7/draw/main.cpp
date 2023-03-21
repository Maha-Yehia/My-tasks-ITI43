#include <iostream>
#include "E:\MAHA\SD ITI\Programs\Code Blocks\MinGW\include\graphics.h"
//#include "E:\MAHA\SD ITI\Programs\Code Blocks\MinGW\include\winbgim.h"
#include<conio.h>

using namespace std;

class shapeColor
{
    protected :
     int color ;
     shapeColor ()
     {
        color = 0 ;
     }
     shapeColor(int clr)
     {
         color = clr ;
     }
     ~shapeColor()
     {
        // cout<<"shapeColor destructor"<<endl ;
     }
public :
     void draw ()
     {
         setcolor(color) ;
     }
};


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

class rect : public shapeColor
{
    point ul ; ///Composition
    point lr ; ///Composition
public :

    rect ()
    {
 // cout<<"Rect Parameterless constructor "<<endl ;
    }

    /// constructors chaining
rect (int x1 , int y1 , int x2 ,int y2 , int clr)
: shapeColor( clr), ul(x1,y1) , lr(x2,y2)
    {
  //cout<<"Rect Parameter constructor "<<endl ;
    }

    ~rect ()
    {
          // cout<<"Rect destructor"<<endl ;
    }

void draw ()
{
    ///from graphics.h
    shapeColor::draw() ;
    rectangle(ul.getX(), ul.getY() , lr.getX() , lr.getY() ) ;
}


};

class Line : public shapeColor
{

point first ; ///Composition
point sec ; ///Composition

public :

    Line ()
    {
  //cout<<"line Parameterless constructor "<<endl ;
    }

    /// constructors chaining
Line (int x1 , int y1 , int x2 ,int y2, int clr)
: first(x1,y1) , sec(x2,y2),shapeColor(clr)
    {
 // cout<<"line Parameter constructor "<<endl ;
    }
    ~Line ()
    {
         //  cout<<"line destructor"<<endl ;
    }

void draw ()
{
    ///from graphics.h
      shapeColor::draw() ;
    line(first.getX(), first.getY() , sec.getX() , sec.getY()) ;
}

};


class Circle: public shapeColor
{

point cent ; ///Composition
int radius ;

public :

    Circle ()
    {
  //cout<<"circle Parameterless constructor "<<endl ;
    }

    /// constructors chaining
Circle (int x1 , int y1 , int _radius , int clr)
: cent(x1,y1) ,shapeColor( clr)
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
      shapeColor::draw() ;
    circle(cent.getX(), cent.getY() ,radius) ;
}
};

///Aggregation

class Pic
{
    rect *pRect ;
    int RNum ;
    Line *pLine ;
     int LNum ;
    Circle *pCircle ;
     int CNum ;

 public :
    Pic ()
    {
        RNum =LNum =CNum = 0 ;
        pRect=NULL;
        pLine=NULL;
        pCircle = NULL ;
        cout<<"parameterless Pic constructor"<<endl ;
    }

    Pic (rect *rArr , int r , Line *lArr , int l , Circle *cArr , int c )
    {
       pRect=rArr ;
       pLine=lArr;
       pCircle=cArr ;
       RNum = r ;
       LNum = l ;
       CNum = c ;
       cout<<"parameter Pic constructor"<<endl ;
    }

    ~Pic() {
        delete []pRect;
        delete []pLine;
        delete []pCircle;
        cout<<"Pic destructor"<<endl ; }

    void setRect (rect *rArr , int r)
    {
        pRect=rArr ;
       RNum = r ;
    }
 void setLine ( Line *lArr , int l )
    {
       pLine=lArr;
       LNum = l ;
    }
     void setCircle (Circle *cArr , int c )
    {
       pCircle=cArr ;
       CNum = c ;
    }

void Paint ()
{

    //Rectangles
    for (int i=0 ; i<RNum ; i++)
    {
        pRect[i].draw() ;
    }


    //Lines
    for (int i=0 ; i<LNum ; i++)
    {
        pLine[i].draw() ;
    }

    //Circles
    for (int i=0 ; i<CNum ; i++)
    {
        pCircle[i].draw() ;
    }
}





};






int main()
{
 initgraph() ;


 Pic p ;

 rect *rArr ;
 rArr = new rect [2] ;
 rArr[0]= rect(370,355,480,384,7) ;
 rArr[1]= rect(420,260,437,355,7) ;
  /*rArr[0].draw() ;
  rArr[1].draw() ;*/


  Circle *cArr ;
 cArr = new Circle [2] ;
 cArr[0]= Circle(428,220,77,7) ;
 cArr[1]= Circle(428,155,33,7) ;
  /*cArr[0].draw() ;
  cArr[1].draw() ;*/


  Line *lArr ;

 lArr = new Line [5] ;
 lArr[0]= Line(410,160,390,211,7) ;
 lArr[1]= Line(445,160,465,211,7) ;
 /* lArr[0].draw() ;
  lArr[1].draw() ;*/

 ///Triangle

  lArr[2]= Line(390,364,382,374,7) ;
   lArr[3]= Line(390,364,400,376,7) ;
    lArr[4]= Line(382,374,400,376,7) ;

   /*lArr[2].draw() ;
    lArr[3].draw() ;
     lArr[4].draw() ;*/
p.setRect(rArr , 2) ;
p.setLine(lArr ,5) ;
p.setCircle(cArr , 2) ;
p.Paint() ;


    /*rect r1(370,355,480,384,7) ;
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

    Circle c1 (428,220,77,7) ;
      c1.draw() ;

      Line l1 (410,160,390,211,7) ;
     l1.draw() ;

Line l2 (445,160,465,211,7) ;
     l2.draw() ;
 Circle c2 (428,155,33,7) ;
      c2.draw() ;*/

    return 0;
}
