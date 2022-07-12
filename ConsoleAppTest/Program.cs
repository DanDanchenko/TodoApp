using Back_endPart;
using Back_endPart.Infrastructure;
using Back_endPart.Models;

TaskRepository context = new TaskRepository();
Back_endPart.Task task1 = new Back_endPart.Task();

task1.Id = 1;
task1.Title = "Курсова";
task1.Priority = Priorities.Heigh;
task1.DeadLineDate = DateTime.Now;
task1.Description = "Написати курсову роботу";
task1.IsCompleted = false;
context.Add(task1);
context.Save();

Back_endPart.Task task2 = new Back_endPart.Task();

task2.Id = 2;
task2.Title = "прибирання";
task2.Priority = Priorities.Medium;
task2.DeadLineDate = DateTime.Now;
task2.Description = "Прибрати квартиру";
task2.IsCompleted = false;
context.Add(task2);
context.Save();

Back_endPart.Task task3 = new Back_endPart.Task();

task3.Id = 3;
task3.Title = "Сесія";
task3.Priority = Priorities.Heigh;
task3.DeadLineDate = DateTime.Now;
task3.Description = "Закрити всі предмети";
task3.IsCompleted = false;
context.Add(task3);
context.Save();

Back_endPart.Task task4 = new Back_endPart.Task();

task4.Id = 4;
task4.Title = "Гра";
task4.Priority = Priorities.Low;
task4.DeadLineDate = DateTime.Now;
task4.Description = "Вдосконалити геймплей";
task4.IsCompleted = false;
context.Add(task4);
context.Save();

Back_endPart.Task task5 = new Back_endPart.Task();

task5.Id = 5;
task5.Title = "Алгоритми";
task5.Priority = Priorities.Medium;
task5.DeadLineDate = DateTime.Now;
task5.Description = "Виконати задачу з теорії алгоритмів";
task5.IsCompleted = false;
context.Add(task5);
context.Save(); 


/*foreach (Back_endPart.Task task in context.GetTasksList())
{
    Console.WriteLine(task.Title + " " + task.Description);
}*/


//Console.WriteLine(context.GetTask(0).Title + " " + context.GetTask(2).Description);
//Console.WriteLine(context.GetTask(2).Title + " " + context.GetTask(2).Description);

//context.Delete(7);
//context.Delete(5);
//context.Delete(3);
//context.Delete(4);

//context.DeleteAll();

//context.Save();







