# -*- coding: utf-8 -*-

dentro = fora = 0
for c in range(int(input())):
    x = int(input())
    if 10 <= x <= 20:
        dentro += 1
    else:
        fora += 1

print(f"{dentro} in")
print(f"{fora} out")