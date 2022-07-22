import re

sentence = input()
search_word = input()

pattern = fr'\b{search_word}\b'
matches = re.findall(pattern, sentence, flags=re.IGNORECASE)
print(len(matches))
