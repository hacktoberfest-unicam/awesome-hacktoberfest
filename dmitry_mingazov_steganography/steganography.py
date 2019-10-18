from PIL import Image
import getopt
import sys


def encode(filename, output, data):
    i = 0
    with Image.open(filename) as img:
        print("Opened: "+filename)
        print(data)
        width, height = img.size
        pixel = list(img.getpixel((0, 0)))
        print(read_pixel(pixel))
        print(len(data))
        write_pixel(pixel, len(data))
        print(read_pixel(pixel))
        img.putpixel((0, 0), tuple(pixel))
        print(read_pixel(list(img.getpixel((0, 0)))))
        for x in range(0, width):
            for y in range(0, height):
                if(not isPixelWritable(x, y)):
                    continue
                if(i >= len(data)):
                    break 
                pixel = list(img.getpixel((x, y)))
                for n in range(0, 3):
                    if(i < len(data)):
                        pixel[n] = pixel[n] & ~1 | int(data[i])
                        i += 1
                    img.putpixel((x, y), tuple(pixel))

        print("Just before writing file:" + str(read_pixel(list(img.getpixel((0, 0))))))
        img.save(output)
    ima = Image.open(output)
    print(output + ": "+str(read_pixel(list(ima.getpixel((0, 0))))))


def decode(filename):
    extracted_bin = []
    with Image.open(filename) as img:
        print("Opened: "+filename)
        width, height = img.size
        byte = []
        pixel = list(img.getpixel((0, 0)))
        data_len = read_pixel(pixel)
        i = 0

        for x in range(0, width):
            for y in range(0, height):
                if(not isPixelWritable(x, y)):
                    continue
                if(i >= data_len):
                    break
                pixel = list(img.getpixel((x, y)))
                for n in range(0, 3):
                    if(i >= data_len):
                        break
                    i += 1
                    extracted_bin.append(pixel[n]&1)

    
    data = "".join([str(x) for x in extracted_bin])
    gatto = [chr(int(data[j:j+7], base=2)) for j in range(0, len(data), 7)]
    print(''.join(gatto))
    

    print(gatto)

    


def isPixelWritable(x, y):
    if(x % 2 == 1 or y % 2 == 1):
        return True
    else:
        return False

def write_pixel(pixel, number):
    if(number > 255):
        return
    pixel[0] = number

def read_pixel(pixel):
    return pixel[0]

def main():
    if not len(sys.argv[1:]):
        return

    encode_opt = False
    decode_opt = False
    input_file = "test.png"
    output_file = "secret.png"
    message = "test_message"

    try:
        opts, args = getopt.getopt(sys.argv[1:], "i:o:edm:", ["input","output", "encode", "decode", "message"])
    except getopt.GetoptError as err:
        print(str(err))
    for o,a in opts:
        if o in ("-i", "--input"):
            input_file = a
        elif o in ("-o", "--output"):
            output_file = a
        elif o in ("-e", "--encode"):
            encode_opt = True
        elif o in ("-d", "--decode"):
            decode_opt = True
        elif o in ("-m", "--message"):
            message = a
        else:
            assert False, "Unhandled Option"

    if(encode_opt):
        data = ''.join(format(ord(i), 'b') for i in message)
        encode(input_file, output_file, data)
    elif(decode_opt):
        decode(input_file)
    else:
        return

    return
    data = ''.join(format(ord(i), 'b') for i in test_str)
    print(data)

    encode(filename, data)

if __name__ == "__main__":
    main()
