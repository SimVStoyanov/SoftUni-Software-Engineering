first_string = input()
second_string = input()

last_string = first_string
for index in range(len(second_string)):
    left_part = second_string[:index +1]   # [0:index+1:1]
    right_part = first_string[index +1:]   # [0:len(first_string):1]
    current_string = left_part + right_part
    if current_string == last_string:
        continue
    print(current_string)
    last_string = current_string
