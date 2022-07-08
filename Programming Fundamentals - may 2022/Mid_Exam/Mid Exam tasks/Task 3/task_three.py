phones = input().split(", ")

command = input()

while command != "End":
    command_list = command.split(" - ")
    first_command = command_list[0]

    if first_command == "Add":
        phone = command_list[1]
        if phone not in phones:
            phones.append(phone)

    elif first_command == "Remove":
        phone = command_list[1]
        if phone in phones:
            phones.remove(phone)

    elif first_command == "Bonus phone":
        phone = command_list[1]
        old_new_phone = phone.split(":")
        old_phone = old_new_phone[0]
        new_phone = old_new_phone[1]
        if old_phone in phones:
            index = phones.index(old_phone)
            phones.insert(index + 1, new_phone)

    elif first_command == "Last":
        phone = command_list[1]
        old_phone = command_list[1]
        if phone in phones:
            phones.remove(old_phone)
            phones.append(old_phone)

    command = input()

print(", ".join(phones))