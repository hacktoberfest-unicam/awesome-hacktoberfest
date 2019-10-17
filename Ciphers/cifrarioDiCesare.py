
text ="ABCD"
key = 3
def encode(messaggio_in_chiaro, chiave):
    return ''.join([chr(ord(lettera) + chiave) for lettera in messaggio_in_chiaro])

print(encode(text,key))