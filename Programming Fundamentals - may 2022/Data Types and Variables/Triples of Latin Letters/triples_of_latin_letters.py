number_of_letters = int(input())
for first_symbol in range(number_of_letters):
    for second_symbol in range(number_of_letters):
        for third_symbol in range(number_of_letters):
            print(f"{chr(97 + first_symbol)}{chr(97 + second_symbol)}{chr(97 + third_symbol)}")
