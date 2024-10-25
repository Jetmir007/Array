/*static void Main(){
    int[] a = new int[5];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        Console.Write("Tal nr " + (i+1) + ": ");
        a[i] = int.Parse(Console.ReadLine());
    }
    Console.Write( (a[4], a[3], a[2], a[1], a[0]));
}
Main();

static void Main()
{
    double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9};
    double a = 0;
    for (int i = 0; i < temperatur.GetLength(0); i++)
    {
        a += temperatur[i];
    }
    double b = Math.Round(a/temperatur.GetLength(0), 2);
    Console.WriteLine(b);
}
Main();
*/

using System;

char[,] gameboard = new char[,] {
    {'-', '-', '-'}, 
    {'-', '-', '-'}, 
    {'-', '-', '-'}};

double p1 = 0;
double p2 = 0;
int rundor = 0;

while(true){
    Main();
}

void Main(){
    P1();
    Slut();
    P2();
    Slut();
}

void P1(){
    
    Gameboard_Load(gameboard);
    if(rundor == 0){
        Console.WriteLine("Spelare 1 skriv ett koordinat x,y");
    }
    while(true){
        string input1 = Console.ReadLine();
        string[] input2 = input1.Split(',');
        int input_x = int.Parse(input2[0]);
        int input_y = int.Parse(input2[1]);
        if(gameboard[input_y-1, input_x-1] == '-'){
            gameboard[input_y-1, input_x-1] = 'x';
            break;
        }
        else{
            Console.WriteLine("Fel input, testa igen");
        }
    }
}


void P2(){
    Gameboard_Load(gameboard);
    if(rundor == 0){
        Console.WriteLine("Spelare 2 skriv ett koordinat x,y");
    }
    while(true){
        string input1 = Console.ReadLine();
        string[] input2 = input1.Split(',');
        int input_x = int.Parse(input2[0]);
        int input_y = int.Parse(input2[1]);
        if(gameboard[input_y-1, input_x-1] == '-'){
            gameboard[input_y-1, input_x-1] = 'o';
            break;
        }
        else{
            Console.WriteLine("Fel input, testa igen");
        }
    }
}


void Gameboard_Load(char[,] gb){
    for (int i = 0; i < gb.GetLength(0); i++)
    {
        for (int j = 0; j < gb.GetLength(1); j++)
        {
            if( i == 0){
                if( j == 2){
                    Console.WriteLine(gb[i, j] + " ");
                } else {
                    Console.Write(gb[i, j] + " ");
                }
            }
            else if ( i == 1){
                if ( j == 2){
                    Console.WriteLine(gb[i, j] + " ");
                } else {
                    Console.Write(gb[i, j] + " ");
                }
            }
            else if ( i == 2){
                if ( j == 2){
                    Console.WriteLine(gb[i, j] + " ");
                } else{
                    Console.Write(gb[i, j] + " ");
                }
            }
            
            
        }
    }
}

void Slut(){
    for (int i = 0; i < 3; i++)
    {
        if (gameboard[i, 0] == 'x' && gameboard[i, 1] == 'x' && gameboard[i, 2] == 'x' || 
            gameboard[0, i] == 'x' && gameboard[1, i] == 'x' && gameboard[2, i] == 'x' ||
            gameboard[0, 0] == 'x' && gameboard[1, 1] == 'x' && gameboard[2, 2] == 'x' ||
            gameboard[2, 0] == 'x' && gameboard[1, 1] == 'x' && gameboard[0, 2] == 'x') {
            Console.WriteLine("Spelare 1 vann!!");
            Reset();
            p1++;
        } else if  (gameboard[i, 0] == 'o' && gameboard[i, 1] == 'o' && gameboard[i, 2] == 'o' || 
                    gameboard[0, i] == 'o' && gameboard[1, i] == 'o' && gameboard[2, i] == 'o' ||
                    gameboard[0, 0] == 'o' && gameboard[1, 1] == 'o' && gameboard[2, 2] == 'o' ||
                    gameboard[2, 0] == 'o' && gameboard[1, 1] == 'o' && gameboard[0, 2] == 'o') {
                        Console.WriteLine("Spelare 2 vann!!");
                        Reset();
                        p2++;
                    }
                    else if (gameboard[0, 0] != '-' && gameboard[1, 0] != '-' && gameboard[2, 0] != '-' && 
                            gameboard[0, 1] != '-' && gameboard[1, 1] != '-' && gameboard[2, 1] != '-' &&
                            gameboard[0, 2] != '-' && gameboard[1, 2] != '-' && gameboard[2, 2] != '-'){
                                Console.Write("Det blev lika");
                                p1 += 0.5;
                                p2 += 0.5;
                                Reset();
                                break;
                    }
    }
}

void Reset(){
    if(p1 > 0 || p2>0){
        Console.WriteLine("\n" + "Ställningen är: " + p1 + ':' + p2 + "\n");
        rundor++;}
    gameboard = new char[,]{
    {'-', '-', '-'}, 
    {'-', '-', '-'}, 
    {'-', '-', '-'}};
}
    
