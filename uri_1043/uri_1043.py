# -*- coding: utf-8 -*-

a, b, c = [float(x) for x in input().split()]

if a + b > c and b + c > a and c + a > b:
    print(f"Perimetro = {(a + b + c):.1f}")
else:
    print(f"Area = {(((a + b) / 2) * c):.1f}")