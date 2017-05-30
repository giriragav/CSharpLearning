using System;

namespace WorkflowEngine
{
    public class Acitivity2 : IWorkflowAcitiviy
    {
        public void Execute()
        {
            Console.WriteLine("Performing Activity 2");
        }
    }
}
