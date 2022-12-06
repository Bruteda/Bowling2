
Game game = new Game();

for (int i = 0; i < 20; i++)
{
game.Roll(10);
    
}

Console.WriteLine(game.Score());