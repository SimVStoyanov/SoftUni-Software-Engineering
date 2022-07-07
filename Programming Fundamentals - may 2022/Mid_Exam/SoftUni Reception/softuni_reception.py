first_employer = int(input())
second_employer = int(input())
third_employer = int(input())
student_count = int(input())

time = first_employer + second_employer + third_employer

hours = 0

while student_count > 0:
    hours += 1
    if hours % 4 == 0:
        continue
    student_count -= time

print(f"Time needed: {hours}h.")
