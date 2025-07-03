
fun String.validLength(): Boolean {
    return this.length in 6..10

}

fun String.isAlphaNumeric(): Boolean {
    return this.all{
        it in 'a'..'z' ||
        it in 'A'..'Z' ||
        it in '0'..'9'
    }
}

fun String.hasRequiredCharacter(): Boolean {
    return this.count { it in 'a'..'z' } > 0 &&
           this.count { it in 'A'..'Z'} > 0 &&
           this.count { it in '0'..'9'} >= 2
}

fun validatePassword() {
    do {
        println("Enter password:")
        val userInput = readLine() ?: return

        when {
            !userInput.validLength() -> {
                println("Password has to be between 6 and 10 characters. Count length: ${userInput.length}")
            }
            !userInput.isAlphaNumeric() -> {
                println("Password must contain only alphanumeric characters.")
            }
            !userInput.hasRequiredCharacter() -> {
                println("Password must contain at least 1 lowercase letter, 1 uppercase letter and 2 digits")
            }
            else -> {
                println("Password is valid")
                return
            }
        }

    } while (true)
}
validatePassword()