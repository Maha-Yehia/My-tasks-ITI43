class FlightTicket {
    constructor(id, seatNum, flightNum, departureAirport, arrivalAirport, travelDate) {
        this.id = id;
        this.seatNum = seatNum;
        this.flightNum = flightNum;
        this.departureAirport = departureAirport;
        this.arrivalAirport = arrivalAirport;
        this.travelDate = travelDate;
    }
    static tickets = [];

    static addTicket(ticket) {
        this.tickets.push(ticket);
    }
    static getTicketById(id) {
        return this.tickets.find(ticket => ticket.id === id);
    }
    static updateTicket(id, updates) {
        const index = this.tickets.findIndex(ticket => ticket.id === id);
        if (index === -1) {
            console.log('Ticket is not found');
            return
        }

        this.tickets[index] = { ...this.tickets[index], ...updates };
        // this.tickets[index].seatNum == updates.seatNum;
        // this.tickets[index].flightNum == updates.flightNum;
        // this.tickets[index].departureAirport == updates.departureAirport;
        // this.tickets[index].arrivalAirport == updates.arrivalAirport;
        // this.tickets[index].travelDate == updates.travelDate;

    }
}

module.exports = {
    FlightTicket
}