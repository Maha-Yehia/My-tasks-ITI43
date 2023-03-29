const fs = require("fs");
const http = require("http");
http.createServer((req, res) => {
    var arr = req.url.split("/");
    res.writeHead(200, "ok", { "content-type": "text/html" })

    if (req.url != "/favicon.ico") {
        let result;
        switch (arr[1]) {
            case "add":
                result = 0;
                for (let i = 2; i < arr.length; i++) {
                    result += parseFloat(arr[i]);
                }
                fs.appendFile("results.txt", "the result of adding is " + result + "\n", () => { });
                break;

            case "mul":
                result = 1;
                for (i = 2; i < arr.length; i++) {
                    result *= parseFloat(arr[i]);
                }
                fs.appendFile("results.txt", "the result of multiplication is " + result + "\n", () => { });
                break;

            case "div":
                result = arr[2];
                for (i = 3; i < arr.length; i++) {
                    result /= parseFloat(arr[i]);
                }
                fs.appendFile("results.txt", "the result of division is " + result + "\n", () => { });
                break;
            case "sub":
                result = arr[2];
                for (i = 3; i < arr.length; i++) {
                    result -= parseFloat(arr[i]);
                }
                fs.appendFile("results.txt", "the result of subtraction is " + result + "\n", () => { });
                break;
            default:
                res.end("<h2> URL is not valid </h2>");
                break;
        }

        res.end("<h2>Result = " + result + " </h2>");

    }

}).listen(7000);


