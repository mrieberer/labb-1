void csHTMLgenerator(string KLASSNAMN, string[] meddelande)
{
    Console.WriteLine($"<!DOCTYPE html>\n<body>\n<h1>Välkomna {KLASSNAMN}</h1>");

    customMessage(meddelande, 1);
    //$"<p><b>Meddelande 1:</b> {welcomeMessage(meddelande1)}.</p>");
    //Console.WriteLine($"<p><b>Meddelande 2:</b> {meddelande2}.</p>");
    Console.WriteLine("</main>\n</body>\n</html>");
}

void customMessage(string[] inMeddelande, int messageNumber)
{
    //messageNumber = 1;
    Console.WriteLine($"<p><b>Meddelande {messageNumber}:</b> {inMeddelande[messageNumber - 1]}.</p>");

    if (messageNumber < inMeddelande.Length)
    {
        messageNumber++;
        customMessage(inMeddelande, messageNumber);
    }
}

//nu kompilerar inte programmet.

csHTMLgenerator("C# Programmet", new string[] { "Vi börjar med Git", "Sedan fokuserar vi på Backend utveckling", "SQl Server", "Frontend", "machine Learning", "Felsökning" });