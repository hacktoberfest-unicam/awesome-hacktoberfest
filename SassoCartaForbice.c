#include<stdio.h>
#include <stdlib.h>
int main(){
	int randa;
	int scelta=-1;
	printf("Inserire numero 1,2,3 , 1=Sasso,2=Carta, 3=Forbice, 0= non voglio giocare:");
	while(scelta<0 || scelta>3)	{
		scanf("%d",&scelta);
	}
	randa= rand() %2;
	switch(scelta){
		case 0:
			printf("non giochi");
			break;
		case 1:
			if(randa==0){
				printf("Draw");
			}
			if(randa==1){
				printf("You lose , Sasso perde contro la carta");
			}	
			if(randa==2){
				printf("You win , Sasso batte contro le forbici");
			}
			break;
		case 2:
			if(randa==0){
				printf("You win , carta batte contro sasso");
			}
			if(randa==1){
				printf("Draw");
			}	
			if(randa==2){
				printf("You lose , carta perde contro le forbici");
			}
			break;
		case 3:
			if(randa==0){
				printf("You lose , forbice perde contro sasso");
			}
			if(randa==1){
				printf("You win, forbice batte carta");
			}	
			if(randa==2){
				printf("Draw");
			}
			break;
			
	}
	return 1;
}
