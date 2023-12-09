using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video firstVideo = new Video("German Garmendia", "hohohola soy German", 16);
        firstVideo.AddComment("Pedro", "Great video!");
        firstVideo.AddComment("Pancrasio", "Very entertaining");
        firstVideo.DisplayVideo();

        Video secondVideo = new Video("Luisito Comunica", "Rey Palomo", 20);
        secondVideo.AddComment("Ignacio", "Aweasome");
        secondVideo.AddComment("Perengano", "Hilarious");
        secondVideo.DisplayVideo();

        Video thirdVideo = new Video("Japon con Jamon", "Cuidaooooo", 14);
        thirdVideo.AddComment("Fiona", "Loved it! <3");
        thirdVideo.AddComment("Fulano", "Amazing");
        thirdVideo.DisplayVideo();
        
    }
}