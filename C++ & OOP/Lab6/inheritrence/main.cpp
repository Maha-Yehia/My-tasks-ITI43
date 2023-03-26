#include <iostream>

using namespace std;

class Base
{
    /// attributes with three types
    int x ; // private
    protected : int y ;

    public :
    int z ;

    Base ()
    {
   // cout << "parameterless constructor"<<endl ;
    }

    Base (int _x ,int _y,int _z)
    {
        x=_x ; y=_y ; z=_z ;
        //cout << "parameter constructor"<<endl ;
    }
    ~Base (){//cout<<"destructor"<<endl ;
    }
int sum () {return x+y+z ; }

/*void setX(int _x){x=_x ;}
int getX(){return x ; }

void setY(int _y){y=_y ;}
int getY(){return y ; }*/


};

class Derived01 : public Base
{
    int a ; // private
    protected : int b ;

    public :
    int c  ;
    Derived01 (int _a ,int _b,int _c , int _x ,int _y,int _z)
    :Base (_x ,_y, _z)
    {
        a=_a ; b=_b ; c=_c ;
       // cout << "parameter constructor"<<endl ;
    }

    int sum () {return Base::sum()+ a+b+c ;}

     x ;/// XX  Private can't be accessed without setters

   /*void setB(int _b){b=_b ;}
int getB(){return b ; }

void setC(int _c){c=_c ;}
int getC(){return c ; }*/

};

class Derived02 : public Derived01
{
    int k ; // private
    protected : int l ;

    public :
    int m  ;

    Derived02 (int _k ,int _l ,int _m , int _a ,int _b,int _c , int _x ,int _y,int _z)
    :Derived01(_a,_b,_c,_x,_y,_z)
    {
        k=_k ,l=_l ; m=_m ;
        //cout << "parameter constructor"<<endl ;
    }
      int sum () {
         return Derived01::sum()+ k+l+m ;
          }


          x ;/// XX  Private can't be accessed without setters
         a ;/// XX  Private can't be accessed without setters

         y ;
      /*
      public - public    // ✔
public - protected // ✔
public - private   // ✔

protected - public   // ✔
protected - protected  // ✔
protected - private  // ✔

private - public   // XX
private - protected  // XX
private - private  // XX
    */
           z ;
      /*
      public - public    // ✔
public - protected // ✔
public - private   // ✔

protected - public   // ✔
protected - protected  // ✔
protected - private  // ✔

private - public   // XX
private - protected  //XX
private - private  // XX
    */
};







int main()
{

Base o1 ;
o1.x ;/// XX  Private can't be accessed
o1.y ;/// XX protected can't be accessed
o1.z ;///✔ public can be accessed


Derived01 o2 ;
o2.x ;/// XX  Private can't be accessed
o2.y ;/// XX  protected can't be accessed
o2.z ;
/*
public - public    // ✔
public - protected // ✔
public - private   // ✔

protected - public   // XX
protected - protected  // XX
protected - private  // XX

private - public   // XX
private - protected  // XX
private - private  // XX


*/
o2.a ;/// XX  Private can't be accessed
o2.b ;/// XX protected can't be accessed
o2.c ;///✔ public can be accessed


Derived02  o3  ;

o3.x ;/// XX  Private can't be accessed
o3.y ;/// XX  protected can't be accessed
o3.z ;

/*
public - public    // ✔
public - protected // XX
public - private   // XX

protected - public   // XX
protected - protected  // XX
protected - private  //XX

private - public   // XX
private - protected  // XX
private - private  // XX
*/

o3.a ;/// XX  Private can't be accessed
o3.b ;/// XX protected can't be accessed
o3.c ;

/*
public - public    // ✔
public - protected // XX
public - private   //XX

protected - public   // ✔
protected - protected  // XX
protected - private  // XX

private - public   // ✔
private - protected  // XX
private - private  // XX
*/
o3.k ; /// XX  Private can't be accessed
o3.l ; /// XX protected can't be accessed
o3.m ; ///✔ public can be accessed




    return 0;
}
