using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("Ask me a question! Any question!");
    bool isTrue = MooseGetQuestion();

    while (isTrue == true)
    {
        Random r = new Random();
        int random = r.Next(0, 19);

        switch (random)
        {
            case 0:
                MooseSays("As I see it, yes.");
                break;
            case 1:
                MooseSays("Ask again later.");
                break;
            case 2:
                MooseSays("Better not tell you now.");
                break;
            case 3:
                MooseSays("Cannot predict now.");
                break;
            case 4:
                MooseSays("Concentrate and ask again.");
                break;
            case 5:
                MooseSays("Don’t count on it.");
                break;
            case 6:
                MooseSays("It is certain.");
                break;
            case 7:
                MooseSays("It is decidedly so.");
                break;
            case 8:
                MooseSays("Most likely.");
                break;
            case 9:
                MooseSays("My reply is no.");
                break;
            case 10:
                MooseSays("My sources say no.");
                break;
            case 11:
                MooseSays("Outlook not so good.");
                break;
            case 12:
                MooseSays("Outlook good.");
                break;
            case 13:
                MooseSays("Reply hazy, try again.");
                break;
            case 14:
                MooseSays("Signs point to yes.");
                break;
            case 15:
                MooseSays("Very doubtful.");
                break;
            case 16:
                MooseSays("Without a doubt.");
                break;
            case 17:
                MooseSays("Yes.");
                break;
            case 18:
                MooseSays("Yes – definitely.");
                break;
            case 19:
                MooseSays("You may rely on it.");
                break;
            default:
                MooseSays("Error!");
                break;
        }

        isTrue = MooseGetQuestion();
    }
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

void MooseQuestion(string question, string positive, string negative)
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(positive);
    }
    else
    {
        MooseSays(negative);
    }
}

bool MooseGetQuestion()
{
    Console.Write($"Question: ");
    string answer = Console.ReadLine().ToLower();

    if (answer != "")
    {
        return true;
    }
    else
    {
        return false;
    }
}