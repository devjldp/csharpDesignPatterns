using System;

namespace Composite{

    // This is a  structural design pattern
    // Imagine we have a big task such as make breakfast and small task: make coffee, make toast...
    // Give an input and the factory returns an object
    // two terms (Imagine a tree)
    // * leaf: It is a single item
    // * composite: It is the branch

    public interface Task{
        public void Do();
    }
    public class TaskLeaf : Task
    {
        public string description;

        public TaskLeaf(string description)
        {
            this.description = description;
        }
        public void Do()
        {
            Console.WriteLine($"Task completed: {description}");
        }
    }

    public class TaskComposite : Task
    {
        List<Task> tasks;
        public string description;

        public TaskComposite(string description){
            this.description = description;
            this.tasks = new List<Task>();
        }
        public void Do()
        {
            Console.WriteLine($"Task start: {description}");
            foreach (Task task in tasks)
            {
                task.Do();
            }
            Console.WriteLine($"Task ended: {description}");
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
    }





}
