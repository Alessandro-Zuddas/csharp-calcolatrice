
using csharp_calcolatrice;

int a = 10;
int b = 20;
int c;

double a2 = 10.5;
double b2 = 20.5;
double c2;

//Somma di due interi
c = CalcoliHelper.Somma(a, b);
Console.WriteLine($"La somma tra {a} e {b} è: " + c);

//Somma di due double
c2 = CalcoliHelper.Somma(a2, b2);
Console.WriteLine($"La somma tra {a2} e {b2} è: " + c2);

//Differenza di due interi
c = CalcoliHelper.Differenza(a, b);
Console.WriteLine($"La differenza tra {a} e {b} è: " + c);

//Differenza di due double
c2 = CalcoliHelper.Differenza(a2, b2);
Console.WriteLine($"La differenza tra {a2} e {b2} è: " + c2);

//Moltiplicazione di due interi
c = CalcoliHelper.Moltiplicazione(a, b);
Console.WriteLine($"Il prodotto tra {a} e {b} è: " + c);

//Moltiplicazione di due double
c2 = CalcoliHelper.Moltiplicazione(a2, b2);
Console.WriteLine($"Il prodotto tra {a2} e {b2} è: " + c2);

//Valore assoluto di un intero
c = CalcoliHelper.Assoluto(a);
Console.WriteLine($"Il valore assoluto di {a} è: " + c);

//Valore assoluto di un double
c2 = CalcoliHelper.Assoluto(a2);
Console.WriteLine($"Il valore assoluto di {a2} è: " + c2);

//Più piccolo dei due numeri interi
c = CalcoliHelper.Minimo(a, b);
Console.WriteLine($"Il numero minimo tra {a} e {b} è: " + c);

//Più piccolo dei due numeri double
c2 = CalcoliHelper.Minimo(a2, b2);
Console.WriteLine($"Il numero minimo tra {a2} e {b2} è: " + c2);

//Più grande dei due numeri interi
c = CalcoliHelper.Massimo(a, b);
Console.WriteLine($"Il numero massimo tra {a} e {b} è: " + c);

//Più grande dei due numeri double
c2 = CalcoliHelper.Massimo(a2, b2);
Console.WriteLine($"Il numero massimo tra {a2} e {b2} è: " + c2);

//Eleva un numero a potenza
c = CalcoliHelper.ElevaPotenza(a, b);
Console.WriteLine($"{a} elevato {b} è uguale a: " + c);