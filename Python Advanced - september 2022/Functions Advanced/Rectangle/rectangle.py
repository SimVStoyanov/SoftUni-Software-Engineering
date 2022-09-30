def rectangle(length, width):
    def perimeter():
        return f"Rectangle perimeter: {length * 2 + width * 2}"

    def area():
        return f"Rectangle area: {length * width}"

    if not isinstance(length, int) or not isinstance(width, int):
        return "Enter valid values!"

    return area() + '\n' + perimeter()

