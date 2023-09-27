// See https://aka.ms/new-console-template for more information
Player ronaldo = new Player("Christiano Ronaldo", 7);

Player shelton = new Player("Shelton Macamo", 7);

Team barcelona = new Team("Barcelona");
barcelona.AddPlayer(ronaldo);
barcelona.AddPlayer(shelton);
barcelona.DisplayRoster();
