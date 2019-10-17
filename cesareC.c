#include <stdio.h>
#include <string.h>

int main(){
	int skip = 3;
	char parola[50];
	int j=0;
	int i=0;
	char alfabeto[26]= {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
	
	printf("Inserisci la parola da crittografare: \n");
	scanf("%s",parola);



	for(i=0;i<26; i++){
		if(parola[j] == alfabeto[i]){
			if(i+skip>26){
				printf("%c",alfabeto[i+skip-26]);
			}else{
				printf("%c",alfabeto[i+skip]);
				
			}
			j++;
			i=-1;
		}

	}
	printf("\n");
	

}