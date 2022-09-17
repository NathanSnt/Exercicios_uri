# -*- coding: utf-8 -*-

dica1 = input()
dica2 = input()
dica3 = input()

if dica1 == "vertebrado":
    if dica2 == "ave":
        if dica3 == "carnivoro":
            print("aguia")
        
        elif dica3 == "onivoro":
            print("pomba")
    
    elif dica2 == "mamifero":
        if dica3 == "onivoro":
            print("homem")
        
        elif dica3 == "herbivoro":
            print("vaca")

elif dica1 == "invertebrado":
    if dica2 == "inseto":
        if dica3 == "hematofago":
            print("pulga")
        
        elif dica3 == "herbivoro":
            print("lagarta")
    
    elif dica2 == "anelideo":
        if dica3 == "hematofago":
            print("sanguessuga")
        
        elif dica3 == "onivoro":
            print("minhoca")