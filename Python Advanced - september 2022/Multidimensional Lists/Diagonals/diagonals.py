rows = int(input())
matrix = [input().split(', ') for i in range(rows)]

primary_diagonal = []
secondary_diagonal = []

for idx in range(rows):
    primary_diagonal.append(matrix[idx][idx])
    secondary_diagonal.append(matrix[idx][rows - idx - 1])

print(f"Primary diagonal: {', '.join(primary_diagonal)}. Sum: {sum(map(int, primary_diagonal))}")
print(f"Secondary diagonal: {', '.join(secondary_diagonal)}. Sum: {sum(map(int, secondary_diagonal))}")
