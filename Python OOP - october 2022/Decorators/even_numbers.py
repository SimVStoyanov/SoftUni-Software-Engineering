def even_numbers(func_ref):
    def wrapper(*args):
        result = func_ref(*args)
        return [x for x in result if x % 2 == 0]

    return wrapper
