a = input().split("#")
water = int(input())
b = " "
effort = 0
el = " "
total_fire = 0
el1 = 0
firestop = []
for i in range(len(a)):
    if water <= 0:
        break
    if "High" or "Low" or "Medium" in a[i]:
        el = a[i]
        if "High" in el:
            b = el.split()
            el1 = int(b[2])
            if el1 >= 81 and el1 <= 125 and water >= el1:
                effort += el1 * 0.25
                water -= el1
                total_fire += el1
                firestop.append(el1)
        if "Medium" in el:
            b = el.split()
            el1 = int(b[2])
            if el1 >= 51 and el1 <= 80 and water >= el1:
                effort += el1 * 0.25
                water -= el1
                total_fire += el1
                firestop.append(el1)
        if "Low" in el:
            b = el.split()
            el1 = int(b[2])
            if el1 >= 1 and el1 <= 50 and water >= el1:
                effort += el1 * 0.25
                water -= el1
                total_fire += el1
                firestop.append(el1)

print(f"Cells:")
for i in range(len(firestop)):
    print(f" - {(firestop[i])}")
print(f"Effort: {effort:.2f}")
print(f"Total Fire: {int(total_fire)}")