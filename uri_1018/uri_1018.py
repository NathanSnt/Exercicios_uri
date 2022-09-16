# -*- coding: utf-8 -*-

notas = [0, 0, 0, 0, 0, 0, 0]

valor_lido = valor = int(input())

while valor > 0:
    if valor - 100 >= 0: 
        valor -= 100
        notas[0] += 1
    elif valor - 50 >= 0:
        valor -= 50
        notas[1] += 1
    elif valor - 20 >= 0:
        valor -= 20
        notas[2] += 1
    elif valor - 10 >= 0:
        valor -= 10
        notas[3]
    elif valor - 5 >= 0:
        valor -= 5
        notas[4] += 1
    elif valor - 2 >= 0:
        valor -= 2
        notas[5] += 1
    else:
        valor -= 1
        notas[6] += 1

print(valor_lido)
print(f"{notas[0]} nota(s) de R$ 100,00")
print(f"{notas[1]} nota(s) de R$ 50,00")
print(f"{notas[2]} nota(s) de R$ 20,00")
print(f"{notas[3]} nota(s) de R$ 10,00")
print(f"{notas[4]} nota(s) de R$ 5,00")
print(f"{notas[5]} nota(s) de R$ 2,00")
print(f"{notas[6]} nota(s) de R$ 1,00")