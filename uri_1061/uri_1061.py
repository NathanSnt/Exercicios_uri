# -*- coding: utf-8 -*-

dia_inicio = int(input().split()[1])
hora_inicio, minuto_inicio, segundo_inicio = [int(x) for x in input().split(" : ")]
dia_fim = int(input().split()[1])
hora_fim, minuto_fim, segundo_fim = [int(x) for x in input().split(" : ")]

dia_duracao = hora_duracao = minuto_duracao = segundo_duracao = 0

while True:
    if dia_inicio == dia_fim and hora_inicio == hora_fim and minuto_inicio == minuto_fim and segundo_inicio == segundo_fim: break

    segundo_inicio += 1
    if segundo_inicio == 60:
        segundo_inicio = 0
        minuto_inicio += 1
        if minuto_inicio == 60:
            minuto_inicio = 0
            hora_inicio += 1
            if hora_inicio == 24:
                hora_inicio = 0
                dia_inicio += 1

    segundo_duracao += 1
    if segundo_duracao == 60:
        segundo_duracao = 0
        minuto_duracao += 1
        if minuto_duracao == 60:
            minuto_duracao = 0
            hora_duracao += 1
            if hora_duracao == 24:
                hora_duracao = 0
                dia_duracao += 1

print(f"{dia_duracao} dia(s)")
print(f"{hora_duracao} hora(s)")
print(f"{minuto_duracao} minuto(s)")
print(f"{segundo_duracao} segundo(s)")