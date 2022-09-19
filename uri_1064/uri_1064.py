# -*- coding: utf-8 -*-

positivos = soma = 0

for i in range(6):
    valor = float(input())
    if valor > 0:
        positivos += 1
        soma += valor

print(f"{positivos} valores positivos\n{soma / positivos:.1f}")