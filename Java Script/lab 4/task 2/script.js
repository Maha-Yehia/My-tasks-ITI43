var img1 = "1.jpg",
    img2 = "2.jpg",
    img3 = "3.jpg",
    img4 = "4.jpg",
    img5 = "5.jpg",
    img6 = "6.jpg",
    timer;

CurrentImg = img1;


function next() {
    if (CurrentImg == img1) {
        document.getElementById("myImg").src = img2;
        CurrentImg = img2;
    }

    else if (CurrentImg == img2) {
        document.getElementById("myImg").src = img3;
        CurrentImg = img3;
    }

    else if (CurrentImg == img3) {
        document.getElementById("myImg").src = img4;
        CurrentImg = img4;
    }
    else if (CurrentImg == img4) {
        document.getElementById("myImg").src = img5;
        CurrentImg = img5;
    }
    else if (CurrentImg == img5) {
        document.getElementById("myImg").src = img6;
        CurrentImg = img6;
    }

}

function prev() {
    if (CurrentImg == img6) {
        document.getElementById("myImg").src = img5;
        CurrentImg = img5;
    }

    else if (CurrentImg == img5) {
        document.getElementById("myImg").src = img4;
        CurrentImg = img4;
    }

    else if (CurrentImg == img4) {
        document.getElementById("myImg").src = img3;
        CurrentImg = img3;
    }
    else if (CurrentImg == img3) {
        document.getElementById("myImg").src = img2;
        CurrentImg = img2;
    }
    else if (CurrentImg == img2) {
        document.getElementById("myImg").src = img1;
        CurrentImg = img1;
    }
}


function cirNext() {
    next();
    if (CurrentImg == img6) {
        document.getElementById("myImg").src = img1;
        CurrentImg = img1;
    }
}


function slideShow() {
    timer = setInterval(cirNext, 2000);
}

function stop() {
    clearInterval(timer);
}