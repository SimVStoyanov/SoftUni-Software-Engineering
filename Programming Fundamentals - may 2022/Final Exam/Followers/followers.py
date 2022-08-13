data = input()

followers = {}

while data != "Log out":
    data = data.split(': ')
    command = data[0]
    username = data[1]

    if command == 'New follower':
        if username not in followers:
            followers[username] = {"likes": 0, "comment": 0}

    elif command == "Like":
        count = int(data[2])
        if username not in followers:
            followers[username] = {'likes': count, 'comment': 0}
        else:
            followers[username]['likes'] += count

    elif command == 'Comment':
        if username not in followers:
            followers[username] = {'likes': 0, 'comment': 1}
        else:
            followers[username]['comment'] += 1

    elif command == 'Blocked':
        if username in followers:
            followers.pop(username)
        else:
            print(f"{username} doesn't exist.")

    data = input()

for user, values in followers.items():
    followers[user]['total'] = followers[user]['likes'] + followers[user]['comment']

print(f"{len(followers)} followers")

for user, value in followers.items():
    print(f"{user}: {followers[user]['total']}")


