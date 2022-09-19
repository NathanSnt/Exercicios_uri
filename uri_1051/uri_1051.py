# -*- coding: utf-8 -*-

salario = float(input())
imposto = 0

if salario > 4500:
    imposto += (salario - 4500) * (28 / 100)
    salario -= (salario - 4500)
if salario > 3000:
    imposto += (salario - 3000) * (18 / 100)
    salario -= (salario - 3000)
if salario > 2000:
    imposto += (salario - 2000) * (8 / 100)
    salario -= (salario - 2000)
    
print("Isento" if imposto == 0 else f"R$ {imposto:.2f}")