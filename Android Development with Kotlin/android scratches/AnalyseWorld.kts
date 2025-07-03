fun HashMap<Char, Int>.describe(): String {
    var description = ""
    for (entry in this.entries.sortedByDescending { it.value }) {
        description += "\n  ${entry.key} => ${entry.value}"
    }

    return description
}

fun analyseWord() {
    val vowels = listOf('a', 'e', 'i', 'o', 'u')
    val characterMap = HashMap<Char, Int>()
    var vowelsCount = 0
    var consonantCount = 0
    do {
        println("Provide your world for analysis:")
        val userInput = readLine() ?: return

        for (char in userInput) {
            if (vowels.indexOf(char) != -1) {
                vowelsCount++
            } else {
                consonantCount++
            }

            var occurrences = characterMap.getOrDefault(char, 0)
            characterMap[char] = ++occurrences
        }

        println("Vowels count: $vowelsCount")
        println("Constants count: $consonantCount")
        println("Character count: ${characterMap.describe()}")
    } while (true)
}

analyseWord()