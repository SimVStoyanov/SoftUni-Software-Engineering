import re

text = input()
counter = 0
valid_list = []
pattern = r"(?P<surr>\@|\#)(?P<word_one>[A-Za-z]{3,})(?P=surr){2}(?P<word_two>[A-Za-z]{3,})(?P=surr)"
matches = re.finditer(pattern, text)
for match in matches:
    first_word = match.group("word_one")
    second_word = match.group("word_two")
    counter += 1
    if first_word == second_word[::-1]:
        valid_list.append(f"{first_word} <=> {second_word}")

if not matches or counter == 0:
    print(f"No word pairs found!")
else:
    print(f"{counter} word pairs found!")
if not valid_list:
    print(f"No mirror words!")
else:
    print("The mirror words are:")
    print(", ".join(valid_list))