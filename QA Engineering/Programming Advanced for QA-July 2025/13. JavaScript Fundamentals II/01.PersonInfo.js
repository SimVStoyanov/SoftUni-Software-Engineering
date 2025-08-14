function generatePersonalInfoObject(firstName, LastName, age){

    let personalInfo = {
        firstName: firstName,
        lastName: LastName,
        age: age
    };
    return personalInfo;
}

console.log(generatePersonalInfoObject("Ivan", "Petrov", 30));

