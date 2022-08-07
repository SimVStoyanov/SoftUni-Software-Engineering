count = int(input())

grades = {}

for _ in range(count):
    name = input()
    grade = float(input())

    if name not in grades:
        grades[name] = []
    grades[name].append(grade)

filtered_grades = {}

for name, grades in grades.items():
    avg_grade = sum(grades) / len(grades)
    if avg_grade >= 4.50:
        filtered_grades[name] = avg_grade

sorted_grades = filtered_grades.items()
for name, grades in sorted_grades:
    print(f"{name} -> {grades:.2f}")
