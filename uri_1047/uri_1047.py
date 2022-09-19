# -*- coding: utf-8 -*-

hora_inicial, minuto_inicial, hora_final, minuto_final = [int(x) for x in input().split()]
hora_duracao = minuto_duracao = 0
reverter = False

if hora_inicial == hora_final and minuto_inicial == minuto_final: 
    minuto_inicial += 1
    reverter = True

while True:
    if hora_inicial == hora_final and minuto_inicial == minuto_final: break
    minuto_inicial += 1
    if minuto_inicial == 60:
        minuto_inicial = 0
        hora_inicial += 1
        if hora_inicial == 24:
            hora_inicial = 0
    if minuto_inicial > 60:
        minuto_inicial = 0
        minuto_duracao -= 1
        hora_inicial += 1
        if hora_inicial == 24:
            hora_inicial = 0
    minuto_duracao += 1
    if minuto_duracao == 60:
        minuto_duracao = 0
        hora_duracao += 1
    
if reverter: 
    minuto_duracao += 1
    if minuto_duracao == 60:
        minuto_duracao = 0
        hora_duracao += 1

print(f"O JOGO DUROU {hora_duracao} HORA(S) E {minuto_duracao} MINUTO(S)")