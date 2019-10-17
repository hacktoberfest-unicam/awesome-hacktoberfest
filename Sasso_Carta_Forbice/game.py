import random

def getUserChoice():
	userChoice = str(input("sasso carta o forbici? (s, c, f)"))
	if userChoice == 's' :
		print("hai scelto:	sasso")
		return 1
	elif userChoice == 'c':
		print("hai scelto:	carta")
		return 2
	elif userChoice == 'f':
		print("hai scelto:	forbici")
		return 3
	else: 
		print ("solo s, c, f")		
		exit()

def getComChoice():
	comChoice = random.randint(1,3)
	if comChoice == 1 :
		c = "sasso"
	elif comChoice == 2:
		c = "carta"
	elif comChoice == 3:
		c = "forbici"
	print("COM ha scelto:	", c)
	return comChoice

def detWinner(userChoice, comChoice):
	t = (comChoice%3)+1
	if t==userChoice :
		return 'hai vinto!'
	elif comChoice == userChoice :
		return 'pareggio!'
	else:
		return 'hai perso!'

print(detWinner(getUserChoice(), getComChoice()))
