# -*- coding: utf-8 -*-

i = 1
j = 7
while i <= 9:
    for j in range(j, j-3, -1):
        print(f"I={i} J={j}")
    j += 4
    i += 2
