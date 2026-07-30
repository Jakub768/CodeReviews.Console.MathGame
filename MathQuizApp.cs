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
        Operation chosenOp;
        bool endApp = false;

        while (!endApp)
        {
            Menu m = _interact.PromptMenu();
            switch (m)
            {
                case Menu.History:
                    _choiceHandler.displayHistory();
                    break;
                case Menu.Play: 
                    chosenOp = _interact.PromptOperation();
                    _choiceHandler.initGame(chosenOp);
                    break;
                case Menu.Exit:
                    endApp = true;
                    break;
            }
        }
    }
}