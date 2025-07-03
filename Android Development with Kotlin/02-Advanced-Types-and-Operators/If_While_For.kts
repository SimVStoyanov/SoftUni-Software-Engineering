import java.util.Random

// if expression
val a = Random().nextInt()
println(a)
if (a % 2 == 0) {
    println("a is even")
} else if (a % 2 > 0) {
    println("a is odd")
} else {
    println("a is negative")
}


val bool = false
val b = if (bool) {
    1
} else if (!bool) {
    2
} else {
    3
}

//while Loop

val arrayList = ArrayList<Int>()
do {
    val nexInt = Random().nextInt()
    arrayList.add(nexInt)
} while (arrayList.size < 10)

arrayList

var hasNotReachedLimit = true
val arrayList2 = ArrayList<Int>()
do {
    val nexInt = Random().nextInt()
    arrayList2.add(nexInt)
    hasNotReachedLimit = arrayList2.size < 10
} while (hasNotReachedLimit)
arrayList2

//For Loop

arrayList2
for (nextInt in arrayList2) {
    if (nextInt < 0) {
        continue
    }

    if (nextInt % 2 == 0) {
        println("Even number: $nextInt")
    } else {
        println("Odd number: $nextInt")
    }
}














