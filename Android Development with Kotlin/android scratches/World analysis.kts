import java.util.HashMap

fun HashMap<Char, Int>.describe(): String {
    var description = ""
    for (entry in this.entries) {
        description += "${entry.key} => ${entry.value}"
    }

    return description
}

fun analyseWord() {
    val vowels = listOf('a', 'e'. 'i', 'o', 'u')
    val characterMap = HashMap<Char, Int>()
    var vowelsCount = 0
    var consonantsCount = 0
    do {
        println("Provide yout word for analysis:")
        cal userInput = readLine() ?: return
    }
}