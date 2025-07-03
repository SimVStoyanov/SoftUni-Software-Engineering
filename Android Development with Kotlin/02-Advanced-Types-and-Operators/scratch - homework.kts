//Calculate the factorial - Homework

val number = 8

val listOfNumbers: List<Int> = (number downTo 1).toList()
listOfNumbers


var factorial = 1
val factorialNumbers = ArrayList<Int>()
for (i in 1..number) {
    factorial *= i
    factorialNumbers.add(factorial)
    if (factorial >= 0) {
        continue
    } else {
        break
    }

}
factorialNumbers
println("Factorial of $number is: $factorial")
