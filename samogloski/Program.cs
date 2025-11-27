string slowo = "programowanie";

int licznik = 0;

foreach (char litera in slowo)

{

    if (litera == 'a' || litera == 'e' || litera == 'i' ||

      litera == 'o' || litera == 'u')

    {

        licznik++;

    }

}
Console.WriteLine($"Liczba samogłosek: {licznik}");

slowo = "programowanie";

licznik = 0;

foreach (char litera in slowo)

{

    if (litera == 'a' || litera == 'e' || litera == 'i' ||

      litera == 'o' || litera == 'u' || litera == 'ó' || litera == 'ą' || litera == 'ę'||litera =='y' || litera == 'A' || litera == 'E' || litera == 'I' ||

      litera == 'O' || litera == 'U' || litera == 'Ó' || litera == 'Ą' || litera == 'Ę'||litera == 'Y') //uwzględniamy duże litery , polskie znaki i literę Y

    {

        licznik++;

    }

}
Console.WriteLine($"Liczba samogłosek: {licznik}");