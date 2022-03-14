// See https://aka.ms/new-console-template for more information
   Console.WriteLine("Welcome to Snake-and-ladders");

const int NO_PLAY = 0;
const int LADDER = 1;
const int SNAKE = 2;
int positionOne = 0;
int positionTwo = 0;
int loopCount = 0;
int currentPlayer = 1;
int currentPlayerPos = 0;

Random random = new Random();

while (positionOne < 100 && positionTwo < 100)
{
    loopCount++;
    if (currentPlayerPos == 1)
    {
        currentPlayerPos = positionOne;
    }
    else
    {
        currentPlayerPos = positionTwo;

    }

    int diceNum = random.Next(0, 7),
    result = random.Next(0, 3);

    if (result == LADDER)
    {
        {
            if (currentPlayerPos + diceNum <= 100)
            {
                currentPlayerPos += diceNum;
            }
            else if (result == SNAKE)
                if (currentPlayerPos - diceNum >= 0)

                {
                    currentPlayerPos -= diceNum;
                }
                else
                {
                    currentPlayerPos = 0;
                }

        }
        if (currentPlayer == 1)
        {
            positionOne = currentPlayerPos;
            currentPlayer = 2;
        }
        else
        {
            positionTwo = currentPlayerPos;
            currentPlayer = 1;
        }
    }
}

if (positionOne == 100)
{
    Console.WriteLine("Player One Wins");
}
else if (positionTwo == 100)
{
    Console.WriteLine("Player Two Wins");
}
Console.WriteLine("Dice Rolled :" + loopCount + "times");
