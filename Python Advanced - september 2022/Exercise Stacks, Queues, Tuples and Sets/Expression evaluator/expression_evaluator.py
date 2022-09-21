from functools import reduce

expression = input().split()

stack = []
for item in expression:
    if item.lstrip('-').isnumeric():
        stack.append(int(item))
    else:
        if item == '*':
            stack = [reduce(lambda x, y: x * y, stack)]
        elif item == '/':
            stack = [reduce(lambda x, y: x // y, stack)]
        elif item == '+':
            stack = [reduce(lambda x, y: x + y, stack)]
        elif item == '-':
            stack = [reduce(lambda x, y: x - y, stack)]

print(stack[0])
