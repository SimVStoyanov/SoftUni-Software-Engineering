initial_energy = int(input())
distance = input()
won_battle_counter = 0
energy = initial_energy

while distance != "End of battle":
    moving = int(distance)

    if energy >= moving:
        energy -= moving
        won_battle_counter += 1
        if won_battle_counter % 3 == 0:
            energy += won_battle_counter

    else:
        print(f"Not enough energy! Game ends with {won_battle_counter} won battles and {energy} energy")
        break
    distance = input()

if distance == "End of battle":
    print(f"Won battles: {won_battle_counter}. Energy left: {energy}")