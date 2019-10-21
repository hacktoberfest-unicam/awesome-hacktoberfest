/*******************************************************************************
 * File:        sha1.c                                                       *
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
#include <memory.h>
#include <malloc.h>
#include <math.h>
#include <limits.h>

#include "sha1.h"
#define ROTATE_LEFT(x,n) ((x<<n) | (x>>(32-n)))

/*** VARIABLES DEFINITION ***/
void SHA1_set(SHA1config *sha1) {
    sha1->h[0] = 0x67452301;
    sha1->h[1] = 0xEFCDAB89;
    sha1->h[2] = 0x98BADCFE;
    sha1->h[3] = 0x10325476;
    sha1->h[4] = 0xC3D2E1F0;

    sha1->num_chunks = 0;
    sha1->current_len = 0;
    sha1->original_len = 0;
}

/*
 * Function used to read the input file
 */
unsigned char * SHA1_read_file(char *path) {
    FILE *fp;
    char testo[CHAR_MAX];
    unsigned char * msg = (char *) malloc(strlen(testo) + 1);
    fp = fopen(path, "r");
    /* Cambia il path di fopen a seconda del file che vuoi leggere */
    if (fp == NULL) {
        printf("File non trovato");
    }
    while (fscanf(fp, "%s", testo) != EOF) {
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

SHA1config *sha1_padding(SHA1config *sha1, unsigned char * mex) {
    /*          ******** PADDING [APPENDING 448 BITS '0'] ********
     * We append k bits '0' until it reaches 448 mod 512 length
     * And then we are going to append 8 bytes (64 bits) more to the message
     * which represent the original length of the message
     */
    int bit_padding = sha1->current_len % 64; // 64 bytes = 512 bits

    if (bit_padding < 56) { // 56 bytes = 448 bits
        bit_padding = 56 - bit_padding;
    } else {
        bit_padding = 120 - bit_padding; // 120 bytes = 960 bits [960 mod 512 = 448]
    }
    int i = 0;
    while (i < bit_padding) {

        mex[sha1->current_len] = 0x00;
        sha1->current_len++;
        i++;
    }


    mex[sha1->current_len + 1] = '\0';
    int j;


    /*** APPEND THE LENGTH OF MESSAGE IN 64-BITS FORMAT AT THE END OF THE MESSAGE  ***/
    for (j = 0; j < 6; j++) {
        mex[sha1->current_len] = 0x00;
        sha1->current_len++;
    }


    mex[sha1->current_len] = (sha1->original_len * 8) / 0x100;
    sha1->current_len++;

    mex[sha1->current_len] = (sha1->original_len * 8) % 0x100;
    sha1->current_len++;

    mex[sha1->current_len + j] = '\0';
    sha1->num_chunks = sha1->current_len / 64;
    return sha1;
}

/*
 * Function used for processing the message and calculate the digest
 * This is where the most important part happens, the real process of digest elaboration
 */

unsigned int sha1_exe(SHA1config *sha1, unsigned char * message) {
    unsigned char *mex = (unsigned char *) malloc(strlen((const char *) message) + 100);
    strcpy((unsigned char *) mex, (const char *) message);
    sha1->current_len = strlen((const char *) mex);
    sha1->original_len = sha1->current_len;

    // Append the bit '1' to the message

    mex[sha1->current_len] = 0x80;

    mex[sha1->current_len + 1] = '\0'; // NULL terminator
    sha1->current_len++;

    sha1_padding(sha1, mex);

    /*** MAIN OPERATION OF THE SHA-1 ALGORITHM (search for the pseudo-code) ***/
    int index;
    int j;
    for (j = 0; j < sha1->num_chunks; j++) { // Main loop for each chunk we have (512 bits)
        for (index = 0; index < 16; index++) {
            //  break chunk into sixteen 32-bit big-endian words w[index]            
            sha1->w[index] = mex[j * 64 + index * 4 + 0] * 0x1000000 + mex[j * 64 + index * 4 + 1] * 0x10000 + mex[j * 64 + index * 4 + 2] * 0x100 + mex[j * 64 + index * 4 + 3];
        }

        for (index = 16; index < 80; index++) {
            sha1->w[index] = ROTATE_LEFT((sha1->w[index - 3] ^ sha1->w[index - 8] ^ sha1->w[index - 14] ^ sha1->w[index - 16]), 1);
        }

        sha1->a = sha1->h[0];
        sha1->b = sha1->h[1];
        sha1->c = sha1->h[2];
        sha1->d = sha1->h[3];
        sha1->e = sha1->h[4];

        for (int m = 0; m < 80; m++) {
            if (m <= 19) {
                sha1->f = (sha1->b & sha1->c) | ((~sha1->b) & sha1->d);
                sha1->k = 0x5A827999;
            } else if ((m >= 20) && (m <= 39)) {
                sha1->f = sha1->b ^ sha1->c ^ sha1->d;
                sha1->k = 0x6ED9EBA1;
            } else if ((m >= 40) && (m <= 59)) {
                sha1->f = (sha1->b & sha1->c) | (sha1->b & sha1->d) | (sha1->c & sha1->d);
                sha1->k = 0x8F1BBCDC;
            } else if ((m >= 60) && (m <= 79)) {
                sha1->f = sha1->b ^ sha1->c ^ sha1->d;
                sha1->k = 0xCA62C1D6;
            }

            sha1->temp = (ROTATE_LEFT(sha1->a, 5) + sha1->f + sha1->e + sha1->k + sha1->w[m]) & 0xFFFFFFFF;

            sha1->e = sha1->d;
            sha1->d = sha1->c;
            sha1->c = ROTATE_LEFT(sha1->b, 30);
            sha1->b = sha1->a;
            sha1->a = sha1->temp;

        }

        sha1->h[0] += sha1->a;
        sha1->h[1] += sha1->b;
        sha1->h[2] += sha1->c;
        sha1->h[3] += sha1->d;
        sha1->h[4] += sha1->e;
        printf("\n\n");
    }
    
    printf("DIGEST: %X %X %X %X %X\n\n", sha1->h[0], sha1->h[1], sha1->h[2], sha1->h[3], sha1->h[4]);
    free(mex);
    mex = NULL;
    return *sha1->h;
}

