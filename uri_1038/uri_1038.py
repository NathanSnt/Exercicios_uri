# -*- coding: utf-8 -*-

tabela = {
    1:["Cachorro Quente", 4.00],
    2:["X-Salada", 4.50],
    3:["X-Bacon", 5.00],
    4:["Torrada", 2.00],
    5:["Refrigerante", 1.50],
}
cod, qtd = [int(x) for x in input().split()]
print(f"Total: R$ {tabela[cod][1] * qtd:.2f}")