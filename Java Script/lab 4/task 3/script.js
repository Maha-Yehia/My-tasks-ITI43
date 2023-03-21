var timer;
var i = 0;
function moving() {
    timer = setInterval(function () {
        if (i <= 3) {
            if (i == 0) {
                document.images[4].src = "marble1.jpg";
                document.images[i].src = "marble3.jpg";
                i++
            }

            else {
                document.images[i - 1].src = "marble1.jpg";
                document.images[i].src = "marble3.jpg";
                i++;
            }
        }
        else if (i == 4) {
            document.images[i - 1].src = "marble1.jpg";
            document.images[i].src = "marble3.jpg";
            i = 0;

        }
    }, 1000)

}
moving();
function stop() {
    clearInterval(timer);
}

function Continue() {
    moving();
}