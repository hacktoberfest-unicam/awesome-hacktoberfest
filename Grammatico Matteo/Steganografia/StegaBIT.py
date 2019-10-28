"""
Hacktoberfest 2019
Steganografia in Python [V3.7]
Rosario Matteo Grammatico
@Gasu16
To Run: python3.7 StegaBIT.py
"""

import PIL
from PIL import Image
import sys
from os import path

# Class for handling the image
class ImageHandler():
    def __init__(self, message, path_to_image):
        # Initialize the message that we want to hide and the image where we want to hide it
        self.message = message
        self.path_to_image = path_to_image
        self.img = Image.open(path_to_image)
        self.msg_len = len(message)

    def get_size_info(self, message, path_to_image):
        # Getting the info about the size
        self.width, self.height = self.img.size
        print(f"\nwidht: {self.width}\nheight: {self.height}")
        #print(f"{self.img.size[0], self.img.size[1]}")
        self.img_size_pixels = self.width * self.height
        self.img_size_bits = path.getsize(path_to_image)*8
        print(f"La dimensione di {path_to_image} e' {self.img_size_bits} bits")
        self.colors = self.img.getcolors()
        print(f"Mode: {self.img.mode}")
        print(f"Message length: {self.msg_len}")
        print(f"Colori: {self.colors}")

    def check_mode(self):
        if(self.img.mode != "RGBA"):            
            raise ValueError(self.img.mode, "Inserire un immagine di tipo RGBA!")
            

    def check_sizes(self, message, path_to_image):
        # Each pixel has 4 RGBA values and each of this value has 8 bits
        if(self.img_size_pixels*24 <= self.img_size_bits*2):
            print("Immagine troppo grande")
            sys.exit(1)
        else:
            print("La dimensione e' OK\n")
    
    def message_to_bin(self, message):
        new_message = ""
        for i in range(0, self.msg_len):
            ascii_mex = ord(message[i])
            binary_mex = bin(ascii_mex)
            new_message += binary_mex
        return new_message[2:]

    def printMessage(self, message):
        return ''.join(map(str, message))

    def encode_message(self, message, path_to_image):
        index = 0
        for i in range(self.height):
            for j in range(self.width):                
                r, g, b, alpha = self.img.getpixel((j, i))
                
                if(i == 0 and j == 0 and index < self.msg_len):
                    data = self.msg_len
                elif(index <= self.msg_len):
                    c = message[index-1]
                    data = ord(c)
                else:
                    data = r
                
                self.img.putpixel((j, i),(data, g, b))
                index += 1
        self.img.save("output.png")
        return self.img

    def decode_message(self, path_to_image):
        index = 0
        mex = ""
        self.file_output = Image.open(path_to_image)
        for i in range(self.height):
            for j in range(self.width):
                r, g, b, alpha = self.file_output.getpixel((j, i))
                
                if(index <= self.msg_len):
                    mex += chr(r)
                index += 1
        print(f"Messaggio decodificato: {mex}")
        return mex


def main():
    message = "message"
    file_input = "food.png"
    file_output = "output.png"
    H = ImageHandler(message, file_input)
    H.get_size_info(message, file_input)
    H.check_mode()
    H.check_sizes(message, file_input)
    binary_mex = H.message_to_bin(message)
    binary_mex = (binary_mex.split('b'))
    binary_mex = H.printMessage(binary_mex)
    print(f"Il messaggio: {message} \nIn binario: {binary_mex}")
    H.encode_message(message, file_input)
    H.decode_message(file_output)
    return

if __name__ == "__main__":
    main()
    sys.exit(0)
