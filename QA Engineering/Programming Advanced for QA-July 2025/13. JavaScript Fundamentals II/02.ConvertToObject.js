function convertString(stringDate){

    let dataToObject = JSON.parse(stringDate)

    let entries = Object.entries(dataToObject)

    entries.forEach(entry => {
        console.log(`${entry[0]}: ${entry[1]}`)
    })
}
convertString(`{"name": "Tsetan", "age": 33, "town": "Pleven"}`)
