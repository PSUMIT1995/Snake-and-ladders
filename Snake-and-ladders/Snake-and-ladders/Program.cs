// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Snake-and-ladders");

const int START = 0;
const int FINISH = 100;
const int NO_PLAY = 0;
const int LADDER = 1;
const int SNAKE = 2;
Random random = new Random();

int Roll_Dice()
{
    return random.Next(1, 7);
}
int Player_Move_Option(int player_Roll_Dice)
{
    int check_Player_Option = random.Next(0, 3);
    int player_Move = 0;
    switch (check_Player_Option)
    {
        case LADDER:
            player_Move = player_Roll_Dice;
            break;
        case SNAKE:
            player_Move = -player_Roll_Dice;
            break;
        default:
            break;
    }
    return player_Move;
}

{
    int player_position = 0, player_Next_Position;

    //Repeats till the Player reaches the winning position 100.
    while (player_position < FINISH)
    {
        // player rolls the dice and gets the value
        int player_Roll_Dice = Roll_Dice();

        // The Player then checks for a Option. 
        int player_move = Player_Move_Option(player_Roll_Dice);
        player_Next_Position = player_position + player_move;

        if (player_Next_Position < START)
            player_position = START;
        else
            player_position = player_Next_Position;
    }
    Console.WriteLine("Player current position after the game is " + player_position);
}