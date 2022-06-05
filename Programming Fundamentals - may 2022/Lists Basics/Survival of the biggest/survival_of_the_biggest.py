line = input()
count = int(input())

nums = list(map(int, line.split()))

for i in range(count):
    cur_min = min(nums)
    nums.remove(cur_min)
else:
    print(*nums, sep=", ")