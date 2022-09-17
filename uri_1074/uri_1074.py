# -*- coding: utf-8 -*-

for c in range(int(input())):
    x = int(input())
    print("NULL" if x == 0 else (("EVEN " if x % 2 == 0 else "ODD ")+("POSITIVE" if x > 0 else "NEGATIVE")))
    """if x == 0:
        print("NULL")
    else:
        print(("ODD " if x %2 != 0 else "EVEN ")+("POSITIVE" if x > 0 else "NEGATIVE"))"""