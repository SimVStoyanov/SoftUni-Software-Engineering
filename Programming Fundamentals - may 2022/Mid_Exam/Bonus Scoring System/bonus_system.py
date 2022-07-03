import math
students_count = int(input())
lecture_count = int(input())
additional_bonus = int(input())

student_max_bonus = 0
student_max_bonus_attendance = 0

for i in range(students_count):
    student_attendances = int(input())

    student_total_bonus = student_attendances / lecture_count * (5 + additional_bonus)

    if student_total_bonus > student_max_bonus:
        student_max_bonus = student_total_bonus
        student_max_bonus_attendance = student_attendances

print(f"Max Bonus: {math.ceil(student_max_bonus)}")
print(f"The student has attended {student_max_bonus_attendance} lectures.")