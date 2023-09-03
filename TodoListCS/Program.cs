void Welcome()
{
    string programName = @"
░█████╗░██╗░░░░░██╗░██████╗████████╗
██╔══██╗██║░░░░░██║██╔════╝╚══██╔══╝
██║░░╚═╝██║░░░░░██║╚█████╗░░░░██║░░░
██║░░██╗██║░░░░░██║░╚═══██╗░░░██║░░░
╚█████╔╝███████╗██║██████╔╝░░░██║░░░
░╚════╝░╚══════╝╚═╝╚═════╝░░░░╚═╝░░░";
    string welcomeMessage = "Bem-vindo ao CLIST";

    Console.WriteLine(programName);
    Console.WriteLine();
}

void MenuOptions()
{
    Console.WriteLine("Digite 1 para cadastrar uma tarefa:");
    Console.WriteLine("Digite 2 para mostrar todas as suas tarefas:");
    Console.WriteLine("Digite 3 para concluir uma tarefa:");
    Console.WriteLine("Digite 4 para excluir uma tarefa:");
}

Welcome();
MenuOptions();