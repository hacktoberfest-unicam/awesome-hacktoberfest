import random
def Morra():
    print('Ok!, giochiamo!  ')
    macchina=random.randint(0,2)

    if macchina==0:
        macchina='sasso'

    elif macchina==1:
        macchina='forbici'

    else:
        macchina='carta'

    giocatore1=input('scegli "sasso", scegli "carta" oppure scegli "forbici"')

    if giocatore1!='sasso' and giocatore1!='forbici' and giocatore1!='carta':

        print('Non hai scritto niente di comprensibile per me')

    elif giocatore1==macchina:

        print('la partita è pari')

    elif giocatore1=='sasso' and macchina=='forbici' or giocatore1=='forbici' and macchina=='carta' or giocatore1=='carta' and macchina=='sasso':
      print('Hai vinto tu!')

    else:

        print('Ha vinto il tuo avversario!!')
Morra()