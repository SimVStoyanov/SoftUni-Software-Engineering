listOfNumbers = input().split(", ")

for i in range(len(listOfNumbers)):
    current_number = str(listOfNumbers[i])
    is_palindrome = ""

    for digit in reversed(current_number):
        is_palindrome += digit

    if current_number == is_palindrome:
        print("True")
    else:
        print("False")
