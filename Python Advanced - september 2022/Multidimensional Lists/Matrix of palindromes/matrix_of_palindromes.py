rows, cols = tuple(map(int, input().split()))

first_letter = 97
matrix = []

for row in range(rows):
    submatrix = []
    for col in range(cols):
        result = chr(first_letter + row) + chr(first_letter + col + row) + chr(first_letter + row)
        submatrix.append(result)
    print(*submatrix)
