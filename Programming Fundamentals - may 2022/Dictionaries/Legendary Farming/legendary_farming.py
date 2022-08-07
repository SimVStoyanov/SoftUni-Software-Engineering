useful_items = {"shards": 0, "fragments": 0, "motes":0}
useless_items = {}
obtained = False
command = input().split()

while True:
    for index in range(0, len(command), 2):
        value = int(command[index])
        key = command[index + 1].lower()
        if key in useful_items.keys():
            useful_items[key] += value
        else:
            if key not in useless_items.keys():
                useless_items[key] = 0
            useless_items[key] += value
        if useful_items["shards"] >= 250:
            print("Shadowmourne obtained!")
            useful_items["shards"] -= 250
            obtained = True
        elif useful_items["fragments"] >= 250:
            print("Valanyr obtained!")
            useful_items["fragments"] -= 250
            obtained = True
        elif useful_items["motes"] >= 250:
            print("Dragonwrath obtained!")
            useful_items["motes"] -= 250
            obtained = True
        if obtained:
            break
    if obtained:
        break

    command = input().split()
for key, value in useful_items.items():
    print(f"{key}: {value}")
for key, value in useless_items.items():
    print(f"{key}: {value}")
