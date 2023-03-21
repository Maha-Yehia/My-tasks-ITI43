var timeout = new Event("timeout");
var flag = 0;
document.body.addEventListener("timeout", function () {
    if (!flag) alert("You haven't entered any data!");
});

document.getElementById("userName").oninput = function () {
    flag = 1;
};
setTimeout(() => {
    if (flag == 0) {
        document.body.dispatchEvent(timeout);
    }
}, 3000);



