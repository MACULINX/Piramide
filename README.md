# Piramide

Piramide è un algoritmo che data una quantità di mattoni riesce a capire quanti piani di una piramide si possono costruire e quanti ne avanzeranno.

La piramide è formata con le seguenti caratteristiche:

- i piani della piramide siano quadrati
- la piramide da costruire sia compatta, cioè non ci siano cavità al suo interno. 
- ogni piano è quadrato, con una lunghezza laterale inferiore di due rispetto a quella sottostante.
- il primo piano è sempre di un mattone

## Cosa torna il codice

- tramite il metodo int Piani che riceve in input int mattoni e torna il numero di piani
- tramite il metodo int Rimanenti che riceve in input int mattoni che torna il numero di mattoni rimasti dopo la costruzione

## Descrizione del codice

<details>
<summary>Metodo int Piani</summary>

```c#
public static int Piani( int mattoni )
{
    if(mattoni <= 0)
        return 0;
    
    bool flag = true;
    int piani = 0;
    int mattnec = 0;
    int matt = 1;

    while(flag)
    {
        flag = (Math.Pow((matt),2)) + mattnec <= mattoni ? true : false;
        
        if(flag){
            mattnec = mattnec + (int)(Math.Pow((matt),2));
            matt+=2;
            piani++;
        }
        
    }
    
    return piani;
}
```

Questo algoritmo calcola la quantità di piani che si possono costruire dati i mattoni
</details>

<details>
<summary>Metodo int Rimanenti</summary>

```c#
public static int Rimanenti( int mattoni )
{
    if(mattoni <= 0)
        return 0;
            
    bool flag = true;
    int mattnec = 0;
    int matt = 1;

    while(flag)
    {
        flag = (Math.Pow((matt),2)) + mattnec <= mattoni ? true : false;
                
        if(flag){
            mattnec = mattnec + (int)(Math.Pow((matt),2));
            matt+=2;
        }        
    }

    return mattoni - mattnec;
}
```
Questo algoritmo calcola la quantità di mattoni rimanenti dopo aver costruito la piramide
</details>
