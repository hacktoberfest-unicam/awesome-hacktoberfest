/*******************************************************************************
 * File:        sha224.c                                                       *
 *                                                                             *
 *                                                                             *
 * To change this license header, choose License Headers in Project Properties.*
 * To change this template file, choose Tools | Templates                      *
 * and open the template in the editor.                                        *
 *                                                                             *
 *                                                                             *
 * Author: Rosario Matteo Grammatico [@Gasu16]                                 *
 *                                                                             *
 *                                                                             *
 ******************************************************************************/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>
#include <malloc.h>
#include <math.h>
#include <limits.h>

#include "sha224.h"
#define R_LEFT(x,n) ((x<<n) | (x>>(32-n)))
#define R_RIGHT(x,n) ((x>>n) | (x<<(32-n)))
#define RIGHT_SHIFT(x, n) (x>>n)
#define LEFT_SHIFT(x, n) (x<<n)

// TABLE OF CONSTANTS K
static const unsigned int k[64] = {
    0x428a2f98, 0x71374491, 0xb5c0fbcf, 0xe9b5dba5, 0x3956c25b, 0x59f111f1, 0x923f82a4, 0xab1c5ed5,
    0xd807aa98, 0x12835b01, 0x243185be, 0x550c7dc3, 0x72be5d74, 0x80deb1fe, 0x9bdc06a7, 0xc19bf174,
    0xe49b69c1, 0xefbe4786, 0x0fc19dc6, 0x240ca1cc, 0x2de92c6f, 0x4a7484aa, 0x5cb0a9dc, 0x76f988da,
    0x983e5152, 0xa831c66d, 0xb00327c8, 0xbf597fc7, 0xc6e00bf3, 0xd5a79147, 0x06ca6351, 0x14292967,
    0x27b70a85, 0x2e1b2138, 0x4d2c6dfc, 0x53380d13, 0x650a7354, 0x766a0abb, 0x81c2c92e, 0x92722c85,
    0xa2bfe8a1, 0xa81a664b, 0xc24b8b70, 0xc76c51a3, 0xd192e819, 0xd6990624, 0xf40e3585, 0x106aa070,
    0x19a4c116, 0x1e376c08, 0x2748774c, 0x34b0bcb5, 0x391c0cb3, 0x4ed8aa4a, 0x5b9cca4f, 0x682e6ff3,
    0x748f82ee, 0x78a5636f, 0x84c87814, 0x8cc70208, 0x90befffa, 0xa4506ceb, 0xbef9a3f7, 0xc67178f2
};

/*** VARIABLES DEFINITION ***/
void sha224_set(SHA224 *sha224) {
    sha224->original_len = 0;
    sha224->current_len = 0;
    sha224->num_chunks = 0;

    sha224->h[0] = 0xc1059ed8ul;
    sha224->h[1] = 0x367cd507ul;
    sha224->h[2] = 0x3070dd17ul;
    sha224->h[3] = 0xf70e5939ul;
    sha224->h[4] = 0xffc00b31ul;
    sha224->h[5] = 0x68581511ul;
    sha224->h[6] = 0x64f98fa7ul;
    sha224->h[7] = 0xbefa4fa4ul;

}

/*
 * Function used to read the input file
 */
unsigned char * SHA224_read_file(char *path){
    FILE *fp;
    char testo[CHAR_MAX];
    unsigned char * msg = (char *)malloc(strlen(testo)+1);
    fp = fopen(path, "r");
    /* Cambia il path di fopen a seconda del file che vuoi leggere */
    if(fp == NULL){
        printf("File non trovato");
    }
    while(fscanf(fp, "%s", testo) != EOF){
        /* Quello che andiamo a leggere da file lo metto in "testo" 
         fin quando arrivo a EOF (end of file) */
        //printf(" %s", testo);
    }
    strcpy(msg, testo);
    fclose(fp);
    free(fp);
    fp = NULL;
    return msg;
}

/*
 * Function used to pad the message to respect the standards of SHA-1 algorithm
 */

SHA224 *sha224_pad(SHA224 *sha224, unsigned char * mex) {
    /*          ******** PADDING [APPENDING 448 BITS '0'] ********
     * Basically we are gonna append 8 bytes (64 bits) more to the message
     * by using a for loop until the index reaches 6 and then the last 2 bytes
     * appended using a formula; the 64 bits appended are the length of the message
     * rapresented in 64 bits format
     */
    int bit_padding = sha224->current_len % 64; // 64 bytes = 512 bits

    if (bit_padding < 56) { // 56 bytes = 448 bits
        bit_padding = 56 - bit_padding;
    } else {
        bit_padding = 120 - bit_padding; // 120 bytes = 960 bits
    }
    int i = 0;
    while (i < bit_padding) {
        mex[sha224->current_len] = 0x00;
        sha224->current_len++;
        i++;
    }
    
    mex[sha224->current_len + 1] = '\0';
    int j;
    
    /*** APPEND THE LENGTH OF MESSAGE IN 64-BITS FORMAT AT THE END OF THE MESSAGE  ***/
    for (j = 0; j < 6; j++) {
        //mex[sha1->current_len] = (mex[sha1->current_len] << 1) | 0;
        mex[sha224->current_len] = 0x00; 
        sha224->current_len++;
    }
    
    
    mex[sha224->current_len] = (sha224->original_len * 8) / 0x100;
    sha224->current_len++;
    mex[sha224->current_len] = (sha224->original_len * 8) % 0x100;
    sha224->current_len++;
    mex[sha224->current_len + j] = '\0';
    sha224->num_chunks = sha224->current_len / 64;
    return sha224;
}

