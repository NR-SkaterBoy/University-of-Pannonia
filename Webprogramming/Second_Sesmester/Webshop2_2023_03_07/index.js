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
    balance: Math.floor(Math.random() * 10000000), // Random number
    discount: [0.1,]
}

const write = {
    goldiID: document.getElementById("goldi"),
    grandID: document.getElementById("grand"),
    miamiID: document.getElementById("miami"),
    nycID: document.getElementById("nyc"),
    kosarID: document.getElementById("kosar"),
    balanceID: document.getElementById("egyenleg"),
    currTime: document.getElementById("currTime"),
    backTime: document.getElementById("backTime"),
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
                data.grand.times--
            }
            break;
        case "miami":
            if (data.miami.times >= data.defValue) {
                data.price -= data.miami.cost
                data.miami.times--
            }
            break;
        case "nyc":
            if (data.nyc.times >= data.defValue) {
                data.price -= data.nyc.cost
                data.nyc.times--
            }
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
 * @param {"empty" | "price" | "discount" | "checkbox" | "radio"} [type="empty"] Type of the notification. Default is empty
 */
function notify(type = "empty") {
    switch (type) {
        case "price":
            alert("Erre nincs elég pénze!")
            break;
        case "discount":
            alert(`A kosár értéke ${data.price}, melynek a 10%-a ${data.price * data.discount[0]}`)
            break;
        case "checkbox":
            alert("Nem hozható létre 0 elem, vagy üres az input mező!")
            break;
        case "radio":
            alert("Nem hozható létre 0 elem, vagy üres az input mező!")
            break;
        default:
            alert("Minden tételt eltávolított a kosárból!")
            break;
    }
}

/**
 * Shows the current date and time
 */
setInterval(() => {
    const date = new Date()
    write.currTime.innerHTML = `${date.getFullYear()}.${date.getMonth()}.${date.getDay()}. - ${date.getHours()}:${date.getMinutes()}:${date.getSeconds()}`

}, 1);

/**
 * Shows the remaining time
 */
setInterval(() => {
    const date = new Date()
    const lastdate = new Date("2023.06.15")
    write.backTime.innerHTML = `Évek: ${lastdate.getFullYear() - date.getFullYear()} Hónapok: ${lastdate.getMonth() - date.getMonth()} Napok: ${lastdate.getDay() - date.getDay()}`
}, 1)

/**
 * Creates checkboxes
 * @returns Checkbox element
 */
function createCheckboxes() {
    const checkboxCount = document.getElementById("check").value;
    const checkDiv = document.getElementById("checkboxszama");
    if (parseInt(checkboxCount) == 0 || checkboxCount == '') return notify("checkbox")
    for (let i = 0; i < parseInt(checkboxCount); i++) {
        const checkbox = document.createElement("input");
        checkbox.type = "checkbox";

        const text = document.createElement("span");
        text.innerHTML = `<br>Kedvezmény ${i + 1}`;

        checkDiv.appendChild(text);
        checkDiv.appendChild(checkbox);
    }
}

/**
 * Creates radioboxes
 * @returns Radiobox element
 */
function createRadio() {
    const radioCount = document.getElementById("radio").value;
    const radioDiv = document.getElementById("radioszama");
    if (parseInt(radioCount) == 0 || radioCount == '') return notify("radio")
    for (let i = 0; i < parseInt(radioCount); i++) {
        const radiobox = document.createElement("input");
        radiobox.type = "radio";

        const text = document.createElement("span");
        text.innerHTML = `<br>Kedvezmény ${i + 1}`;

        radioDiv.appendChild(text);
        radioDiv.appendChild(radiobox);
    }
}

/**
 * Calls these functions
 */
function createObjects() {
    createCheckboxes()
    createRadio()
}

/**
 * TODO: Ellenőrizni, hogy az elemek léteznek e már
 * TODO: Minden kedvezményhez hozzon létre egy értéket, mejd ezt vonja le a végösszegből
 */