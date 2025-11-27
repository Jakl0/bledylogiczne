int rok = 2024;

if (rok % 4 == 0)

{

    Console.WriteLine("Rok przestępny");

}

else

{

    Console.WriteLine("Rok nieprzestępny");

}




rok = 2024;

if (rok % 4 == 0 &&(rok%100 !=0|| rok % 400==0)) // lata przestepne nie wystepuja w latach setnych lecz wyjatkiem sa czterysetne

{

    Console.WriteLine("Rok przestępny");

}

else

{

    Console.WriteLine("Rok nieprzestępny");

}