/*
 * Function used for processing the message and calculate the digest
 * This is where the most important part happens, the real process of digest elaboration
 */

unsigned int sha224_exe(SHA224 *sha224, unsigned char * message) {
    unsigned char *mex = (unsigned char *) malloc(strlen((const char *) message) + 100);
    strcpy((unsigned char *) mex, (const char *) message);
    sha224->current_len = strlen((const char *) mex);
    sha224->original_len = sha224->current_len;
    
    // Append the bit '1' to the message

    mex[sha224->current_len] = 0x80;
    
    mex[sha224->current_len + 1] = '\0'; // NULL terminator
    sha224->current_len++;

    sha224_pad(sha224, mex);
    
    /*** MAIN OPERATION OF THE SHA-1 ALGORITHM (search for the pseudo-code) ***/
    int index;
    int j;
    
    for(j = 0; j < sha224->num_chunks; j++){
        
        for(index = 0; index < 16; index++){
            //  break chunk into sixteen 32-bit big-endian words w[index]
            sha224->w[index] = mex[j * 64 + index * 4 + 0] * 0x1000000 + mex[j * 64 + index * 4 + 1] * 0x10000 + mex[j * 64 + index * 4 + 2] * 0x100 + mex[j * 64 + index * 4 + 3];
        }
        
        for(index = 16; index < 64; index++){
            /*
             s0 := (w[i-15] rightrotate 7) xor (w[i-15] rightrotate 18) xor (w[i-15] rightshift 3)
            s1 := (w[i-2] rightrotate 17) xor (w[i-2] rightrotate 19) xor (w[i-2] rightshift 10)
            w[i] := w[i-16] + s0 + w[i-7] + s1
             */
            sha224->s0 = ((R_RIGHT(sha224->w[index - 15], 7)) ^ (R_RIGHT(sha224->w[index - 15], 18)) ^ (RIGHT_SHIFT(sha224->w[index - 15], 3)));
            sha224->s1 = ((R_RIGHT(sha224->w[index - 2], 17)) ^ (R_RIGHT(sha224->w[index - 2], 19)) ^ (RIGHT_SHIFT(sha224->w[index - 2], 10)));
            sha224->w[index] = sha224->w[index - 16] + sha224->s0 + sha224->w[index - 7] + sha224->s1;
        }
        
        sha224->a = sha224->h[0];
        sha224->b = sha224->h[1];
        sha224->c = sha224->h[2];
        sha224->d = sha224->h[3];
        sha224->e = sha224->h[4];
        sha224->f = sha224->h[5];
        sha224->g = sha224->h[6];
        sha224->hs = sha224->h[7];
        
        for(int i = 0; i < 64; i++){
            
            sha224->s0 = ((R_RIGHT(sha224->a, 2)) ^ (R_RIGHT(sha224->a, 13)) ^ (R_RIGHT(sha224->a, 22)));
            sha224->maj = ((sha224->a & sha224->b) ^ (sha224->a & sha224->c) ^ (sha224->b & sha224->c));
            sha224->t2 = sha224->s0 + sha224->maj;
            sha224->s1 = ((R_RIGHT(sha224->e, 6)) ^ (R_RIGHT(sha224->e, 11)) ^ (R_RIGHT(sha224->e, 25)));
            sha224->ch = ((sha224->e & sha224->f) ^ ((~sha224->e) & sha224->g));
            sha224->t1 = sha224->hs + sha224->s1 + sha224->ch + k[i] + sha224->w[i];
            
            sha224->hs = sha224->g;
            sha224->g = sha224->f;
            sha224->f = sha224->e;
            sha224->e = sha224->d + sha224->t1;
            sha224->d = sha224->c;
            sha224->c = sha224->b;
            sha224->b = sha224->a;
            sha224->a = sha224->t1 + sha224->t2;
        }
        
        sha224->h[0] += sha224->a;
        sha224->h[1] += sha224->b;
        sha224->h[2] += sha224->c;
        sha224->h[3] += sha224->d;
        sha224->h[4] += sha224->e;
        sha224->h[5] += sha224->f;
        sha224->h[6] += sha224->g;
        sha224->h[7] += sha224->hs;
        
        
    }
    printf("DIGEST: %X %X %X %X %X %X %X \n", sha224->h[0], sha224->h[1], sha224->h[2], sha224->h[3], sha224->h[4], sha224->h[5], sha224->h[6]);
    free(mex);
    mex = NULL;
    return *sha224->h;
}
