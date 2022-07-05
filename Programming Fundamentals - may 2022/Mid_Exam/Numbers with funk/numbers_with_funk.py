def sorted_func(greater_number_than_average_sum):
    top_five = []

    for num in sotred(greater_number_than_average_sum)[::-1]:
        if len(top_five) < 5:
            top_five_numbers.append(num)
        else:
            break

        return " ".join([str(num) for num in top_five_numbers])

def numbers_func(numbers):
    average_sum = sum(numbers) / len(numbers)
    greater_numbers_then_average_sum = [num for num in numbers if num > average_sum]

    if greater_numbers_then_average_sum:
        print(sorted_func(greater_numbers_then_average_sum))
    else:
        print("No")
nums = list(map(int, input().split(" ")))
numbers_func(nums)
