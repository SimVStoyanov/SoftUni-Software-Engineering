import re

text = input()
numbers = [int(el) for el in re.findall(r"\d", text)]
cool_threshold = 1
for num in numbers:
    cool_threshold *= num
print(f"Cool threshold: {cool_threshold}")
pattern = r"(::|\*\*)[A-Z][a-z]{2,}\1"
result = re.finditer(pattern, text)
cool_emojis = []
emojis_count = 0

for match in result:
    emoji = match.group()
    emoji_without_surrounding = emoji.replace(emoji[0], "")#премаахва символите в началото и в края и остава само думата между сараундинга
    emoji_coolness = sum([ord(el) for el in emoji_without_surrounding])
    if emoji_coolness >= cool_threshold:
        cool_emojis.append(emoji) #добавяме емоджито със сарауд елементите

    emojis_count += 1 #броим емоджитата

print(f"{emojis_count} emojis found in the text. The cool ones are:")
for e in cool_emojis:
    print(e)
