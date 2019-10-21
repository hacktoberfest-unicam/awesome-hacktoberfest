"""
Hacktoberfest 2019
Sasso carta forbice in Python [V3.7]
Rosario Matteo Grammatico
@Gasu16
To Run: python3.7 SCF.py
"""
import random, sys

mosse = ["sasso", "carta", "forbice"]

# Enemy class
class CPU():
    def __init__(self, cpu):
        self.cpu = mosse[cpu]

# Player class
class Player():
    def __init__(self, p_value):
        self.p_value = p_value     
        if(self.p_value not in mosse):
            raise ValueError("Valore NON valido\n")


def duel(Player, CPU):
    """
    flag = 0 --> HAI PERSO
    flag = 1 --> PAREGGIO
    flag = 2 --> HAI VINTO
    """

    flag = 0 # Initialize the flag

    if(CPU.cpu == Player.p_value):
        flag = 1
    else:
        if(CPU.cpu == "sasso"):
            if(Player.p_value == "carta"): flag = 2
            if(Player.p_value == "forbice"): flag = 0
        if(CPU.cpu == "carta"):
            if(Player.p_value == "sasso"): flag = 0
            if(Player.p_value == "forbice"): flag = 2
        if(CPU.cpu == "forbice"):
            if(Player.p_value == "sasso"): flag = 2
            if(Player.p_value == "carta"): flag = 0

    # Check for result
    if(flag == 0):
        print(f"HAI PERSO ------> PLAYER: {Player.p_value} VS CPU: {CPU.cpu}")
    elif(flag == 1):
        print(f"PAREGGIO ------> PLAYER: {Player.p_value} VS CPU: {CPU.cpu}")
    elif(flag == 2):
        print(f"HAI VINTO ------> PLAYER: {Player.p_value} VS CPU: {CPU.cpu}")

    return flag


def menu():
    print("\n\n******** GIOCO SASSO - CARTA - FORBICE ********\n\n")
    print("ISTRUZIONI: \nDigita sasso carta o forbice a tua scelta\nBUONA FORTUNA!\n")

def main():
    menu()
    p_value = input("Scelta [sasso - carta - forbice]: \n")
    cpu = random.randint(0, 2)
    P = Player(p_value) # Initialize the player class
    C = CPU(cpu) # Initialize the enemy class
    duel(P, C) # Let the duel start and check for result
    return

if __name__ == "__main__":
    main()
    sys.exit(0)