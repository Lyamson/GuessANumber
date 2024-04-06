Random rnd = new Random();
int number = rnd.Next(0, 101);

int guess = -1;
do{
    do {
        Console.Write("Your guess: ");
    } while (!int.TryParse(Console.ReadLine(), out guess));
    if (number > guess) {
        Console.WriteLine("Higher");
    }
    else if(number < guess){
        Console.WriteLine("Lower");
    }
} while (guess != number);

Console.WriteLine("Congrats!");