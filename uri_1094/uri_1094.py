# -*- coding: utf-8 -*-

cobaias = coelhos = ratos = sapos = 0

for c in range(int(input())):
    qtd, tipo = [x for x in input().split()]
    qtd = int(qtd)

    if tipo == "C":
        cobaias += qtd
        coelhos += qtd
    elif tipo == "R":
        cobaias += qtd
        ratos += qtd
    elif tipo == "S":
        cobaias += qtd
        sapos += qtd
    
print(f"Total: {cobaias} cobaias")
print(f"Total de coelhos: {coelhos}")
print(f"Total de ratos: {ratos}")
print(f"Total de sapos: {sapos}")
print(f"Percentual de coelhos: {coelhos/cobaias*100:.2f} %")
print(f"Percentual de ratos: {ratos/cobaias*100:.2f} %")
print(f"Percentual de sapos: {sapos/cobaias*100:.2f} %")