# -*- coding: utf-8 -*-

peca1 = [float(x) for x in input().split()]
peca2 = [float(x) for x in input().split()]
print(f"VALOR A PAGAR: R$ {peca1[1] * peca1[2] + peca2[1] * peca2[2]:.2f}")