function solve(input) {
    let schedule = {};

    for (let entry of input) {
        let [day, name] = entry.split(' ');

        if (!schedule.hasOwnProperty(day)) {
            schedule[day] = name;
            console.log(`Scheduled for ${day}`);
        } else {
            console.log(`Conflict on ${day}!`);
        }
    }

    for (let day in schedule) {
        console.log(`${day} -> ${schedule[day]}`);
    }
}