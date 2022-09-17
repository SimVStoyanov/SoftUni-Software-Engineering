n, m = map(int, input().split())

set_1, set_2 = set(), set()

for _ in range(n):
    set_1.add(int(input()))

for _ in range(m):
    set_2.add(int(input()))

for element in set_1 & set_2:
    print(element)
