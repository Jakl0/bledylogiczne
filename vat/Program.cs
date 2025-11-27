double cenaNetto = 100;

double vat = 23; // 23% 

double cenaBrutto = cenaNetto + vat;

Console.WriteLine($"Cena brutto: {cenaBrutto}");





cenaNetto = 100;

vat = 23; // 23% 

cenaBrutto = cenaNetto + cenaNetto*(vat/100); //To jest poprawny zapis procentu który działa na każdą liczbę

Console.WriteLine($"Cena brutto: {cenaBrutto}");