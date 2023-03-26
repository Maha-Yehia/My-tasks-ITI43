console.log("1");//0

fun();//1

setTimeout(function (){
    console.log(6);
    
},500)//8

setTimeout(function (){
    console.log(7);
    
},0);//7

console.log("2");//2
console.log("3");//3

fun()//4

console.log("4");//5
console.log("5");//6


function fun(){
    console.log(8);
}