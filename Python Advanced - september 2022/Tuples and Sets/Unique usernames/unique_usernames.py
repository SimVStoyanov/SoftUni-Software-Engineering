lines = int(input())

usernames = set()

for _ in range(lines):
    usernames.add(input())

for username in usernames:
    print(username)
