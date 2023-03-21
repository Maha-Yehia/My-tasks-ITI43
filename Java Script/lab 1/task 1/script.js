/*while(sum>100||data==0)
{
    var sum = 0 ; 
    data = prompt("Please enter a new value" , "0"); 
    sum +=data ; 
}*/

function show() {
    var x = prompt("Please enter a message", "This is a header");
    for (i = 1; i <= 6; i++) {
        document.write("<h" + i + ">" + x + "</h" + i + ">");
    }

}
