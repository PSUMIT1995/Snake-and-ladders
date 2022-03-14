// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Snake-and-ladders");

const int NO_PLAY = 1;
const int LADDER = 2;
const int SNAKE = 3;
int playerOnePosition = 0;
Random random = new Random();
int dieRoll;
dieRoll = random.Next(1, 7);
int check = random.Next(1, 4);
switch (check)
{
    case NO_PLAY:
        playerOnePosition = playerOnePosition + 0;
        break;
    case LADDER:
        playerOnePosition = playerOnePosition + dieRoll;
        break;
    case SNAKE:
        playerOnePosition = playerOnePosition - dieRoll;
        if (playerOnePosition < 0)
            playerOnePosition = 0;
        break;
}
Console.WriteLine("Position of Player 1 is at " + playerOnePosition);