function wordTracker (array) {
    let wordToTrack = array.shift().split(' '); 

    let wordOccurences = {};


    for (let word of wordToTrack) {
        wordOccurences[word] = 0;
    }


    for (let word of array) {
        if (word in wordOccurences) {
            wordOccurences[word]++;
        }
    }


    let entries = Object.entries(wordOccurences);
    entries.sort((a, b) => b[1] - a[1]); 
    
    for (let [word, count] of entries) {
        console.log(`${word} - ${count}`)
    }
}

wordTracker([
'this sentence', 
'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurrences', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
]
);