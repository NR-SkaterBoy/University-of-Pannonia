var szamok = [];
function szamokBeker() {
    var i = 0;
    var isValid = true;
    var readed = "";

    while (i < 5 && isValid) {

        readed = parseInt(prompt("Kérem adja meg az " + (i + 1) + ". értéket"));
        isValid = !!readed;

        if (!isValid) {
            break;
        }
        szamok.push(readed);
        i++;
    }

    if (!isValid) {
        szamok = [];
        alert("Nem adta meg/érvénytelenül adta meg az értéket");
    } else {
        var box = document.getElementById("box");
        box.innerHTML += "Az elemek összege = " + Sum() + "<br>" + "Az elemek szorzat= " + Szorzat();
        box.style.fontWeight = "bold"
    }

}

function Szorzat() {
    var szorzat = 1;
    for (var i = 0; i < szamok.length; i++) {
        szorzat *= szamok[i];
    }
    return szorzat;
}

function Sum() {
    var sum = 0;
    for (var i = 0; i < szamok.length; i++) {
        sum += szamok[i];
    }
    return sum;
}
