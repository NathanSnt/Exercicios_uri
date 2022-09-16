# -*- coding: utf-8 -*-

tempo = int(input())
hora = minuto = segundo = 0

while True:
    if tempo - 3600 >= 0:
        tempo -= 3600
        hora += 1
    elif tempo - 60 >= 0:
        tempo -= 60
        minuto += 1
    else:
        segundo = tempo
        break

print(f"{hora}:{minuto}:{segundo}")