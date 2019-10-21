/*******************************************************************************
 * File:        sha1main.c                                                       *
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
#include <limits.h>
#include <stdint.h>

#include "sha1.h"

unsigned int funzioneSHA1(SHA1config *sha1, char *pathInp) {
    printf("\n\n************ SHA-1 *************\n");
    SHA1_set(sha1);
    char *p_inp = pathInp;

    unsigned char * msg = (char *)malloc(sizeof(UCHAR_MAX));
    msg = SHA1_read_file(p_inp);
    char *real_p = realpath(p_inp, NULL);

    unsigned int digest;
    digest = sha1_exe(sha1, msg);

    free(real_p);
    free(msg);
    real_p = NULL;
    msg = NULL;

    return digest;
}

int main(int argc, char** argv){
    SHA1config s;
    char *path_input = argv[1];
    char *real_input = realpath(path_input, NULL);
    funzioneSHA1(&s, real_input);
}
