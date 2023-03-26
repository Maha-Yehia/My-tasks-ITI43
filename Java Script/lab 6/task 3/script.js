var childWindow;
var imgSel;
var txt;

function GenerateMSG() {
    childWindow = window.open(
        "welcome.html",
        "",
        "width = 600 , heigth = 600"
    );

    var selPic = document.getElementsByName("Pics");
    for (var i = 0; i < selPic.length; i++) {
        if (selPic[i].checked) imgSel = selPic[i];
    }
    txt = document.getElementById("text").value;
    childWindow.onload = function () {
        var br = document.createElement("br");

        var text1 = document.createElement("h2");
        var txtElem = document.createTextNode(txt);
        text1.append(txtElem);
        childWindow.document.body.prepend(text1);

        document.body.prepend(br);
        const btn1 = document.createElement("input");
        btn1.setAttribute("type", "button");
        btn1.setAttribute("value", "close");
        btn1.setAttribute("id", "boot");
        childWindow.document.body.prepend(btn1);
        childWindow.document.body.prepend(br);
        childWindow.document.body.prepend(br);

        const imgChild = document.createElement("img");
        imgChild.setAttribute("src", + imgSel.id + ".jpg");
        imgChild.setAttribute("height", "400px");
        imgChild.setAttribute("width", "400px");

        childWindow.document.body.prepend(imgChild);

        childWindow.document.getElementById("boot").onclick = function () {
            childWindow.window.close();
        };
    };
}
