var sent = prompt("Enter a sentence ", "Type a sentence");
var arr = sent.split(" ");

function displayLargest() {
    var temp = arr[0];
    for (i = 1; i < arr.length; i++) {
        if (temp.length < arr[i].length) {
            temp = arr[i];
        }
    }
    alert(temp);
}

displayLargest();

/*function displayEqual() {
    for (i = arr.length - 1; i >= 0; i++) {
        for (j = 0; j < arr.length; j++)
            if (arr[i].length == arr[j].length) {
                alert(arr[j]);
                break;
            }
    }
}

displayEqual(); */