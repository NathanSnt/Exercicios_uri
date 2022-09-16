# -*- coding: utf-8 -*-

from cmath import sqrt

x = [float(x) for x in input().split()]
y = [float(x) for x in input().split()]
resultado = float(str(sqrt(((x[0] - y[0]) ** 2) + ((x[1] - y[1]) ** 2))).split("+")[0].replace("(", ""))
print(f"{resultado:.4f}")