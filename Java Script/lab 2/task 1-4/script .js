function show() {

    var nameReEx = /^[a-z]+$/gi;
    var telReEx = /^[0-9]{8}$/;
    var mobReEx = /^01[0-2][0-9]{8}$/;
    var emailReEx = /^.+@.+.com$/;
    var coloReEx = /red|green|blue/;

    do {
        var name = prompt("Please enter your name", "Ali");
    } while (nameReEx.test(name) == false);

    do {
        var tel = prompt("Please enter your phone number", "88888888");
    } while (telReEx.test(tel) == false);

    do {
        var mob = prompt("Please enter your mobile number", "01211111111");
    } while (mobReEx.test(mob) == false);


    do {
        var email = prompt("Please enter your email address", "mmm@gmail.com");
    } while (emailReEx.test(email) == false);

    do {
        var color = prompt("Please choose a color", "(red, green or blue)");
    } while (coloReEx.test(color) == false);


    document.write('Welcome dear guest '.fontcolor(color) + name + '<br>');
    document.write('Your telephone number is '.fontcolor(color) + tel + '<br>');
    document.write('Your mobile number is '.fontcolor(color) + mob + '<br>');
    document.write('Your email address is '.fontcolor(color) + email + '<br>');

}

show(); 