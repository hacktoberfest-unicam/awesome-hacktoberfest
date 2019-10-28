/*******************************************************************************
 * File:        sha1.h                                                       *
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

#ifndef SHA1_H
#define SHA1_H

typedef struct SHA1Config {
    /*** VARIABLES DECLARATION ***/
    unsigned int  w[80];
    unsigned int  h[5];                         // Variables from h0 to h4
    unsigned int  a, b, c, d, e;                // Variables where we will store the hash values
    unsigned int  f, k, temp;                   // Variables used for the digest calculation
    int current_len;                            // Current length of the message
    int original_len;                           // Original length of the message
    int num_chunks;                             // Number of chunks in the message

} SHA1config;

unsigned char * SHA1_read_file(char *path);
void SHA1_set(SHA1config *sha1);
unsigned int sha1_exe(SHA1config *sha1, unsigned char * message);
SHA1config *sha1_padding(SHA1config *sha1, unsigned char * mex);
unsigned int funzioneSHA1(SHA1config *sha1, char *pathInp);

#endif /* SHA1_H */
