import math
budget = float(input())
students = int(input())
price_of_pack_flour = float(input())
price_of_one_egg = float(input())
price_of_one_apron = float(input())

need_packs_of_flour = 0
need_eggs = 0
need_apron = 0


for student in range(1, students +1):
    need_packs_of_flour += 1
    if student % 5 == 0:
        need_packs_of_flour -= 1
    need_eggs += 10
    need_apron += 1


price_for_flour = need_packs_of_flour * price_of_pack_flour
price_for_eggs = need_eggs * price_of_one_egg
price_for_apron = math.ceil(need_apron * 1.2) * price_of_one_apron

final_price = price_for_flour + price_for_eggs + price_for_apron
need_mooney = (final_price - budget)

if budget >= final_price:
    print(f"Items purchased for {final_price:.2f}$.")
else:
    print(f"{need_mooney:.2f}$ more needed.")
