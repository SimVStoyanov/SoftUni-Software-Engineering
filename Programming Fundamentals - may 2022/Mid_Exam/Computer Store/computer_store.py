command = input()

price = 0

while command != "special" and command != "regular":
    part_price = float(command)

    if part_price < 0:
        print(f"Invalid price!")
    else:
        price += part_price

    command = input()

if price <= 0:
    print("Invalid order!")

else:
    taxes = price * 0.20
    final_price = price + taxes
    print("Congratulations you've just bought a new computer!")
    print(f"Price without taxes: {price:.2f}$")
    print(f"Taxes: {taxes:.2f}$")
    print("-----------")

    if command == "special":
       final_price = final_price * 0.90
    print(f"Total price: {final_price:.2f}$")


