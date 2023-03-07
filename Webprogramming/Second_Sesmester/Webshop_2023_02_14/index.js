let data = {
    "goldi": {
        cost: 100000,
        times: 0,
    },
    "grand": {
        cost: 200000,
        times: 0,
    },
    "miami": {
        cost: 4000000,
        times: 0,
    },
    "nyc": {
        cost: 2500000,
        times: 0,
    },
    defValue: 1,
    isNull: 0, 
    price: 0, // Starting price
    balance: Math.floor(Math.random() * 10000000) // Random number
}

const write = {
    goldiID: document.getElementById("goldi"),
    grandID: document.getElementById("grand"),
    miamiID: document.getElementById("miami"),
    nycID: document.getElementById("nyc"),
    kosarID: document.getElementById("kosar"),
    balanceID: document.getElementById("egyenleg")
}

// Writes the current balance
write.balanceID.innerHTML = data.balance

/**
 * Function of the plus btn
 * @param {string} place It gives a place in USA
 */
function add(place) {
    if (data.price > data.balance) return notify("price")
    switch (place) {
        case "goldi":
            data.price += data.goldi.cost
            data.goldi.times++
            break;
        case "grand":
            data.price += data.grand.cost
            data.grand.times++
            break;
        case "miami":
            data.price += data.miami.cost
            data.miami.times++
            break;
        case "nyc":
            data.price += data.nyc.cost
            data.nyc.times++
            break;
    }
    writeData()
}

/**
 * Function of the minus btn
 * @param {string} place It gives a place in USA
 */
function minus(place) {
    if (data.goldi.times == data.isNull && data.grand.times == data.isNull && data.miami.times == data.isNull && data.nyc.times == data.isNull) return notify()
    switch (place) {
        case "goldi":
            if (data.goldi.times >= data.defValue) {
                data.price -= data.goldi.cost
                data.goldi.times--
            }
            break;
        case "grand":
            if (data.grand.times >= data.defValue) {
            data.price -= data.grand.cost
            data.grand.times--}
            break;
        case "miami":
            if (data.miami.times >= data.defValue) {
            data.price -= data.miami.cost
            data.miami.times--}
            break;
        case "nyc":
            if (data.nyc.times >= data.defValue) {
            data.price -= data.nyc.cost
            data.nyc.times--}
            break;
    }
    writeData()
}

/**
 * Set the default values
 */
function resetData() {
    data.goldi.price = data.isNull
    data.goldi.times = data.isNull
    data.grand.price = data.isNull
    data.grand.times = data.isNull
    data.miami.price = data.isNull
    data.miami.times = data.isNull
    data.nyc.price = data.isNull
    data.nyc.times = data.isNull
    data.price = data.isNull
    writeData() // Change value on the page
}

/**
 * Write data into the index.html
 * @returns Data of object
 */
function writeData() {
    write.goldiID.innerHTML = data.goldi.times
    write.grandID.innerHTML = data.grand.times
    write.miamiID.innerHTML = data.miami.times
    write.nycID.innerHTML = data.nyc.times
    write.kosarID.innerHTML = data.price
}

/**
 * Function of the discount
 */
function discount() { notify("discount") }

/**
 * Function of the alert messages
 * @param {"empty" | "price" | "discount"} [type="empty"] Type of the notification. Default is empty
 */
function notify(type="empty") {
    switch (type) {
        case "price":
            alert("Erre nincs elég pénze!")
            break;
        case "discount":
            alert(`A kosár értéke ${data.price}, melynek a 10%-a ${data.price * 0.9}`)
        default:
            alert("Minden tételt eltávolított a kosárból!")
            break;
    }
}