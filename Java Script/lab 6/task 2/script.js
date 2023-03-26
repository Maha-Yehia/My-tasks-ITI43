
var newImg = document.createElement("img");
blank = document.createElement("div");
newImg.src = "dom.jpg";
document.body.prepend(blank);
document.body.appendChild(newImg);
blank.appendChild(document.getElementsByTagName("img")[0]);
blank.style.textAlign = "right";
document.getElementById("nav").style = "list-style-type:circle"




