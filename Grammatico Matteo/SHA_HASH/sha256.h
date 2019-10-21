/*******************************************************************************
 * File:        sha256.h                                                       *
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

#ifndef SHA256_H
#define SHA256_H

#include <stdio.h>
#include <stddef.h>

typedef struct {

    unsigned int w[80];
    unsigned int h[8];                              // Variables from h0 to h7
    unsigned int a, b, c, d, e, f, g, hs;           // Variables where we will store the hash values
    unsigned int s0, s1, ch, maj, t1, t2;           // Variables used for the digest calculation
    int current_len;                                // Current length of the message
    int original_len;                               // Original length of the message
    int num_chunks;                                 // Number of chunks in the message

} SHA256;

void sha256_set(SHA256 *sha256);
unsigned char * SHA256_read_file(char *path);
SHA256 *sha256_pad(SHA256 *sha256, unsigned char * mex);
unsigned int sha256_exe(SHA256 *sha256, unsigned char * message);
unsigned int funzioneSHA256(SHA256 *sha256, char *pathInp);

#endif /* SHA256_H */

