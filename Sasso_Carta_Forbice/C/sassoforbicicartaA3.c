#include<stdio.h>
#include <stdlib.h>
int main(){
	int randa;
	int scelta=0;
	int i=0;
	int punteggio = 0;
	
	while(i<3){
		randa= rand() %2;

		do{
			printf("Inserire numero 1,2,3 , 1=Sasso, 2=Carta, 3=Forbice: ");
			scanf("%d",&scelta);
		}while(scelta<1 || scelta>3);

		switch(scelta){
			case 1:
				if(randa==0){
					printf("Draw\n");
					printf("Punteggio: %d\n",punteggio);
				}
				if(randa==1){
					printf("You lose , Sasso perde contro la carta\n");
					printf("Punteggio: %d\n",punteggio);
				}	
				if(randa==2){
					printf("You win , Sasso batte contro le forbici\n");
					punteggio++;
					printf("%d\n", punteggio);
				}
				break;
				
			case 2:
				if(randa==0){
					printf("You win , carta batte contro sasso\n");
					punteggio++;
					printf("%d\n", punteggio);
				}
				if(randa==1){
					printf("Draw\n");
					printf("Punteggio: %d\n",punteggio);
				}	
				if(randa==2){
					printf("You lose , carta perde contro le forbici\n");
					printf("Punteggio: %d\n",punteggio);
				}
				break;
				
			case 3:
				if(randa==0){
					printf("You lose , forbice perde contro sasso\n");
					printf("Punteggio: %d\n",punteggio);
				}
				if(randa==1){
					printf("You win, forbice batte carta\n");
					punteggio++;
					printf("%d\n", punteggio);
				}	
				if(randa==2){
					printf("Draw\n");
					printf("Punteggio: %d\n",punteggio);
				}
				break;
		}
		i++;
		scelta=-1;
		
	}
	return 1;
}