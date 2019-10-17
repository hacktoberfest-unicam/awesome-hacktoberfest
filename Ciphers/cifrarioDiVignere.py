from string import ascii_lowercase


LETTERS = {letter: str(index) for index, letter in enumerate(ascii_lowercase, start=1)}


def alphabet_position(text):
    text = text.lower()

    numbers = [LETTERS[character] for character in text if character in LETTERS]

    return ' '.join(numbers)

def cifrario(one,two):


    n = int(one) + int(two)

    r = n / 26
    if r >= 1 and r < 2:
        r = 1
    elif r <= 0.9 and r > 0:
        r = 0

    fx = n - (26 * r)
    return fx

    #mettere che fx ritorna uguale un numero

def letterToNumber(fx):
   a = fx +96
   print(chr(a).upper())




z=input("Insert first letter: ")
v= input("Insert second letter: ")

c = cifrario(alphabet_position(z),alphabet_position(v))
letterToNumber(c)












