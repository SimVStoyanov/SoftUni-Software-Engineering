function solve(input) {
    let addressBook = {};

    for (let entry of input) {
        let [name, address] = entry.split(':');
        addressBook[name] = address; 
    }

    let sortedNames = Object.keys(addressBook).sort();

    for (let name of sortedNames) {
        console.log(`${name} -> ${addressBook[name]}`);
    }
}