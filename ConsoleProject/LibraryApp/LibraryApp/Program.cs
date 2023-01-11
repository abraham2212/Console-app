



while (true)
{
    GetOptions();
   Option: string option = Console.ReadLine();
    int selecedOption;
    bool isCorrectOption = int.TryParse(option, out selecedOption);

    if (isCorrectOption)
    {
        switch (selecedOption)
        {
            case 1:
                Console.WriteLine("create");
                break;
            case 2:
                Console.WriteLine("get all");
                break;
            case 3:
                Console.WriteLine("delete");
                break;

            default:
                ConsoleColor.Red.WriteConsole("add correct options")
                goto Option;
        }
    }
    else
    {


        ConsoleColor.Red.WriteConsole("add correct options")
                goto Option;
    }






}

static void GetOptions()
{
    ConsoleColor.Cyan.WriteConsole("please select one option");
    ConsoleColor.Cyan.WriteConsole("Liberary options:1- Create,2-Get all, 3");
}