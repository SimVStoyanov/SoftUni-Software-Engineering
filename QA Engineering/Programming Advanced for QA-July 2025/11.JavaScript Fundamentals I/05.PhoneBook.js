function solve(input) {
    let phoneBook = {};

    for (let entry of input) {
        let [name, number] = entry.split(' ');
        phoneBook[name] = number; 
    }

    for (let name in phoneBook) {
        console.log(`${name} -> ${phoneBook[name]}`);
    }
}