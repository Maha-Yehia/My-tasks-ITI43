
var myImgs = [];
for (i in document.images)
    myImgs[i] = document.images[i];

var pics = ["1.gif", "3.gif", "4.gif", "2.gif", "5.gif", "2.gif", "1.gif", "6.gif", "6.gif", "4.gif", "3.gif", "5.gif"];
var imgOpened;
var isSecond = false;

function display(myImg) {
    if (isSecond == false) {
        var indx = myImgs.indexOf(myImg);
        isSecond = true;
        myImgs[indx].src = pics[indx];
        imgOpened = indx;
    }
    else if (isSecond) {
        var indx = myImgs.indexOf(myImg);
        isSecond = false;
        myImgs[indx].src = pics[indx];
        if (myImgs[indx].src !== myImgs[imgOpened].src) {
            setTimeout(function () {
                myImgs[indx].src = "moon.gif";
                myImgs[imgOpened].src = "moon.gif";
            }, 1000)
        }
    }
}
