string zdanie = "Programowanie w C# jest bardzo ciekawe";

string[] slowa = zdanie.Split(' ');

string najdluzsze = "";

foreach (string slowo in slowa)

{

    if (slowo.Length >= najdluzsze.Length)

    {

        najdluzsze = slowo;

    }

}

Console.WriteLine($"Najdłuższe słowo: {najdluzsze}");

//nie ma bledu
