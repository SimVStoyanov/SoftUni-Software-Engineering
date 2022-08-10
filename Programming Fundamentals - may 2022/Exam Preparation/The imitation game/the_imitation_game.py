message = input()
command = input()

while command != "Decode":
    command_params = command.split("|")

    if command_params[0] == "Move":
        location = int(command_params[1])
        movement = message[:location]
        static = message[location:]
        message = static + movement

    elif command_params[0] == "Insert":
        index = int(command_params[1])
        value = command_params[2]
        before = message[:index]
        after = message[index:]
        message = before + value + after

    elif command_params[0] == "ChangeAll":
        current_substring = command_params[1]
        replacement = command_params[2]
        message = message.replace(current_substring, replacement)

    command = input()
print(f"The decrypted message is: {message}")
