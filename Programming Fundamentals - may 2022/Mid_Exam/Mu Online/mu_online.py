rooms = input().split("|")

initial_health = 100
health_status = initial_health
bitcoins = 0
best_room = 0
killed = False

for room in range(len(rooms)):
    best_room += 1
    command = rooms[room]
    sep_command = command.split()

    if sep_command[0] == "potion":
        health_points = int(sep_command[1])
        if health_status + health_points > initial_health:
            health_points = initial_health - health_status
            health_status = initial_health
        else:
            health_status += health_points
        print(f"You healed for {health_points} hp.")
        print(f"Current health: {health_status} hp.")

    elif sep_command[0] == "chest":
        found_bitcoins = int(sep_command[1])
        bitcoins += found_bitcoins
        print(f"You found {found_bitcoins} bitcoins.")

    else:
        monster = sep_command[0]
        attack = int(sep_command[1])
        health_status -= attack
        if health_status > 0:
            print(f"You slayed {monster}.")
        else:
            print(f"You died! Killed by {monster}.")
            print(f"Best room: {best_room}")
            killed = True
            break
if not killed:
    print(f"You've made it!")
    print(f"Bitcoins: {bitcoins}")
    print(f"Health: {health_status}")






