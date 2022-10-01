def get_name(names: tuple, letter: str):
    for name in names:
        if name.startswith(letter):
            return name


def age_assignment(*names, **kwargs):
    people = {}
    result = ''

    for key, val in kwargs.items():
        name = get_name(names, key)
        people[name] = val

    sorted_people = dict(sorted(people.items(), key=lambda x: x[0]))

    for name, age in sorted_people.items():
        result += f"{name} is {age} years old." + '\n'

    return result


print(age_assignment("Peter", "George", G=26, P=19))
print(age_assignment("Amy", "Bill", "Willy", W=36, A=22, B=61))