var win;
var timerID;

function flying() {
    var x = 0, y = 0, w = 200, h = 200;  // Window position and size
    var dx = 5, dy = 5;              // Window velocity   
    var interval = 50;              // Milliseconds between updates
    win = open('index child.html', "", "width=200 , height=200");
    win.focus();

    timerID = setInterval(function () {
        win.resizeTo(200, 200)
        if ((y + dy) > (screen.availHeight - 200) || (x + dx) > (screen.availWidth - 200) || (y + dy) < 0) {
            dy = -dy;
            dx = -dx;
        }
        win.moveTo(x, y);
        x += dx;
        y += dy;

    }
        , interval);
}

function winTyping() {
    var i = 0;
    win = open("index child.html", "", "width=200 , height=200");
    arr = "maha yehia ekram fahmy assem mohamed youssef";
    arr = arr.split("");
    timerID = setInterval(function () {
        if (i > arr.length - 1) {

            win.clearInterval(timerID);
        }
        else
            win.document.write(arr[i++])
    }, 200)
}


function winScroll() {

    win = open("child.html", "", "width=200 , height=200");
    win.focus();
    timerID = setInterval(function () {
        win.scrollBy(0, 5);
    }, 100)
    setTimeout(function () { win.close() }, 2000);

}

function stop() {

    clearInterval(timerID);
    win.focus();

}

function closewin() {
    win.close();
    clearInterval(timerID);

}


