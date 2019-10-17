

import random

cpu = ['Sasso', 'Carta', 'Forbici','Lizard','Spok']
r = random.choice(cpu)

player = input('Inserisci cosa vuoi buttare (minuscolo): ')

print ('Tu giochi: ', player)
print ('CPU gioca: ', r)

if player == r.lower():
    print ('Pareggio')
elif ((player == 'sasso' and r == 'Carta') or
      (player == 'carta' and r == 'Forbici') or
      (player == 'lizard' and r == 'Sasso') or
    (player == 'spok' and r == 'Lizard') or
(player == 'forbici' and r == 'Spok') or
(player == 'lizard' and r == 'Forbici') or
(player == 'carta' and r == 'Lizard') or
(player == 'spok' and r == 'Carta') or
(player == 'sasso' and r == 'Spok') or

      (player == 'forbici' and r == 'Sasso')):

    print ('Hai perso...')
else:
    print ('Hai vinto!')