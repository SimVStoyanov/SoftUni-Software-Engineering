from collections import deque

colors = deque(input().split())
main_colors = ['red', 'yellow', 'blue']
secondary_colors = ['orange', 'purple', 'green']
final_colors = deque()

while colors:
    if len(colors) > 1:
        first, last = colors.popleft(), colors.pop()
        substring = first + last
        substring_2 = last + first
        if substring in main_colors or substring in secondary_colors:
            final_colors.append(substring)
        elif substring_2 in main_colors or substring_2 in secondary_colors:
            final_colors.append(substring_2)
        else:
            first_stripped, last_stripped = first[:-1], last[:-1]

            if first_stripped:
                colors.insert(len(colors) // 2, first_stripped)

            if last_stripped:
                colors.insert(len(colors) // 2, last_stripped)
    else:
        substring = colors.popleft()
        if substring in main_colors or substring in secondary_colors:
            final_colors.append(substring)

for _ in range(len(final_colors)):
    if final_colors[0] == 'orange':
        if 'red' not in final_colors or 'yellow' not in final_colors:
            final_colors.popleft()
        else:
            final_colors.append(final_colors.popleft())
    elif final_colors[0] == 'purple':
        if 'red' not in final_colors or 'blue' not in final_colors:
            final_colors.popleft()
        else:
            final_colors.append(final_colors.popleft())
    elif final_colors[0] == 'green':
        if 'blue' not in final_colors or 'yellow' not in final_colors:
            final_colors.popleft()
        else:
            final_colors.append(final_colors.popleft())
    else:
        final_colors.append(final_colors.popleft())

print(list(final_colors))

