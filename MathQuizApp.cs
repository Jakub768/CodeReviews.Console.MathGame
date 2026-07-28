public class MathQuizApp
{
    public UserGameInteract _interact;

    public MathQuizApp(UserGameInteract interact)
    {
        _interact = interact;
    }

    public void Run()
    {
        UserGameInteract interact = new UserGameInteract();
        Operation chosenOp;

        Menu m = interact.PromptMenu();

        switch (m)
        {
            case Menu.History:
                Console.WriteLine("no");
                break;
            case Menu.Play: 
                chosenOp = interact.PromptOperation();
                break;
            case Menu.Exit:
                Environment.Exit(1);
                break;
        }
    }
}