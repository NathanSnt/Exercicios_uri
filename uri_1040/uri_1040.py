# -*- coding: utf-8 -*-

n1, n2, n3, n4 = [float(x) for x in input().split()]
p1, p2, p3, p4 = 2, 3, 4, 1

media = ((n1 * p1) + (n2 * p2) + (n3 * p3) + (n4 * p4)) / (p1 + p2 + p3 + p4)

print(f"Media: {media:.1f}")
if media >= 7.0:
    print("Aluno aprovado.")
elif media >= 5.0:
    print("Aluno em exame.")
    n5 = float(input())
    print(f"Nota do exame: {n5}")

    media = (media + n5) / 2
    if media >= 5.0:
        print("Aluno aprovado.")
    else:
        print("Aluno reprovado.")
    print(f"Media final: {media:.1f}")
else:
    print("Aluno reprovado.")