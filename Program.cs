using System;
using System.Collections.Generic;

Main();

void Main()
{


    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Ask some questions

    MooseSays("H I, I'm E N T H U S I A S T I C !");
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
    randomNumber();
    magicMoose();
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
//let the mosse speak!
// MooseSays("I really am enthusiastic");

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//ask a question

void mooseAskResponse(string question, string yes, string no)
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(yes);
    }
    else
    {
        MooseSays(no);
    }
}

void CanadaQuestion()
{
    mooseAskResponse("Is Canada real?", "Really? It seems very unlikely.", "I K N E W I T !!!");

    // bool isTrue = MooseAsks("Is Canada real?");
    // if (isTrue)
    // {
    //     MooseSays("Really? It seems very unlikely.");
    // }
    // else
    // {
    //     MooseSays(" I K N E W IT !!!");
    // }
}

void EnthusiasticQuestion()
{
    mooseAskResponse("Are you enthusiastic?", "Yay!", "You should try it!");

    // bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    // if (isEnthusiastic)
    // {
    //     MooseSays("Yay!");
    // }
    // else
    // {
    //     MooseSays("You should try it!");
    // }
}

void LoveCSharpQuestion()
{
    mooseAskResponse("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");

    // bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    // if (doesLoveCSharp)
    // {
    //     MooseSays("Good job sucking up to your instructor!");
    // }
    // else
    // {
    //     MooseSays("You will...oh, yes, you will...");
    // }
}

void SecretQuestion()
{
    mooseAskResponse("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");

    // bool wantsSecret = MooseAsks("Do you want to know a secret?");
    // if (wantsSecret)
    // {
    //     MooseSays("ME TOO!!!! I love secrets...tell me one!");
    // }
    // else
    // {
    //     MooseSays("Oh, no...secrets are the best, I love to share them!");
    // }
}


void randomNumber()
{
    Random r = new Random();
    int genRand = r.Next(0, 20);

    List<string> answer = new List<string>()
    {
        "As I see it, yes.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Don't count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes - definitely.",
        "You may rely on it."
    };
    MooseSays(answer[genRand]);
}

void magicMoose()
{

    while (true)
    {
        MooseSays("What is your question?");
        string question = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(question))
        {
            MooseSays("Fine, don't ask a question");
            break;
        }
        else
        {
            randomNumber();
        }
    }
}