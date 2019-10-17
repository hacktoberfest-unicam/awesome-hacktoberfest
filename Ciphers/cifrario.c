#include <stdio.h>
#include <string.h>

int main()
{
	char string[100];
	int shift = 0;
	printf("stringa (max 100 caratteri minuscoli): ");
	fgets(string, 100, stdin);
	printf("valore spostamento: ");
	scanf("%d", &shift);
	for (int i=0; i<strlen(string);i++)
	{
		if (string[i]!=' ' && string[i]!='\n')
		{		
			int t = 0;	
			while(t!=shift)
			{
				if(string[i]>='a' && string[i]<'z') {
					string[i]++;
				} else { string[i] = 'a';}
				t++;
			}
		}
	}
	printf("La stringa cifrata è: \"%s\"\n",string);
}
