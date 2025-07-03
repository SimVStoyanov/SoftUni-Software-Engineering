import kotlin.random.Random

fun guessTheNumber() {
    val hiddenNumber = Random.nextInt(100 )
    var count = 1
    do {
        println("Guess the number:")
//        val userInput = (readLine() ?: return).toInt()
        val userInput = readLine()
        if (userInput == null) {
            println("Invalid user input: $userInput")
            return
        }
        var userInputNumber: Int
        try {
            userInputNumber = userInput.toInt()
        } catch (e: java.lang.Exception) {
            println("Invalid user input: $userInput")
            return
        }

        if (userInputNumber == hiddenNumber){
            println("You guessed the number right in attempt $count! The number is $hiddenNumber")
            return
        } else if (userInputNumber > hiddenNumber){
            println("You guess is higher than the hidden number")
        } else {
            println("You guess is lower then the hidden number")
        }
        count++
    } while (true)
}
guessTheNumber()
