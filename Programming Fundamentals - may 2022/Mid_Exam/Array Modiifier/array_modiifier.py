numbers = input().split(" ")
numbers = list(map(int, numbers))

line = input()

while line != "end":
    if line == "decrease":
        numbers = list(map(lambda n: n - 1, numbers))
    else:
        next_step = line.split(" ")
        command = next_step[0]
        index1 = int(next_step[1])
        index2 = int(next_step[2])

        if command == "swap":
            numbers[index1], numbers[index2] = numbers[index2], numbers[index1]

        if command == "multiply":
            numbers[index1] = numbers[index1] * numbers[index2]
    line = input()

numbers = list(map(str, numbers))
final_result = ", ".join(numbers)
print(final_result)



