document.getElementById("btn").onkeydown = function () {
    alert("The Ascii code is " + event.keyCode);
    alert(event.code);
    alert("The key is alt? " + event.altKey);
    alert("The key is ctrl? " + event.ctrlKey);
    alert("The key is shift? " + event.shiftKey);
}   