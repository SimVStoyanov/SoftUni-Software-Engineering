rows, cols = tuple(map(int, input().split()))
snake = input()
matrix = []
idx = 0

for row in range(rows):
    result = ''
    for col in range(cols):
        result += snake[idx % len(snake)]
        idx += 1

    if row % 2 == 0:
        matrix.append(result)
    else:
        matrix.append(result[::-1])

for submatrix in matrix:
    print(*submatrix, sep='')

