data = input()

courses = {}

while not data == "end":
    course_name, student_name = data.split(" : ")

    if course_name not in courses:
        courses[course_name] = []
    courses[course_name].append(student_name)

    data = input()

final_courses = courses.items()
for course_name, students in final_courses:
    print(f"{course_name}: {len(students)}")
    for name in students:
        print(f"-- {name}")
