def multiply(n):
    def decorator(func_ref):
        def wrapper(*args):
            result = func_ref(*args)
            return result * n

        return wrapper

    return decorator

