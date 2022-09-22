rows = int(input())
matrix = [input().split() for i in range(rows)]

primary_diagonal = []
secondary_diagonal = []

for idx in range(rows):
    primary_diagonal.append(matrix[idx][idx])
    secondary_diagonal.append(matrix[idx][rows - idx - 1])

primary_diagonal_sum = sum(map(int, primary_diagonal))
secondary_diagonal_sum = sum(map(int, secondary_diagonal))
difference = abs(primary_diagonal_sum - secondary_diagonal_sum)

print(f"{difference}")