function getUsers(url)
{
   return new Promise(function (resolve, reject) {
      let xhr = new XMLHttpRequest();
      xhr.open('GET', url);
      xhr.onreadystatechange = function () {
          if (this.status == 200 && this.readyState == 4) {
              resolve(this.response);
          } else {
              reject("An error occurred.");
          }
      };
      xhr.send();
  });
}

let users = getUsers("https://jsonplaceholder.typicode.com/users").then(function (result) {
   let tbody = document.querySelector('tbody');
   let data = JSON.parse(result);
   for (let i = 0; i < data.length; i++) {
       let tr = document.createElement('tr');
       let td = document.createElement('td');
       td.innerHTML = data[i].id;
       tr.appendChild(td);
       td = document.createElement('td');
       td.innerHTML = data[i].name;
       tr.appendChild(td);
       td = document.createElement('td');
       td.innerHTML = data[i].phone;
       tr.appendChild(td);
       td = document.createElement('td');
       td.innerHTML = data[i].email;
       tr.appendChild(td);
       tbody.appendChild(tr);
       td = document.createElement('td');
       td.innerHTML = data[i].username;
       tr.appendChild(td);
       tbody.appendChild(tr);
       td = document.createElement('td');
       td.innerHTML = data[i].address["street"];
       tr.appendChild(td);
       tbody.appendChild(tr);
       td = document.createElement('td');
       td.innerHTML = data[i].address["zipcode"];
       tr.appendChild(td);
       tbody.appendChild(tr);
       td = document.createElement('td');
       td.innerHTML = data[i].company["name"];
       tr.appendChild(td);
       tbody.appendChild(tr);
   }
}
)





    