# -*- coding: utf-8 -*-

lista = [int(x) for x in input().split()]
ordenada = list()

maior = menor = meio = lista[0]

if lista[0] >= lista[1] and lista[0] >= lista[2]:
    maior = lista[0]
    if lista[1] >= lista[2]:
        meio = lista[1]
        menor = lista[2]
    else:
        meio = lista[2]
        menor = lista[1]
elif lista[1] >= lista[2]:
    maior = lista[1]
    if lista[2] >= lista[0]:
        meio = lista[2]
        menor = lista[0]
    else:
        meio = lista[0]
        menor = lista[2]
else:
    maior = lista[2]
    if lista[1] >= lista[0]:
        meio = lista[1]
        menor = lista[0]
    else:
        meio = lista[0]
        menor = lista[1]

for x in (menor, meio, maior):
    print(x)

print()

for x in lista:
    print(x)