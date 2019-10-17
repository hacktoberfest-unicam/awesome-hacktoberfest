.section .data
StringToPrint:
.string "Hello, World!"

.section .text
.globl _start
_start:
movl $4, %eax
movl $1, %ebx
movl $StringToPrint, %ecx
movl $13, %edx
int $0x80

#sys_exit (return_code)  
movl    $1, %eax             #System call number 1: exit()
movl    $0, %ebx             #Exits with exit status 0
int     $0x80                #Passes control to interrupt vector 
