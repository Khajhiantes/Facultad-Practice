// See https://aka.ms/new-console-template for more information

using TaskManagement;

SystemTask sys = new SystemTask(10);
bool action = true;
Console.WriteLine("Welcome to the system Task");
while (action)
{
    Console.WriteLine("Select your choice ");
    Console.WriteLine("1. Add Task\n2.Mark task as completed\n3.Delete task\n4.View all tasks \n5.Exit");
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        continue;
    }
    switch (choice)
    {
        case 1:
            Tasks task = new Tasks();
            Console.WriteLine("Enter the title of the task:");
            task.title = Console.ReadLine();
            Console.WriteLine("Enter the description of the task:");
            task.description = Console.ReadLine();
            sys.AddTask(task);
            break;
        case 2:
            Console.WriteLine("Introduce the number of task to completed ");
            if(TryParseTaskNumber( out int ntask))
            {
                sys.markTask(ntask-1);
            }
            break;
        case 3:
            Console.WriteLine("Enter the number to delete: ");
            if (TryParseTaskNumber( out int ndelete))
            {
                sys.deleteTask(ndelete - 1);
            }
            break;
        case 4:
            sys.showTasks();
            break;
        case 5:
            action = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            break;
    }
}
Console.WriteLine("Goodbye!");
bool TryParseTaskNumber(out int taskNumber)
{
    if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
        return false;
    }
}


