def grocery_store(**kwargs):
    result = ''
    sorted_groceries = sorted(kwargs.items(), key=lambda x: (-x[1], -len(x[0]), x[0]))

    for key, val in sorted_groceries:
        result += f"{key}: {val}" + '\n'

    return result


print(grocery_store(
    bread=2,
    pasta=2,
    eggs=20,
    carrot=1,
))





