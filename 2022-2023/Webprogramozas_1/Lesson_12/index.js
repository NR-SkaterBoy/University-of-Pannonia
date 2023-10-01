const hpDiv = document.getElementById("hp")
const magiDiv = document.getElementById("magi")
const ltDiv = document.getElementById("lt")
const mazeDiv = document.getElementById("maze")
const fizetniDIv = document.getElementById("fizetni")

let hpDb = 0, magiDb = 0, ltDb = 0, mazeDb = 0, fizetni = 0

function randomSzam() {
    return Math.floor(Math.random() * (30000 - 10000)) + 10000
}
let egyenleg = randomSzam()

function showPenztarca() {
    alert(egyenleg + " Ft áll rendelkezésedre")
}

function urites() {
    hpDiv.innerHTML = 0
    magiDiv.innerHTML = 0
    ltDiv.innerHTML = 0
    mazeDiv.innerHTML = 0
    fizetniDIv.innerHTML = 0
}

function nincsEgyenleg() {
    alert(`Túlépted az egyenleget ${fizetni - egyenleg} Ft-tal! Kérlek törölj belőle`)
}

function add(konyv) {
    switch (konyv) {
        case "hp":
            hpDb++
            fizetni += 3000
            break;
        case "magi":
            magiDb++
            fizetni += 2500
            break;
        case "lt":
            ltDb++
            fizetni += 4000
            break;
        case "maze":
            mazeDb++
            fizetni += 5000
            break;
    }

    egyenleg < fizetni ? nincsEgyenleg() : hpDiv.innerHTML = hpDb,
        magiDiv.innerHTML = magiDb,
        ltDiv.innerHTML = ltDb,
        mazeDiv.innerHTML = mazeDb,
        fizetniDIv.innerHTML = fizetni
}

function minus(konyv) {
    switch (konyv) {
        case "hp":
            if (hpDb > 0)
                fizetni -= 3000
            hpDb--
            break;
        case "magi":
            if (magiDb > 0)
                fizetni -= 2500
            magiDb--
            break;
        case "lt":
            if (ltDb > 0)
                fizetni -= 4000
            ltDb--
            break;
        case "maze":
            if (mazeDb > 0)
                fizetni -= 5000
            mazeDb--
            break;
    }

    hpDiv.innerHTML = hpDb
    magiDiv.innerHTML = magiDb
    ltDiv.innerHTML = ltDb
    mazeDiv.innerHTML = mazeDb
    fizetniDIv.innerHTML = fizetni
}