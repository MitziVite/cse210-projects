using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectureEvent = new Lectures("Colapso", "Hoy crei que ella volvio", DateTime.Now, "02:00", "Calle del Castillo", "CJ", "Kevin Kaarl", 50);

        Reception receptionEvent = new Reception("La chica de Humo", "Aun yo no se quien es", DateTime.Now, "4:00", "Jacarandas", "Ciudad Juarez", "apartado");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Volare", "y eso que estas del otro lado del Atlantico", DateTime.Now, "08:00", "Italia");

        DisplayEventDetails(lectureEvent, "Standard details");
        DisplayEventDetails(lectureEvent, "Full details");
        DisplayEventDetails(lectureEvent, "Short description");

        DisplayEventDetails(receptionEvent, "Standard details");
        DisplayEventDetails(receptionEvent, "Full details");
        DisplayEventDetails(receptionEvent, "Short description");

        DisplayEventDetails(outdoorEvent, "Standard details");
        DisplayEventDetails(outdoorEvent, "Full details");
        DisplayEventDetails(outdoorEvent, "Short description");

        static void DisplayEventDetails(Event evento, string messageType)
    {
        string message;

        switch (messageType)
        {
            case "Standard details":
                message = evento.StandardDetails();
                break;
            case "Full details":
                message = evento.FullDetails();
                break;
            case "Short description":
                message = evento.ShortDescription();
                break;
            default:
                message = "Invalid message type";
                break;
        }

        Console.WriteLine($"Event Type: {evento.GetType().Name}\nMessage Type: {messageType}\nMessage: {message}\n");
    }
    }
}