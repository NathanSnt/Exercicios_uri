# -*- coding: utf-8 -*-

n1, n2, n3 = [float(x) for x in input().split()]

if n1 > n2 and n1 > n3:
    a = n1
    if n2 > n3:
        b = n2
        c = n3
    else:
        b = n3
        c = n2
elif n2 > n3:
    a = n2
    if n3 > n1:
        b = n3
        c = n1
    else:
        b = n1
        c = n3
else:
    a = n3
    if n2 > n1:
        b = n2
        c = n1
    else:
        b = n1
        c = n2


if a >= b + c: print("NAO FORMA TRIANGULO")
else:
    if a ** 2 == b ** 2 + c ** 2: print("TRIANGULO RETANGULO")
    elif a ** 2 >  b ** 2 + c ** 2: print("TRIANGULO OBTUSANGULO")
    elif a ** 2 <  b ** 2 + c ** 2: print("TRIANGULO ACUTANGULO")
    if a == b and b == c: print("TRIANGULO EQUILATERO")
    elif a == b or b == c or c == a: print("TRIANGULO ISOSCELES")