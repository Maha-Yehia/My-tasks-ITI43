#include <iostream>

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

  };


/*Complex sub (Complex l , Complex r )
{
Complex res ;
res.setReal( l.getReal() - r.getReal()) ;
res.setImg (l.getImg() - r.getImg()) ;
return res ;
}*/


int main()
{

//enter numbers
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
c3=c1.sum(c2) ;
cout<<endl ;
cout<<"the sum of two numbers is"<<endl ;
c3.print() ;
/*c3=sub(c1,c2) ;
cout<<endl ;
cout<<"the sub of two numbers is"<<endl ;
c3.print() ;*/


cout<<"number of object in this program = "<<counter<<endl ;

//printf("number of calling the constructors = 4 \n") ;

//printf("number of calling the destructors = 5 \n") ;

}
