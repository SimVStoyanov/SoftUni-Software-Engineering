n = int(input())

stack = []
for _ in range(n):
    command = input()

    if command[0] == '1':
        stack.append(int(command.split()[1]))
    elif command[0] == '2':
        if stack:
            stack.pop()
    elif command[0] == '3':
        if stack:
            print(max(stack))
    elif command[0] == '4':
        if stack:
            print(min(stack))

print(*stack[::-1], sep=', ')