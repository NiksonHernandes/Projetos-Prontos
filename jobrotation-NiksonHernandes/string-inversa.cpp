#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char string[60] = "Meu sonho eh programar!";
    char c;

    int i, tam = strlen(string);

    for(i = 0; i<tam/2; i++)
    {
        c = string[i];
        string[i] = string[tam-1-i];
        string[tam-1-i] = c;
    }

    printf("A frase \"Meu sonho eh programar\" invertida fica: %s\n", string);
    return 0;
}
