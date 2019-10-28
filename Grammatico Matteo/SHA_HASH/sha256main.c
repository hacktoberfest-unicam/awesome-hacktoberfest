/*******************************************************************************
 * File:        sha256main.c                                                       *
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

#include "sha256.h"

unsigned int funzioneSHA256(SHA256 *sha256, char *pathInp) {
    printf("\n\n************ SHA-256 *************\n");
    sha256_set(sha256);
    char *p_inp = pathInp;
    char *real_p = realpath(p_inp, NULL);
    unsigned char * msg = (char *)malloc(sizeof(UCHAR_MAX));
    msg = SHA256_read_file(p_inp);
    

    unsigned int digest;
    digest = sha256_exe(sha256, msg);
    printf("\n\n");
    free(real_p);
    free(msg);
    real_p = NULL;
    msg = NULL;
    return digest;
}

int main(int argc, char** argv){
    SHA256 s;
    char *path_input = argv[1];
    char *real_input = realpath(path_input, NULL);
    funzioneSHA256(&s, real_input);
}