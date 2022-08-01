#include <stdio.h>
#include <stdlib.h>

int formatacao()
{
    printf("\n=====Faturamento Mensal=====\n\n");
    printf("SP[1] - R$67.836,43\nRJ[2] -  R$36.678,66\nMG[3] - R$29.229,88\nES[4] - R$27.165,48\nOutros[5] - R$19.849,53\n\n");
}

void percentual(float percentualMensal[], int n)
{
    float valores[] = {6783643, 3667866, 2922988, 2716548, 1984953};
    int tam = sizeof(valores) / sizeof(valores[0]);
    float soma = 0;

    for(int i=0; i<tam; i++)
    {
        soma = soma + valores[i];
    }

    for(int i=0; i<tam; i++)
    {

        percentualMensal[i] = (valores[i] / soma) * 100;
    }
}

int main()
{
    formatacao();
    float percentualMensal[5], total = 0;

    percentual(percentualMensal, 5);
    for(int i = 0; i<5; i++)
    {
        printf("\n Percentual de participacao do Estado [%i]: %.2f%%",i+1, percentualMensal[i]);
        total = total + percentualMensal[i];
    }
    printf("\n\n\t Total: %.2f\n", total);


    return 0;
}
