def valid_username(_username: str):
    if len(_username) in range(3, 17):
        _username = _username.replace('-', '').replace('_', '')
        if _username.isalnum() and _username == _username.replace(' ', ''):
            return True
    return False


usernames = input().split(', ')
for username in usernames:
    if valid_username(username):
        print(username)