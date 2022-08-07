user_points = {}
language_submissions = {}

data = input()

while not data == "exam finished":
    split_data = data.split("-")

    if split_data[1] == "banned":
        user = split_data[0]
        del user_points[user]
    else:
        user, language, points = split_data
        points = int(points)
        if user in user_points:
            if user_points[user] < points:
                user_points[user] = points
        else:
            user_points[user] = points

        if language not in language_submissions:
            language_submissions[language] = 0
        language_submissions[language] += 1

    data = input()

final_user_points = user_points.items()
print("Results:")
for user, points in final_user_points:
    print(f"{user} | {points}")

final_language_submissions = language_submissions.items()
print("Submissions:")
for lang, submissions in final_language_submissions:
    print(f"{lang} - {submissions}")