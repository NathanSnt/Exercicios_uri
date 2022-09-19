# -*- coding: utf-8 -*-

from math import trunc

i = 0
j = 1
while i <= 2:
    for c in range(3):
        if float(f"{i:.1f}") in (0, 1, 2): print(f"I={round(i)}", end=" ")
        else: print(f"I={i:.1f}", end=" ")
        
        if float(f"{j:.1f}") in (1, 2, 3, 4, 5): print(f"J={round(j)}")
        else: print(f"J={j:.1f}")
        j += 1
    j -= 2.8
    i += 0.2
