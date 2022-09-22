rows, cols = tuple(map(int, input().split()))
matrix = [input().split() for i in range(rows)]
counter = 0

for row in range(len(matrix)):
    if row == rows - 1:
        continue
    for col in range(len(matrix[row])):
        if col == cols - 1:
            continue

        if matrix[row][col] == \
            matrix[row][col + 1] == \
            matrix[row + 1][col] == \
            matrix[row + 1][col + 1]:
                counter += 1

print(counter)


