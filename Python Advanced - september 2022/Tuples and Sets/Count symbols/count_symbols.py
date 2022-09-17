chars = input()
my_dict = {}

for char in chars:
    if char in my_dict.keys():
        my_dict[char] += 1
    else:
        my_dict[char] = 1

for i in sorted(my_dict.keys()):
    print(f"{i}: {my_dict[i]} time/s")