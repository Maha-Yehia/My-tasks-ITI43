#include <iostream>
#include <string.h>


using namespace std;

int counter = 0 ;
class Complex
{
    int real ;
    int img ;

 public :

 /// constructors
     Complex (int r , int i)
    {
        real = r ;
         img = i ;
         counter++ ;
        cout<<"Constructor for different real & img"<<endl ;
    }

     Complex (int n)
    {
        real = img = n ;
        counter++ ;
        cout<<"Constructor for equal real & img"<<endl ;
    }

    Complex ()
    {
            real = img = 0 ;
            counter++ ;
        cout<<"Constructor for real & img = 0 "<<endl ;
    }


    /// destructor

    ~Complex ()
    {
        cout<<"destructor"<<endl ;
    }


     // setters
    void setReal (int r) {real = r ;}
    void setImg (int i) {img = i ;}
    // getters
    int getReal (){return real;}
    int getImg () {return img ;}



void print()
{

if ((real>0 && img>0&& img!=1)||(real<0 && img>0&& img!=1) )
  cout<<real <<"+" <<img<<"i" <<endl ;

  if ((img>0&& real == 0 && img!=1)|| (img<0&& real == 0 && img!=-1))
  cout<<img<<"i"<<endl ;

  if ((real > 0 && img < 0&& img!=-1 )|| (real < 0 && img < 0 && img!=-1) )
  cout<<real <<img<<"i" <<endl ;
  if ((real > 0&&  img == 0) ||(real < 0&&  img == 0 ) )
  cout<<real <<endl ;

   if (real ==0&&  img == 0 )
  cout<<"0" <<endl ;

  if (img == 1)

 cout<<real <<"+"<<"i" <<endl ;
 if (img == -1)

 cout<<real<<"i" <<endl ;

  }

///Pass by reference
/*Complex sum (Complex & oldc)
{
Complex num ;
num.real = real +oldc.real  ;
num.img = img + oldc.img ;
counter++ ;
return num ;
}*/

///Pass by value
/*Complex sum (Complex c)
{
Complex num ;
num.real = real +c.real  ;
num.img = img + c.img ;
return num ;
}*/

///copy constructor

Complex (Complex & oldc)
{
    real = oldc.real ;
    img = oldc.img ;
}


Complex sum (Complex c)
{
Complex num ;
num.real = real +c.real  ;
num.img = img + c.img ;
return num ;
}
//complex - complex
Complex operator - (const Complex & c)
{
    Complex result (real-c.real , img-c.img) ;
    return result ;
}

//complex - int
Complex operator - (int n )
{
    Complex result (real-n , img) ;
    return result ;
}

//-= complex
Complex & operator -= (const Complex & c)
{
   real -=c.real ;
   img -=c.img ;
    return *this ;
}

//-= int
Complex & operator -= (int n)
{
   real -=n ;

    return *this ;
}

//-- complex prefix
Complex  operator -- ()
{
   real -- ;
    return *this ;
}

// complex-- post fix
Complex operator -- (int)
{
    Complex temp(*this) ;
   real -- ;
    return temp ;
}

bool operator == (const Complex & c)
{
    return (c.real==real && c.img == img) ;
}


bool operator != (const Complex & c)
{
    return (c.real!=real || c.img != img) ;
}


bool operator > (const Complex & c)
{
    return (real>c.real || img >c.img) ;
}

bool operator >= (const Complex & c)
{
    return (real>=c.real || img >= c.img) ;
}

bool operator < (const Complex & c)
{
    return (real<c.real || img <c.img) ;
}

bool operator <= (const Complex & c)
{
    return (real<=c.real || img <= c.img) ;
}

 operator int ()

{
    return real ;
}


  };



//int - complex
Complex operator - (int n ,Complex & c)
{
    Complex result (n+c.getReal() , c.getImg()) ;

    return result ;

}



int main()
{

int i , r , i2 , r2;
cout<<"Please enter a real number #1"<<endl ;
cin>>r ;
cout<<"Please enter an imaginary number#1"<<endl ;
cin>>i ;
cout<<"Please enter a real number #2"<<endl ;
cin>>r2 ;
cout<<"Please enter an imaginary number#2"<<endl ;
cin>>i2 ;


Complex c1 ;
c1.setReal(r) ;
c1.setImg(i) ;
cout<<endl ;
c1.print() ;

Complex c2 ;
c2.setReal(r2) ;
c2.setImg(i2) ;
cout<<endl ;
c2.print() ;

Complex c3 ;
/*c3=c1-c2 ;
cout<<"******"<<endl<<endl ;
cout<<"c3=c1-c2"<<endl ;
c3.print() ;


c3=7-c1 ;
cout<<"******"<<endl<<endl ;
cout<<"c3=7-c1"<<endl ;
c3.print() ;

c3=c1-7 ;
cout<<"******"<<endl<<endl ;
cout<<"c1-7"<<endl ;
c3.print() ;


c1-=c2 ;
cout<<"******"<<endl<<endl ;
cout<<"c1-=c2"<<endl ;
c1.print() ;


c2-=7 ;
cout<<"******"<<endl<<endl ;
cout<<"c2-=7"<<endl ;
c2.print() ;



--c1 ;
cout<<"******"<<endl<<endl ;
cout<<"--c1"<<endl ;
c1.print() ;

c3=c1--;
c3.print() ;

c1-- ;
cout<<"******"<<endl<<endl ;
cout<<"c1--"<<endl ;
c1.print() ;
    return 0;*/

if (c1==c2)
    cout<<"true"<<endl ;
else  cout<<"false"<<endl ;


if (c1!=c2)
    cout<<"true"<<endl ;
else  cout<<"false"<<endl ;


if (c1<=c2)
    cout<<"true"<<endl ;
else  cout<<"false"<<endl ;


cout<<"int operator " ;
int x = (int) c1 ;
cout<<x<<endl ;

return  0 ;


}



