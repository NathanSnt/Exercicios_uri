# -*- coding: utf-8 -*-

a, b, c = [int(x) for x in input().split()]

maiorAB = (a + b + abs(a - b)) / 2
maior = int((c + maiorAB + abs(c - maiorAB)) / 2)
print(f"{maior} eh o maior")