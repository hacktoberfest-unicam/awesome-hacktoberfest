"""
Hacktoberfest 2019
Cifrario di Cesare in Python [V3.7]
Rosario Matteo Grammatico
@Gasu16
To Run: python3.7 caesarCipher.py
"""

import sys
import random


def get_input():
    message = input("Inserisci messaggio da cifrare: ")
    return message

def generate_key():
    key = random.randint(1, 26)
    return key

def encipher(text, key):
    s = "" # String where we will save the cipher text
    text_len = len(text)
    
    for i in range(0, text_len):
        c = ord(text[i]) # get ascii code of each character of input text
        fnz = c + (key % 26)

        # check if the character is lowercase or UPPERCASE
        if(c >= 97 and c <= 122): # if it is lowercase...
            if(fnz > 122):
                fnz = fnz - 26

        elif(c >= 65 and c <= 90): # if it is UPPERCASE...
            if(fnz > 90):
                fnz = fnz - 26
        cipher_text = chr(fnz)
        s += cipher_text
    return s

def decipher(text, key):
    s = "" # String where we will save the plain text
    text_len = len(text)
    for i in range(0, text_len):
        c = ord(text[i]) # get ascii code of each character of cipher text
        fnz = c - (key % 26)

        # check if the character is lowercase or UPPERCASE
        if(c >= 97 and c <= 122): # if it is lowercase...
            if(fnz < 97):
                fnz = fnz + 26

        elif(c >= 65 and c <= 90): # if it is UPPERCASE...
            if(fnz < 65):
                fnz = fnz + 26
        plain_text = chr(fnz)
        s += plain_text
    return s

def main():
    input_message = get_input()
    print(input_message)
    cipher_key = generate_key()
    print(f"Generated key: {cipher_key}")
    enc = encipher(input_message, cipher_key)
    dec = decipher(enc, cipher_key)
    print(f"Cipher text [encipher]: {enc}")
    print(f"Plain text [decipher]: {dec}")
    return

if __name__ == "__main__":
    main()
    sys.exit(0)
