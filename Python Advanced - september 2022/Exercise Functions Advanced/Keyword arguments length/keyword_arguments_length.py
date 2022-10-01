def kwargs_length(**d):
    return len(d.keys())


dictionary = {'name': 'Peter', 'age': 25}

print(kwargs_length(**dictionary))
