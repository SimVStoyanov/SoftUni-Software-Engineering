first_string, second_sting = input().split()
total_sum = 0


if len(first_string) > len(second_sting):
    for index in range(len(second_sting)):
        total_sum += ord(first_string[index]) * ord(second_sting[index])
    for index in range(len(second_sting), len(first_string)):
        total_sum += ord(first_string[index])


elif len(second_sting) > len(first_string):
    for index in range(len(first_string)):
        total_sum += ord(first_string[index]) * ord(second_sting[index])
    for index in range(len(first_string), len(second_sting)):
        total_sum += ord(second_sting[index])

elif len(first_string) == len(second_sting):
    for index in range(len(second_sting)):
        total_sum += ord(first_string[index]) * ord(second_sting[index])

print(total_sum)