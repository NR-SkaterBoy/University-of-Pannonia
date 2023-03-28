/**
 * A függvény létrehoz egy lekérést, és ha megfelel a feltételeknek, akkor teljesíti azt
 * @param {string} file A file útvonala
 * @returns {XMLHttpRequest} A kérés teljesítésével
 */
function loadDoc(file) {
    if (!file || (file.toString().split(".")[1] != "xml")) return
    const xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            myFunction(this)
        }
    }
    xhttp.open("GET", file, true);
    xhttp.send();
}

/**
 * A függvény feldolgozza az adatokat és egy táblázatba illeszti őket
 * @param {string} xml A loadDoc által megkapott adatok
 */
function myFunction(xml) {
    try {
        const xmlDoc = xml.responseXML;
        const x = xmlDoc.getElementsByTagName("PIZZA");
        let table = '<tr> <th onclick="shortTable(0)">ID</th> <th onclick="shortTable(1)">Name</th><th onclick="shortTable(2)">Toppings</th> <th onclick="shortTable(3)">Price</th></tr>'
        for (let i = 0; i < x.length; i++) {
            let toppingsList = '<ul>';
            for (let j = 0; j < x[i].getElementsByTagName("TOPPING").length; j++) {
                toppingsList += '<li>' + x[i].getElementsByTagName("TOPPING")[j].childNodes[0].nodeValue + '</li>';
            }
            toppingsList += '</ul>';
            table += "<tr><td>" +
                x[i].getElementsByTagName("ID")[0].childNodes[0].nodeValue +
                "</td><td>" +
                x[i].getElementsByTagName("NAME")[0].childNodes[0].nodeValue +
                "</td><td>" +
                toppingsList +
                "</td><td>" +
                x[i].getElementsByTagName("PRICE")[0].childNodes[0].nodeValue + " Ft" +
                "</td></tr>";
        }
        document.getElementById("demo").innerHTML = table;
    } catch (e) {
        alert("Hiba történt!\n", e)
    }
}

function shortTable(n) {
    var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    table = document.getElementById("demo");
    switching = true;
    dir = "asc";
    while (switching) {
        switching = false;
        rows = table.rows;
        for (i = 1; i < (rows.length - 1); i++) {
            shouldSwitch = false;
            x = rows[i].getElementsByTagName("td")[n];
            y = rows[i + 1].getElementsByTagName("td")[n];
            if (dir == "asc") {
                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                    break;
                }
            } else if (dir == "desc") {
                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    shouldSwitch = true;
                    break;
                }
            }
        }
        if (shouldSwitch) {
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            switchcount++;
        } else {
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}