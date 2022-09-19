# -*- coding: utf-8 -*-

from cmath import sqrt

a, b, c = [float(x) for x in input().split()]

if a == 0 or b == 0 or c == 0 or b < c:
    print("Impossivel calcular")
else:
    delta = (b ** 2) - (4 * a * c)
    raiz = sqrt(delta)
    raizA = ((-(b)) + raiz) / (2 * a)
    raizB = ((-(b)) - raiz) / (2 * a)

    raizA = float(str(raizA).split("+")[0].replace("(", ""))
    raizB = float(str(raizB).split("+")[0].replace("(", ""))

    print(f"R1 = {raizA:.5f}")
    print(f"R2 = {raizB:.5f}")