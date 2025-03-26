balanca = 10000

while True:
    print("\n1. shfaq balancen\n2. terhiq para\n3. depozito para\n4. Dil")
    zgjidhOpsion = input("zgjidh nje opsion: ")
    
    if zgjidhOpsion == "1":
        print(f"Balanca: {balanca} leke")
    elif zgjidhOpsion == "2":
        shuma = int(input("Shuma për tërheqje: "))
        if 0 < shuma <= balanca:
            balanca -= shuma
            print(f"terhoqe {shuma} leke. Balanca: {balanca} leke.")
        else:
            print("Shume e pavlefshme!")
    elif zgjidhOpsion == "3":
        shuma = int(input("Shuma per depozit: "))
        if shuma > 0:
            balanca += shuma
            print(f"Depozitove {shuma} leke. Balanca: {balanca} leke.")
        else:
            print("Shume e pavlefshme!")
    elif zgjidhOpsion == "4":
        print("FLM!")
        break
    else:
        print("Zgjedhje e pavlefshme1!")