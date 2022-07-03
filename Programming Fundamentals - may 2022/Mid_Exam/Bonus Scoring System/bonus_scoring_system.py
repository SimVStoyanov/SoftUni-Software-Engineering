
number_of_students = int(input())
numer_of_lecture = int(input())
additional_bonus = int(input())

max_bonus = 0
max_attendance = 0
for attended in range(number_of_students):
    attendance_of_each_student = int(input())
    total_bonus = attendance_of_each_student / numer_of_lecture * (5 + additional_bonus)
    if total_bonus > max_bonus:
        max_bonus = total_bonus
        max_attendance = attendance_of_each_student

print(f"Max Bonus: {round(max_bonus)}.")
print(f"The student has attended {max_attendance} lectures.")
