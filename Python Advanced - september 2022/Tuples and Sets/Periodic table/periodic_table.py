n = int(input())

elements_set = set()

for _ in range(n):
    elements = input().split()
    for element in elements:
        elements_set.add(element)

for element in elements_set:
    print(element)
