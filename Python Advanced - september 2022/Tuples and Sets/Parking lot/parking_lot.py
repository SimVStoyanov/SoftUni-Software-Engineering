lines = int(input())

car_plates = set()

for i in range(lines):
    direction, plate = input().split(", ")
    if direction == "IN":
        car_plates.add(plate)
    if direction == "OUT":
        car_plates.remove(plate)

if len(car_plates) > 0:
    for plate in car_plates:
        print(plate)
else:
    print("Parking Lot is Empty")
