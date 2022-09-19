# -*- coding: utf-8 -*-

lista = []
maior = 0

for c in range(10):
    x = int(input())
    lista.append(x)
    if x > maior: 
        maior = x
        posicao = c + 1

print(maior)
print(posicao)