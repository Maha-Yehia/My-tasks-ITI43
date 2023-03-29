let { FlightTicket } = require("../Modules/eventModule");
let t1 = new FlightTicket(1, "s1", "a1", "Cairo", "America", "30-3-2023");
let t2 = new FlightTicket(2, "s2", "a1", "Cairo", "America", "30-3-2023");
let t3 = new FlightTicket(3, "s3", "a2", "Alex", "France", "31-3-2023");
let t4 = new FlightTicket(4, "s4", "a2", "Alex", "France", "31-3-2023");
let t5 = new FlightTicket(5, "s5", "a2", "Alex", "France", "31-3-2023");
let t6 = new FlightTicket(6, "s6", "a3", "Giza", "Germany", "1-4-2023");
let t7 = new FlightTicket(7, "s7", "a3", "Giza", "Germany", "1-4-2023");
let updatedT2 = new FlightTicket(2, "s15", "a8", "Suez", "Swede", "7-4-2023");
FlightTicket.addTicket(t1);
FlightTicket.addTicket(t2);
FlightTicket.addTicket(t3);
FlightTicket.addTicket(t4);
FlightTicket.addTicket(t5);
FlightTicket.addTicket(t6);
FlightTicket.addTicket(t7);


let myTicket = FlightTicket.getTicketById(1);
console.log(myTicket);
FlightTicket.updateTicket(2, updatedT2);
FlightTicket.updateTicket(1, { departureAirport: "Mansoura" });
FlightTicket.updateTicket(6, { seatNum: "s20" });

console.log(FlightTicket.tickets);