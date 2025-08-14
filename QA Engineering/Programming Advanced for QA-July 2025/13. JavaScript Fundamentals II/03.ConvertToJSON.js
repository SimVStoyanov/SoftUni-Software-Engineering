function convertToJSON(firstName, lastName, hairColor) {

    let personObject = {
        name: firstName,
        lastName: lastName,
        hairColor: hairColor
    }

    let personObjectToJSON = JSON.stringify(personObject)

    console.log(personObjectToJSON)
}

convertToJSON("Stamat", "Ignatov", "Brown");