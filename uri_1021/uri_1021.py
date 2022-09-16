# -*- coding: utf-8 -*-

from math import trunc

quantia = float(input())
decimal = quantia - trunc(quantia)
notas = [0, 0, 0, 0, 0, 0]
moedas = [0, 0, 0, 0, 0, 0]

notas[0] = trunc(quantia / 100)
quantia -= notas[0] * 100

notas[1] = trunc(quantia / 50)
quantia -= notas[1] * 50

notas[2] = trunc(quantia / 20)
quantia -= notas[2] * 20

notas[3] = trunc(quantia / 10)
quantia -= notas[3] * 10

notas[4] = trunc(quantia / 5)
quantia -= notas[4] * 5

notas[5] = trunc(quantia / 2)
quantia -= notas[5] * 2

moedas[0] = trunc(quantia)

if decimal >= 0.5:
    decimal -= 0.5
    moedas[1] += 1
if decimal >= 0.25:
    decimal -= 0.25
    moedas[2] += 1
while decimal >= 0.1:
    decimal -= 0.1
    moedas[3] += 1
if decimal >= 0.05:
    decimal -= 0.05
    moedas[4] += 1
while decimal >= 0.009:
    decimal -= 0.01
    moedas[5] += 1

print("NOTAS:")
print(f"{notas[0]} nota(s) de R$ 100.00")
print(f"{notas[1]} nota(s) de R$ 50.00")
print(f"{notas[2]} nota(s) de R$ 20.00")
print(f"{notas[3]} nota(s) de R$ 10.00")
print(f"{notas[4]} nota(s) de R$ 5.00")
print(f"{notas[5]} nota(s) de R$ 2.00")

print("MOEDAS:")
print(f"{moedas[0]} moeda(s) de R$ 1.00")
print(f"{moedas[1]} moeda(s) de R$ 0.50")
print(f"{moedas[2]} moeda(s) de R$ 0.25")
print(f"{moedas[3]} moeda(s) de R$ 0.10")
print(f"{moedas[4]} moeda(s) de R$ 0.05")
print(f"{moedas[5]} moeda(s) de R$ 0.01")