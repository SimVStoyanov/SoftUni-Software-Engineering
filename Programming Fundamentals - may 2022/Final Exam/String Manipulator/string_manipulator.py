string = input()
input_command = input()
while input_command != "End":
    input_command = input_command.split(" ")
    command = input_command[0]
    if command == "Translate":
        char = input_command[1]
        repl = input_command[2]
        string = string.replace(char, repl)
        print(string)
    elif command == "Includes":
        char = input_command[1]
        if char in string:
            print("True")
        else:
            print("False")
    elif command == "Start":
        start = input_command[1]
        print(string.startswith(start))
    elif command == "Lowercase":
        string = string.lower()
        print(string)
    elif command == "FindIndex":
        char = input_command[1]
        print(string.rfind(char))
    elif command == "Remove":
        start = int(input_command[1])
        count = int(input_command[2])
        string = string.replace(string[start:start+count], "")
        print(string)
    input_command = input()