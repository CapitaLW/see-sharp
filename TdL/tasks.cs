// to do list

public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public Task(int id, string description, DateTime dueDate)
    {
        Id = id;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"Task #{Id}: {Description} (Due: {DueDate.ToShortDateString()}) {(IsCompleted ? "[Completed]" : "")}";
    }
}


class Program
{
    static List<Task> tasks = new List<Task>();
    static int taskIdCounter = 1;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the To-Do List App!");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
    
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        Console.Write("Enter due date (MM/DD/YYYY): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());
        tasks.Add(new Task(taskIdCounter++, description, dueDate));
        Console.WriteLine("Task added successfully!");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        Console.WriteLine("Tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    static void MarkTaskAsCompleted()
    {
        Console.Write("Enter task ID to mark as completed: ");
        int taskId = int.Parse(Console.ReadLine());
        Task task = tasks.Find(t => t.Id == taskId);
        if (task != null)
        {
            task.MarkAsCompleted();
            Console.WriteLine("Task marked as completed.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }
}