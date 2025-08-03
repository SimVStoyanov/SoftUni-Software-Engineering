function solve(input) {
    let words = input.toLowerCase().split(' ');
    let occurrences = {};

    for (let word of words) {
        occurrences[word] = (occurrences[word] || 0) + 1;
    }

    let result = [];

    for (let word of words) {
        if (occurrences[word] % 2 !== 0 && !result.includes(word)) {
            result.push(word);
        }
    }

    console.log(result.join(' '));
}

oddOccurences('Cake IS SWEET is Soft CAKE sweet Food');

