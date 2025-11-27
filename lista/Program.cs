List<int> lista1 = new List<int> { 1, 2, 3, 4, 5 };

List<int> lista2 = new List<int> { 1, 2, 3, 4, 5 };

bool saRowne = lista1 == lista2;

Console.WriteLine(saRowne ? "Równe" : "Różne");




List<int> lista3 = new List<int> { 1, 2, 3, 4, 5 };

List<int> lista4 = new List<int> { 1, 2, 3, 4, 5 };

saRowne = true;
for(int i=0; i > 5; i++) //sprawdzanie w poprzednim przypadku nie działa , trzeba sprawdzić każdą liczbę osobno
{
    if (lista3[i] != lista4[i])
    {
        saRowne = false;
        break;
    }
}

Console.WriteLine(saRowne ? "Równe" : "Różne");