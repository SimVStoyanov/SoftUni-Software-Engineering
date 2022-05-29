number_of_snowballs = int(input())
max_snowball_weight = 0
max_snowball_time = 0
max_snowball_quality = 0
max_snowball_value = 0
for snowball in range(number_of_snowballs):
    current_snowball_weight = int(input())
    current_snowball_time = int(input())
    current_snowball_quality = int(input())
    current_snowball_value = (current_snowball_weight / current_snowball_time) ** current_snowball_quality
    if current_snowball_value > max_snowball_value:
        max_snowball_weight = current_snowball_weight
        max_snowball_time = current_snowball_time
        max_snowball_value = current_snowball_value
        max_snowball_quality = current_snowball_quality
print(f"{max_snowball_weight} : {max_snowball_time} = {int(max_snowball_value)} ({max_snowball_quality})")
