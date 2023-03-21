function calc() {
    var sum = 0, flag = 0;

    do {
        var x = parseInt(prompt("Enter a new number", "0"));
        if (isFinite(x) && x !== 0) {
            sum += x;
        }
        else flag = 1;

    } while (sum <= 100 && !flag);

    document.write(sum);
}


