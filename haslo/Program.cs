string haslo = "Haslo123!";

bool maMalaLitere = false;

bool maDuzaLitere = false;

bool maCyfre = false;

bool maZnakSpecjalny = false;

foreach (char znak in haslo)

{

    if (char.IsLower(znak)) maMalaLitere = true;

    if (char.IsUpper(znak)) maDuzaLitere = true;

    if (char.IsDigit(znak)) maCyfre = true;

    if (!char.IsLetterOrDigit(znak)) maZnakSpecjalny = true;

}



bool silneHaslo = maMalaLitere || maDuzaLitere || maCyfre || maZnakSpecjalny;

Console.WriteLine(silneHaslo ? "Silne" : "Słabe");






string haslo1 = "Haslo123!";

maMalaLitere = false;

 maDuzaLitere = false;

 maCyfre = false;

maZnakSpecjalny = false;

foreach (char znak in haslo)

{

    if (char.IsLower(znak)) maMalaLitere = true;

    if (char.IsUpper(znak)) maDuzaLitere = true;

    if (char.IsDigit(znak)) maCyfre = true;

    if (!char.IsLetterOrDigit(znak)) maZnakSpecjalny = true;

}



silneHaslo = (maMalaLitere && maDuzaLitere && maCyfre && maZnakSpecjalny); //Musimy sprawdzić czy hasło zawiera wszystkie z rzeczy , a nie tylko jedną 

Console.WriteLine(silneHaslo ? "Silne" : "Słabe");
