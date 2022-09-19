# -*- coding: utf-8 -*-

salario = float(input())

if salario > 400.00:
    if salario > 800:
        if salario > 1200:
            if salario > 2000:
                if salario > 2000:
                    reajuste = salario * (4 / 100)
                    porcento = 4
            else:
                reajuste = salario * (7 / 100)
                porcento = 7
        else:
            reajuste = salario * (10 / 100)
            porcento = 10
    else:
        reajuste = salario * (12 / 100)
        porcento = 12
else:
    reajuste = salario * (15 / 100)
    porcento = 15
salario += reajuste

print(f"Novo salario: {salario:.2f}")
print(f"Reajuste ganho: {reajuste:.2f}")
print(f"Em percentual: {porcento} %")