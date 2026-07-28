public class MathQuizApp
{
    public UserGameInteract _interact;
    public HandleUserChoice _choiceHandler;

    public MathQuizApp(UserGameInteract interact, HandleUserChoice choiceHandler)
    {
        _interact = interact;
        _choiceHandler = choiceHandler;
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
                _choiceHandler.initGame(chosenOp);
                break;
            case Menu.Exit:
                Environment.Exit(1);
                break;
        }
    }
}