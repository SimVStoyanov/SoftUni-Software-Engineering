original_string = input()

stack = []
for i in original_string:
    stack.append(i)

reversed_string = ''

while stack:
    reversed_string += stack.pop()

print(reversed_string)
