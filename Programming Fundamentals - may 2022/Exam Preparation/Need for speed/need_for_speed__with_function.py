def store_car_information(car_dictionary, number):
    for _ in range(number):
        data = input().split('|')
        brand = data[0]
        mileage = int(data[1])
        fuel = int(data[2])

        car_dictionary[brand] = [mileage, fuel]

    return car_dictionary

def special_commands(car_dictionary):

    while True:
        command = input()

        if command == 'Stop':
            break

        command = command.split(' : ')
        current_command = command[0]
        brand = command[1]

        if current_command == 'Drive':
            distance = int(command[2])
            fuel = int(command[3])
            available_fuel = car_dictionary[brand][1]
            current_mileage = car_dictionary[brand][0]
            if available_fuel < fuel:
                print('Not enough fuel to make that ride')
            else:
                car_dictionary[brand][1] -= fuel
                car_dictionary[brand][0] += distance
                print(f"{brand} driven for {distance} kilometers. {fuel} liters of fuel consumed.")

            if current_mileage >= 100000:
                del car_dictionary[brand]
                print(f'Time to sell the {brand}')

        elif current_command == 'Refuel':
            fuel = int(command[2])
            available_fuel = car_dictionary[brand][1]

            if fuel + available_fuel > 75:
                fuel = 75 - available_fuel

            car_dictionary[brand][1] += fuel

            print(f"{brand} refuel with {fuel} liters")

        elif current_command == 'Revert':
            kilometers = int(command[2])
            current_mileage = car_dictionary[brand][0]

            if current_mileage - kilometers < 10000:
                car_dictionary[brand][0] = 10000
            else:
                car_dictionary[brand][0] -= kilometers
                print(f'f{brand} mileage decreased by {kilometers} kilometers')

    return car_dictionary

def additional_print_function(car_dictionary):
    for brand in car_dictionary:
        mileage = car_dictionary[brand][0]
        fuel = car_dictionary[brand][1]
        print(f"{brand} -> Mileage: {mileage}, Fuel in the tank: {fuel} lt.")

def need_for_speed(number):
    car_dictionary = {}

    store_car_information(car_dictionary, number)
    special_commands(car_dictionary)
    additional_print_function(car_dictionary)

n = int(input())
need_for_speed(n)
