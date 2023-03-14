function loadXMLDoc() {
    var xmlUrl = "cd_catalog.xml";
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            parseXML(this);
        }
    };
    xmlhttp.open("GET", xmlUrl, true);
    xmlhttp.send();
}

function parseXML(xml) {
    var xmlDoc = xml.responseXML;
    console.log(xml.responseXML)
    var table = document.getElementById("table");
    var rows = xmlDoc.getElementsByTagName("row");
    for (var i = 0; i < rows.length; i++) {
        var cells = rows[i].getElementsByTagName("cell");
        var row = table.insertRow(i);
        for (var j = 0; j < cells.length; j++) {
            var cell = row.insertCell(j);
            cell.innerHTML = cells[j].childNodes[0].nodeValue;
        }
    }
}

document.getElementById("xmlButton").addEventListener("click", loadXMLDoc);
