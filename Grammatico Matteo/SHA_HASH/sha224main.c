/*******************************************************************************
 * File:        sha224main.c                                                       *
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

unsigned int funzioneSHA224(SHA224 *sha224, char *pathInp) {
    printf("\n\n************ SHA-224 *************\n");    
    sha224_set(sha224);
    char *p_inp = pathInp;
    char *real_p = realpath(p_inp, NULL);
    unsigned char * msg = (char *)malloc(sizeof(UCHAR_MAX));
    msg = SHA224_read_file(p_inp);

    unsigned int digest;
    digest = sha224_exe(sha224, msg);
    
    free(real_p);
    free(msg);
    real_p = NULL;
    msg = NULL;
    return digest;
}

int main(int argc, char** argv){
    SHA224 s;
    char *path_input = argv[1]; 
    char *real_input = realpath(path_input, NULL);
    funzioneSHA224(&s, real_input);
}
