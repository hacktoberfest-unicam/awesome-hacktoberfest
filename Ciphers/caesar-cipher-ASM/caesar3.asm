; -----------------------------------------------------------------------------
; A 64-bit program encrypts a string (only uppercase or lower case latin characters)
; using Caesar's cypher. 
; Usage: ./kaiser num string 
; num = an integer
; string = any string e.g. aaaBBBCCC
; -----------------------------------------------------------------------------

global main
extern puts
extern printf
extern atoi

    section .bss
num:  resq 1
str:  resq 1


section .text
main:

        add     rsi, 8                  
        dec     rdi                     ; SKIPPED FIRST ARG


        push    rdi                     ; save registers
        push    rsi

        mov     rdi, [rsi]           ; get number
        call    atoi                 ; convert to integer
        mov     [num], eax           ; save number

        pop     rsi                     ; restore registers
        pop     rdi

        add     rsi, 8                  ; point to next argument
        dec     rdi                     ; count down

        push    rdi                     ; save registers 
        push    rsi

        mov     rdi, [rsi]           ; save the string
        mov     [str], rdi

        pop     rsi                     ; restore registers 
        pop     rdi



        ; START CAESAR

        mov rax, [str] ; GET STRING IN RAX
        mov rbx, 0 ; USE INDEX RBX
        mov rcx, [num] ; GET NUMBER IN RC

        loopstring:
        mov rdx, [rax+rbx] ; GET CURRENT CHAR

        cmp dl, 90  ; IS CURRENT CHAR UPPER CASE?
        jng upper   ; GO TO UPPER CASE MANAGEMENT


        ;;;; LOWER CASE MANAGER ;;;;
        add rdx, rcx ; SUM KEY
        cmp dl, 122  ; GREATER THAN z?
        jng after
        sub rdx, 26   ; THEN SUBTRACT 26
        jmp after

        ;;;; UPPER CASE MANAGER;;;;;
        upper:
        add rdx, rcx ; SUM KEY
        cmp dl, 90 ; GREATER THAN Z?
        jng after 
        sub rdx, 26; THEN SUBTRACT 26
        jmp after ; FOR SIMMETRY

        after:
        mov byte[rax+rbx], dl ; OVERWRITE KEY
        inc rbx ; INCREMENT INDEX
        cmp byte[rax+rbx], 0 ; CHECK STRING END
        jne loopstring ; LOOP IF STRING NOT ENDED
        mov rdi, rax ; PUT TO PRINT
        call puts
        ret