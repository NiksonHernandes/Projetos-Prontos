#include <stdio.h>


int fibonacci(int n) {
    int x;

    if (n == 1) {
        return(1);
    }

    if (n == 2) {
        return(1);
    }

    x = fibonacci(n-1) + fibonacci(n-2);
    return(x);
}

int main() {
    int n,i, repete = 0;

    printf("Digite o numero de termos da sequencia: ");
    scanf("%d", &n);

    while(n <= 0) {
        printf("Numero incorreto. Digite o numero de termos da sequencia: ");
        scanf("%d", &n);
    }

    for (i = 1; i <= n; i++) {
        int x = fibonacci(i);
        if(x == n){
            repete = repete + 1;
        }

        printf("%d ", x);

    }
    printf("\n\tO numero %i repete: %i vezes", n, repete);
    printf("\n");
    return(0);
}
