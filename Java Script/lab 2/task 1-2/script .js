function Palindrome() {
    var sent = prompt("Enter a word: ");
    var choise = confirm("Do you want to consider case sensitivity?");
    var l = sent.length;
    var temp = sent.split(""); //array 
    // alert(temp);
    temp.reverse(); //reverse array 
    var tempReversed = sent.split(""); //new array 
    // alert(sent); didin't change


    if (choise == true) {
        var flag = true;
        for (var i = 0; (i < l) && (flag == true); i++) {
            if (temp[i] != tempReversed[i])
                flag = false;
        }

        if (flag == true)
            document.write("It's a palindrome");
        else
            document.write("Not a palindrome");
    }

    else {
        var flag = true;
        for (var i = 0; (i < l) && (flag == true); i++) {
            if (temp[i].toLowerCase() == tempReversed[i] || temp[i].toUpperCase() == tempReversed[i])
                flag = true;
            else flag = false;
        }

        if (flag == true)
            document.write("It's a palindrome!");
        else
            document.write("Not a palindrome!");
    }
}

Palindrome();

