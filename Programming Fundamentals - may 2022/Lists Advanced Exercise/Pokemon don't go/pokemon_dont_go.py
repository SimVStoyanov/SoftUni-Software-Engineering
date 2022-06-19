distance = input()
distance_to_pokemons = distance.split(' ')
sum_of_removed_elements = 0
while True:
    indexes = int(input())
    index_to_remove = indexes
    if index_to_remove >= len(distance_to_pokemons):
        removed_element = int(distance_to_pokemons.pop())
        distance_to_pokemons.append(distance_to_pokemons[0])
        removed_index = removed_element
    elif index_to_remove < 0:
        removed_element = int(distance_to_pokemons.pop(0))
        distance_to_pokemons.insert(0, distance_to_pokemons[-1])
        removed_index = removed_element
    else:
        removed_element = int(distance_to_pokemons.pop(index_to_remove))
        removed_index = removed_element
    distance_to_pokemons = [int(i) + removed_index if int(i) <= removed_index else int(i) - removed_index for i in distance_to_pokemons]

    sum_of_removed_elements += removed_element
    if len(distance_to_pokemons) == 0:
        print(sum_of_removed_elements)
        break
