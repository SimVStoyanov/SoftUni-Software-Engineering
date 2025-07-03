//List

val unmodifiableList = listOf(1, 2, 3, 4, 5)
unmodifiableList

val modifiableList = ArrayList<Int>(5)
modifiableList

unmodifiableList[3]

modifiableList.add(1)
modifiableList
modifiableList.add(1, 100)
modifiableList

modifiableList.contains(1)

//Set
// Set Позволява да имаме сет от уникални данни. Стойностите не може да се поварят
val hashSet = hashSetOf<Int>()
//<Int> - само int
//<Int?> - int или null

hashSet.add(1)
hashSet.add(3)
hashSet.add(5)
hashSet.add(7)
hashSet.add(9)
hashSet

// премахваме даден елемтн. Тук не боравим с индекси, защото стойностите са уникални
hashSet.remove(3)
hashSet

//проверка има ли го даден елемет в set-a
hashSet.contains(4)
hashSet.contains(5)

//Map

val hashMap = HashMap<Int, String>()
hashMap

hashMap[1] = "one"
hashMap[2] = "two"
hashMap[3] = "three"
hashMap[4] = "four"
hashMap[100] = "hundred"
hashMap

hashMap[4] = "4"
hashMap

hashMap.remove(3)
hashMap.remove(2, "two") // премехва ключа 2, само ако има стройност "two". Ако няма таккав стойност ще даде false

//проверка дали ключ или стойност се съдръжа в map-a
hashMap.contains(4)
hashMap.containsKey(4)
hashMap.containsValue("four")
hashMap.containsValue("4")

val anyMap = HashMap<Int, Any>()
anyMap[0] = 0
anyMap[100] = "hundred"
anyMap[200] = true
anyMap[300] = HashMap<Int, Int>()


