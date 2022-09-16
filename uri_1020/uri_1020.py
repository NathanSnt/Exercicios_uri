# -*- coding: utf-8 -*-

dias = int(input())
ano = mes = dia = 0

while True:
    if dias - 365 >= 0:
        dias -= 365
        ano += 1
    elif dias - 30 >= 0:
        dias -= 30
        mes += 1
    else:
        dia = dias
        break

print(f"{ano} ano(s)")
print(f"{mes} mes(es)")
print(f"{dia} dia(s)")