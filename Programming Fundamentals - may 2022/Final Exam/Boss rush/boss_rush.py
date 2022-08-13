import re

num_of_inputs = int(input())
match = ()
pattern = r'\|(?P<name>[A-Za-z]{4,})\|\:\#(?P<title1>[A-Za-z]+)\ (?P<title2>[A-Za-z]+)\#'

for i in range(num_of_inputs):
    command = input()
    matches = re.finditer(pattern, command)
    if matches == None:
        print("Access denied!")

    for match in matches:
        user_name = match.group("name")
        title_one = match.group('title1')
        title_two = match.group('title2')
        print(f"{user_name}, The {title_one} {title_two}")
        print(f">> Strength: {len(user_name)}")
        print(f">> Armor: {len(title_one + title_two) + 1}")
