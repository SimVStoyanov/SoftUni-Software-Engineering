size = int(input())

matrix = []

for _ in range(size):
    matrix.append([int(x) for x in input().split()])

diagonal = 0
for idx in range(size):
    diagonal += matrix[idx][idx]

print(diagonal)