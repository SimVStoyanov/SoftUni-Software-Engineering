targets = input().split(" ")

int_targets = list(map(int, targets))

command = input()
shoots = 0

while command != "End":
    index = int(command)

    if index < len(int_targets):
        current_target = int_targets[index]
        int_targets[index] = -1
        shoots += 1
        for each_targets in range(len(int_targets)):
            if int_targets[each_targets] != -1:
                if int_targets[each_targets] > current_target:
                    int_targets[each_targets] -= current_target

                elif int_targets[each_targets] <= current_target:
                    int_targets[each_targets] += current_target

    current_target = 0
    command = input()
final_string = list(map(str, int_targets))
result = " ".join(final_string)
print(f"Shot targets: {shoots} -> {result}")