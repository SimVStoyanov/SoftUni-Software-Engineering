numbers = [int(i) for i in input().split()]


def sum_numbers(command: str, numbers_list: list):
    if command == 'negative':
        reworked_list = [i for i in numbers_list if i < 0]
    else:
        reworked_list = [i for i in numbers_list if i > 0]

    sum_reworked_list = sum(reworked_list)
    print(sum_reworked_list)
    return sum_reworked_list


sum_negative_numbers = sum_numbers('negative', numbers)
sum_positive_numbers = sum_numbers('positive', numbers)

if abs(sum_negative_numbers) > sum_positive_numbers:
    print("The negatives are stronger than the positives")
else:
    print("The positives are stronger than the negatives")

