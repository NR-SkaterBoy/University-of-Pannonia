function beker() {
    let bekerszam = []
    let isvalid = true
    let i = 0

    while (i < 5 && isvalid) {
        readed = parseInt(prompt("Kérem adja meg az " + (i + 1) + ". értéket"));
        isvalid = !!readed;
        if(!isvalid) break
        bekerszam.push(readed)
        i++
    }

    // Sum
    let sum = 0;
    /**
     * Bekerszam: Objektum
     * ForEach: Ciklus
     * e: változó
     * 
     * Működés:
     * Végigmegy a tömbön, és a tömb i-edik elemének az értékét felveszi az e változó
     */
    bekerszam.forEach(e => {
        sum+=e;
    });
    document.getElementById("summa").textContent = `A számok összege: ${sum}`

    //Szorzat
    let szorzat = 1
    bekerszam.forEach(e => {
        szorzat *= e
    });
    document.getElementById("szorzat").textContent = `A számok szorzata: ${szorzat}`

    // Átlag
    let db = 0;
    bekerszam.forEach(e => {
        db++
    });
    document.getElementById("atlag").textContent = `A számok átlaga: ${(db / sum) * 100}`

}