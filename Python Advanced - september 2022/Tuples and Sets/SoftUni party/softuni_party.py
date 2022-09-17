lines = int(input())

guest_list = set()
arrived_guests = set()

for i in range(lines):
    guest_list.add(input())

arrival = input()
while arrival != "END":
    arrived_guests.add(arrival)
    arrival = input()

missing_guest = guest_list - arrived_guests

print(len(missing_guest))

for guest in sorted(missing_guest):
    print(guest)
