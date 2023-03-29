
const http = require("http");
const fs = require("fs");
const querystring = require("querystring");
let indexHtml = fs.readFileSync("../Client/index.html").toString();
let img = fs.readFileSync("../Client/Images/body-bg.gif");
let favIcon = fs.readFileSync("../Client/Icons/favicon.ico");
let script = fs.readFileSync("../Client/script.js").toString();
let welcomeHtml = fs.readFileSync("../Client/Welcome.html").toString();
let clients = JSON.parse(fs.readFileSync("../clients.json"));

http.createServer((req, res) => {
    console.log(req.url);
    //#region GET
    if (req.method == "GET") {

        switch (req.url) {
            case '/':
            case '/main.html':
            case '/Client/main.html':
            case '/main':
                res.write(indexHtml);
                break;
            case '/body-bg.gif':
            case '/Client/body-bg.gif':
            case '/Client/Images/body-bg.gif':
            case '/Images/body-bg.gif':
                res.write(img);
                break;
            case '/favicon.ico':
            case '/Client/favicon.ico':
            case '/Client/Icons/favicon.ico':
                res.write(favIcon);
                break;
            case '/script.js':
            case '/Client/script.js':
                res.write(script);
                break;

            case '/':
            case '/Welcom.html':
            case '/Client/Welcom.html':
            case '/Client/Welcom':
            case '/Welcom':

                res.write(welcomHtml);
                break;
            case '/getall':
                res.write(JSON.stringify(clients));
                break;

            default:
                res.write(welcomeHtml)
                break;
        }
        res.end();
    }
    //#endregion

    //#region POST
    else if (req.method == "POST") {
        let body = "";
        req.on("data", (data) => {
            body += data;
            const form = querystring.parse(body);
            name = form["name"];
            mobile = form["mobile"];
            email = form["email"];
            address = form["address"];
        });
        req.on("end", () => {
            const input = querystring.parse(body);
            const client = {};

            for (const [key, value] of Object.entries(input)) {
                client[key] = value;
            }

            clients.unshift(client);

            fs.writeFile('../clients.json', JSON.stringify(clients, null, 4), () => { });
            res.write(welcomeHtml.replace("{name}", name)
                .replace("{email}", email)
                .replace("{mobile}", mobile)
                .replace("{address}", address)
            )

            JSONObj = querystring.parse(body);


            //console.log(JSON.stringify(JSONObj));
            res.end();
        })
    }
    //#endregion
    //#region default
    else {
        res.end("Please select common method");
    }
    //#endregion

}).listen(7000, () => {


}) 