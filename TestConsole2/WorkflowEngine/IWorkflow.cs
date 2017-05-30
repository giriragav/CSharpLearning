using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void SetActivities(IWorkflowAcitiviy activity);
        IEnumerable<IWorkflowAcitiviy> GetWorkflowActivities();
    }
}
