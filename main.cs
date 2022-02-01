using System;


class Program {
  public static void Main (string[] args) {
    
    int guesses = 8;
    string[] wordList = {"broke", "death", "forks", "magic", "beast", "force", "flips", "bolts", "brain", "their", "ghost", "holds", "eight", "ducks", "black", "white", "great", "under", "stand", "flies", "break", "horse", "teach", "zones", "cards", "heart", "locks", "jumps", "block", "fault", "rocks", "quips", "races", "mount", "mould", "vault", "hates", "pouty", "reads", "bonds", "right", "wrong", "fable", "eater", "golem", "hoard"}; 
    Random rnd = new Random();
      int choice = rnd.Next(0,wordList.Length);
      string wordSelected = wordList[choice];

    Console.WriteLine("Welcome to the Realm. The rules are as follows. You must enter a five letter word. Each letter will be different, so do not enter the same letter twice. You will be told whether a letter is correct, or if a letter is in the word. If you do not get it correct, you will be... B A N I S H E D . Good luck. You'll need it.");
    while (guesses > 0){
      Console.WriteLine("Enter a word:" );
      string guess = Console.ReadLine();
      if (guess.Length != 5){
        Console.WriteLine("The number of letters in this word is 5. Please retry.");
      }else{
      //These identify whether or not the letters are in the word
      if (guess[0]==wordSelected[0]){
        Console.WriteLine("You got the first letter in the right place.");
      }else if(wordSelected.IndexOf(guess[0])>-1){
        Console.WriteLine("The first letter is in the word, but is in the wrong place.");
      }

      if (guess[1]==wordSelected[1]){
        Console.WriteLine("You got the second letter in the right place.");
      }else if(wordSelected.IndexOf(guess[1])>-1){
        Console.WriteLine("The second letter is in the word, but is in the wrong place.");
      }

      if (guess[2]==wordSelected[2]){
        Console.WriteLine("You got the third letter in the right place.");
      }else if(wordSelected.IndexOf(guess[2])>-1){
        Console.WriteLine("The third letter is in the word, but is in the wrong place.");
      }

      if (guess[3]==wordSelected[3]){
        Console.WriteLine("You got the fourth letter in the right place.");
      }else if(wordSelected.IndexOf(guess[3])>-1){
        Console.WriteLine("The fourth letter is in the word, but is in the wrong place.");
      }

      if (guess[4]==wordSelected[4]){
        Console.WriteLine("You got the fifth letter in the right place.");
      }else if(wordSelected.IndexOf(guess[4])>-1){
        Console.WriteLine("The fifth letter is in the word, but is in the wrong place.");
      }
      if (guess==wordSelected){
        Console.WriteLine("Congratulations! You got it correct. You live for another day.");
        break;
      }
      guesses--;
    }
    if (guesses==0){
      Console.WriteLine("You have failed to establish the word. To the Shadow Realm you go, until you are ready to try again. The word for this round was:");
      Console.WriteLine(wordSelected);
    }
  }
}
}