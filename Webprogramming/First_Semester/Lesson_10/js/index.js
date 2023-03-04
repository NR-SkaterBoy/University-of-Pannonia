const priceDiv = document.getElementById("price")
// const egyenlegSpan = document.getElementById("egyenleg")
let price = 0
let egyenleg = 500000

// Szallasok (db)
const elsoDiv = document.getElementById("elso")
const masodikDiv = document.getElementById("masodik")
const harmadikDiv = document.getElementById("harmadik")
const negyedikDiv = document.getElementById("negyedik")

let elso = 0, masodik = 0, harmadik = 0, negyedik = 0

function egyenlegTullepes() {
    alert(`Az egyenleged túllépnéd ${price - egyenleg} Ft-tal! Kérlek törölj a kosár tartalmából!`)
}

function addValue(villa) {
    switch (villa) {
        case "hist":
            price += 110000
            elso++
            break;
        case "medi":
            price += 279000
            masodik++
            break;
        case "bete":
            price += 169000
            harmadik++
            break;
        case "lilla":
            price += 242000
            negyedik++
            break;
    }
    price > egyenleg ? egyenlegTullepes() : priceDiv.innerHTML = price, elsoDiv.innerHTML = elso, masodikDiv.innerHTML = masodik, harmadikDiv.innerHTML = harmadik, negyedikDiv.innerHTML = negyedik
}

function removeValue(villa) {
    switch (villa) {
        case "hist":
            if (elso > 0) {
                price -= 110000
                elso--
            }
            break;
        case "medi":
            if (masodik > 0) {
                price -= 279000
                masodik--
            }
            break;
        case "bete":
            if (harmadik > 0) {
                price -= 169000
                harmadik--
            }
            break;
        case "lilla":
            if (negyedik > 0) {
                price -= 242000
                negyedik--
            }
            break;
    }
    priceDiv.innerHTML = price
    elsoDiv.innerHTML = elso
    masodikDiv.innerHTML = masodik
    harmadikDiv.innerHTML = harmadik
    negyedikDiv.innerHTML = negyedik
}