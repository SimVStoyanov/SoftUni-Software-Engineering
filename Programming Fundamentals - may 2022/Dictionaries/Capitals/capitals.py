counties = input().split(", ")
capitals = input().split(", ")
#result = {counties[index]: capitals[index] for index in range(len(counties))}
result = dict(zip(counties, capitals))
for country, capital in result.items():
    print(f"{country} -> {capital}")
