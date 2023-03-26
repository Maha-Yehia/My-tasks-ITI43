
function display() {
    var sent = prompt("Enter any sentence or words you like", "Type a sentence");
    var temp = prompt("Enter a spicific character", "any character");
    var decision = confirm("Consider difference between letter cases ? ");

    if (decision == true) {
        //var x = sent.split(temp).length - 1;
        var x = sent.split(new RegExp(temp, 'g')).length - 1;
    }

    else {
        var x = sent.split(new RegExp(temp, 'gi')).length - 1;
    }
    alert(x);

}

display(); 