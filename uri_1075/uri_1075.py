# -*- coding: utf-8 -*-

n = int(input())

for c in range(1, 10000):
    if c % n == 2:
        print(c)