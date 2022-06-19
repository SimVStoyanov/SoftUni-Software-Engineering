# The numbers 2, 8, 4, and 10 fall into the group of 10's.
# The numbers 13, 19, 14, and 15 fall into the group of 20's.

nums = [int(x) for x in input().split(",")]

# how many groups
max_group = max(nums) // 10
if max(nums) % 10 >= 1:
    max_group += 1

groups = [[] for i in range(max_group)]

for n in nums:
    cur_group = n // 10
    if cur_group == 0:
        groups[0].append(n)
        continue
    if n - cur_group * 10 > 0:
        cur_group += 1
    groups[cur_group - 1].append(n)

for i in range(1, max_group + 1):
    print(f"Group of {i}0's: {groups[i - 1]}")
