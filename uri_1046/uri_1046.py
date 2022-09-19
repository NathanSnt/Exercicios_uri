# -*- coding: utf-8 -*-

inicio, final = [int(x) for x in input().split()]
duracao = 0
reverter = False

if inicio == final: 
    inicio += 1
    reverter = True
while True:
    if inicio == final: break
    inicio += 1
    if inicio == 24:
        inicio = 0
    elif inicio > 24:
        inicio = 0
        duracao -= 1
    duracao += 1
if reverter: duracao += 1

print(f"O JOGO DUROU {duracao} HORA(S)")