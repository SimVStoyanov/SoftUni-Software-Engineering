n = int(input())
odd_set, even_set = set(), set()

for row in range(1, n + 1):
    name = input()
    value = 0
    for character in name:
        value += ord(character)

    value = int(value / row)
    if value % 2 == 0:
        even_set.add(value)
    else:
        odd_set.add(value)

sum_even_set, sum_odd_set = sum(even_set), sum(odd_set)

if sum_even_set == sum_odd_set:
    result = odd_set.union(even_set)
elif sum_odd_set > sum_even_set:
    result = odd_set.difference(even_set)
elif sum_odd_set < sum_even_set:
    result = odd_set.symmetric_difference(even_set)

print(f"{(', '.join([str(x) for x in result]))}")
