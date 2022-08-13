import re

pattern = r"(@|#)[A-Za-z]{3,}\1\1[A-Za-z]{3,}\1"

text = input()

result = re.finditer(pattern, text)
mirror_words = []
count_match = 0
for match in result:
    current_match = match.group()
    index = int(len(current_match)/2)
    first_part, second_part = current_match[:index], current_match[index:]
    if first_part == second_part[::-1]:
        word = first_part.strip(first_part[0])
        mirror_words.append(f"{word} <=> {word[::-1]}")
    count_match += 1
if count_match == 0:
    print("No word pairs found!")
else:
    print(f"{count_match} word pairs found!")

if not mirror_words:
    print("No mirror words!")
else:
    print(f"The mirror words are:")
    print(", ".join(mirror_words))


