max_number_of_electrons = int(input())
electrons = 0
shell_number = 0
electronic_shells = []

while True:
    shell_number += 1
    current_electrons = 2 * shell_number ** 2
    if electrons + current_electrons > max_number_of_electrons:
        last_shell = max_number_of_electrons - electrons
        electronic_shells.append(last_shell)
        break
    elif electrons + current_electrons == max_number_of_electrons:
        electrons += current_electrons
        electronic_shells.append(current_electrons)
        break

    else:
        electrons += current_electrons
        electronic_shells.append(current_electrons)
print(electronic_shells)