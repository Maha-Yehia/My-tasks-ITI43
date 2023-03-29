document.getElementById("getall").onclick = () => {
    fetch('http://localhost:7000/getall')
        .then(response => response.json())
        .then(clients => {
            let table = document.getElementById("clients");
            let html = `
                <table class="table" style="color:white">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Mobile</th>
                            <th>Address</th>
                            <th>Email</th>
                        </tr>
                    </thead>
                    <tbody>`;

            for (let c of clients) {
                html += `
                    <tr>
                        <td>${c.name}</td>
                        <td>${c.mobile}</td>
                        <td>${c.address}</td>
                        <td>${c.email}
                    </tr> 
                `;
            }
            html += `</tbody></table>`;
            table.innerHTML = html;
        })
}