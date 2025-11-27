
int dzien = 15, miesiac = 11, rok = 2024;

DateTime data = new DateTime(rok, miesiac, dzien);

string dzienTygodnia = data.DayOfWeek.ToString();

Console.WriteLine($"Dzień tygodnia: {dzienTygodnia}");

//nie ma błędu