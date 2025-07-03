//Функциите може да имат и да нямат параметри (входни данни)

fun myFunction(
    firstParam: Int = 0,
    secondParam: String = "string",
    thirdParam: Boolean = true
) {}

myFunction()
myFunction(0, "a", true)
//====================================

//при извикване на параметър android studio директно изисква какъв вид данни да се подадат (в зависимост от първоначално конфигурираното)
myFunction(
    firstParam = 0,
    secondParam = "b",
    thirdParam = false
)
//=======================================

//optional parameter - дефинираме параметър който да подаваме или да не подаваме, като му заложим стойност по подразбиране null. Става с ?
//проверяваме дали е null
fun functionOne(param: String? = null) {
    if (param == null) {
        return
    }
}

functionOne()
functionOne("valid")
//===================================

//return function
fun functionWithReturnType(): Int {
    //... business logic
    val result =  /*some mathematics = */ 1
    return result
}
//====================================

//function without return type
fun functionWithoutReturnType(): Unit {
    //..business logic
    return Unit
}

fun functionWithoutReturnType() {
    //..business logic
}

fun findValueOfSuperComplexResult1(a: Int, b: Int) = a + b
fun findValueOfSuperComplexResult2(a: Int, b: Int): Int = a + b

fun getCurrentTime(): String = "2023-10-17 19:47"
//=====================================

// функции според типа на тяхното деклариране infix функции - те са само с един параметър
infix fun Int.plus(that: Int): Int {
    // val result = this + that
    // println("Adding $this to $that = $result
    println("Adding $this to $that = ${this + that}")
    return this + that
}

val a = 5
val b = 6
val result = a plus b
result

//=================================

//Tail recursive functions - функции правещо обръщение сами към себе си
//*Има вероятност за вкарване в безкраен цикъл
//Тези функции не се използват широко

tailrec fun tailrecFun(x: Int): Int{
    val newX = x + 1
    return  if (newX == 10)
        newX
    else
        tailrecFun(newX)
}

//Extension function
// Честа операция да се премести в една функция

fun Int.describe() {
    println("This is Integer variable with value: $this")

}

val c = 20
c.describe()

fun Int.description(): String {
    return "This is Integer variable with value: $this"
}
val description = c.description()
println(description)

fun HashMap<Int, String>.description(): String {
    var description = ""
    for (entry in this.entries) {
        description += "${ entry.key + 1 } => ${ entry.value}"
    }
    return  description
}

val hashMap = HashMap<Int, String>()
hashMap[0] = "zero"
hashMap[1] = "one"
hashMap.description()


// Lambda functions
// Функции от високо ниво, които могат да върнат функция.
// Използват се където има по-високо ниво на динамичност

//чиста lambda function
val lambdaFun = { a: Int, b: Int -> a + b }

// анонумна function - има само fun, без име
// за да се използва, резултата от нея се присвоява на променлива
val anonymousFun = fun(a: Int, b : Int): Int{
    return a + b
}

val add = { a: Int, b: Int -> a + b }

val subtract = fun(a: Int, b: Int): Int {
    println("Subtracting $b from $a = ${a - b}")
    return a - b
}

fun doMathAndCheckIfEven(
    a: Int,
    b: Int,
    mathFunction: (Int, Int) -> Int
): Boolean {
    val result = mathFunction(a, b)
    return result % 2 == 0
}

doMathAndCheckIfEven(2, 2, add)
doMathAndCheckIfEven(2, 1, subtract)


val numbers = arrayOf(1, 2, 3, 4, 5, 6)
numbers.filter { it % 2 == 0 }

val data = arrayOf(3.2, 1.8, 5.1234, 54.273, 2.0212)
data.toList()
data
    .filter { it.toInt() >= 3 }
    .sortedBy { it.toInt() }
    .map { it.toInt() }







