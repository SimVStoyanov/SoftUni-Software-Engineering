food_in_kg = float(input())
hay_in_kg = float(input())
cover_in_kg = float(input())
weight_in_kg = float(input())

food_in_grams = food_in_kg * 1000
hay_in_grams = hay_in_kg * 1000
cover_in_grams = cover_in_kg * 1000
weight_in_grams = weight_in_kg * 1000

no_left_food = False

for day in range(1, 30 + 1):
    food_in_grams -= 300
    if food_in_grams <= 0:
        no_left_food = True

    if day % 2 == 0:
        hay_in_grams -= food_in_grams * 0.05
        if hay_in_grams <= 0:
            no_left_food = True

    if day % 3 == 0:
        cover_in_grams -= weight_in_grams * 1/3
        if cover_in_grams <= 0:
            no_left_food = True

if no_left_food:
    print("Merry must go to the pet store!")
else:
    print(f"Everything is fine! Puppy is happy! Food: {food_in_grams/1000:.2f}, Hay: {hay_in_grams/1000:.2f}, Cover: {cover_in_grams/1000:.2f}.")
