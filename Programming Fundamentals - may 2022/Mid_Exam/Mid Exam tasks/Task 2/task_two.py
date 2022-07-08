commands = input().split("||")
started_fuel = int(input())
started_munitions = int(input())

for command in range(len(commands)):
    command = commands[command]
    sep_command = command.split()

    if sep_command[0] == "Travel":
        light_years = int(sep_command[1])
        if started_fuel >= light_years:
            started_fuel -= light_years
            print(f"The spaceship travelled {light_years} light-years.")
        else:
            print(f"Mission failed.")

    elif sep_command[0] == "Enemy":
        enemy_armor = int(sep_command[1])
        if started_munitions >= enemy_armor:
            started_munitions -= enemy_armor
            print(f"An enemy with {enemy_armor} armour is defeated.")
        elif enemy_armor > started_munitions:
            need_to_run = enemy_armor * 2
            started_fuel -= need_to_run
            if started_fuel >= 0:
                print(f"An enemy with {enemy_armor} armour is outmaneuvered.")
            else:
                print(f"Mission failed.")
                break

    elif sep_command[0] == "Repair":
        added_ammunition = int(sep_command[1])
        added_fuel = int(sep_command[1])
        started_fuel += added_fuel
        started_munitions += (added_ammunition * 2)
        print(f"Ammunitions added: {(added_ammunition * 2)}.")
        print(f"Fuel added: {added_fuel}.")

    elif sep_command[0] == "Titan":
        print(f"You have reached Titan, all passengers are safe.")