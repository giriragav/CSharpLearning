using System;

namespace WorkflowEngine
{
    public class Acitivity1 : IWorkflowAcitiviy
    {
        public void Execute()
        {
            Console.WriteLine("Performing Activity 1");
        }
    }
}
