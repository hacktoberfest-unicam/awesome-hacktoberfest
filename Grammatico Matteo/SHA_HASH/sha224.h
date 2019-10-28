/*******************************************************************************
 * File:        sha224.h                                                       *
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

#ifndef SHA224_H
#define SHA224_H


#include <stdio.h>
#include <stddef.h>

typedef struct {
    //unsigned char mex[64];
    unsigned int w[80];
    unsigned int h[8];                              // Variables from h0 to h7
    unsigned int a, b, c, d, e, f, g, hs;           // Variables where we will store the hash values
    unsigned int s0, s1, ch, maj, t1, t2;           // Variables used for the digest calculation
    int current_len;                                // Current length of the message
    int original_len;                               // Original length of the message
    int num_chunks;                                 // Number of chunks in the message

} SHA224;

void sha224_set(SHA224 *sha224);
SHA224 *sha224_pad(SHA224 *sha224, unsigned char *mex);
unsigned int sha224_exe(SHA224 *sha224, unsigned char *mex);
unsigned char * SHA224_read_file(char *path);
unsigned int funzioneSHA224(SHA224 *sha224, char *pathInp);

#endif /* SHA224_H */

