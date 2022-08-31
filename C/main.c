#include <stdio.h>
#include <locale.h>
#include <string.h>

int main()
{
    setlocale(LC_ALL, "Turkish");
    FILE *sozler = NULL;
    sozler = fopen("soz.txt", "r");

    char sentence[50] = "";

    if (sozler == NULL)
    {
        printf("Error! Can't find file!\n");
        return 1;
    }

    while (fgets(sentence, sizeof(sozler), sozler))
    {
        printf("%s", sentence);
        memset(sentence, 0, sizeof sentence);
    }

    fclose(sozler);

    return 0;
}
