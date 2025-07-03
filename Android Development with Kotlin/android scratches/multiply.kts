fun multiply(){
    println("Enter integer array:")
    val userInput = readLine() ?: return
    val userInputNumbers = userInput
        .split(",")
        .map { it.toInt() }
    if (userInputNumbers.any { it == 0}) {
        println("Guessed result is 0")
    } else if (userInputNumbers.count { it < 0 } % 2 == 0) {
        println("Guessed result is positive")
    } else {
        println("Guessed result is negative")
    }
    val result = userInputNumbers.reduce { acc, i -> acc * i  }
    println("Actual result = $result")
}
multiply()