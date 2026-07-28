public class UserGameInteract
{
    public Menu PromptMenu()
    {
        Console.WriteLine("Welcome to Math quiz game! Please enter the choice:");

        for(int i = 0; i < Enum.GetNames(typeof(Menu)).Length; i++)
        {
            Console.WriteLine($"{i}: {Enum.GetName(typeof(Menu), i)}");
        }
    }

    public Operation PromptOperation()
    {
        Console.WriteLine("Please enter which operation you would like to have: ");

        for (int i = 0; i < Enum.GetNames(typeof(Operation)).Length; i++)
        {
            Console.WriteLine($"{i}: {Enum.GetName(typeof(Operation), i)}");
        }
    }


}