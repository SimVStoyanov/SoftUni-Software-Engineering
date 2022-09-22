rows, cols = tuple(map(int, input().split()))
matrix = [input().split() for i in range(rows)]

biggest_square = []
biggest_square_sum = -99999999

for row in range(rows - 2):
    for col in range(cols - 2):
        square = [
            list(map(int, [matrix[row][col], matrix[row][col + 1], matrix[row][col + 2]])),
            list(map(int, [matrix[row + 1][col], matrix[row + 1][col + 1], matrix[row + 1][col + 2]])),
            list(map(int, [matrix[row + 2][col], matrix[row + 2][col + 1], matrix[row + 2][col + 2]])),
        ]
        square_sum = sum(sum(square, []))
        if square_sum > biggest_square_sum:
            biggest_square_sum = square_sum
            biggest_square = square

print(f"Sum = {biggest_square_sum}")
for square in biggest_square:
    print(" ".join(map(str, square)))

