using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly List<IWorkflowAcitiviy> _wrkflwActivity;

        public Workflow()
        {
            _wrkflwActivity = new List<IWorkflowAcitiviy>();
        }

        public void SetActivities(IWorkflowAcitiviy activity)
        {
            if (activity is null)
                throw new InvalidOperationException("Activity cannot be null or empty");

            _wrkflwActivity.Add(activity);
        }

        public IEnumerable<IWorkflowAcitiviy> GetWorkflowActivities()
        {
            return _wrkflwActivity;
        }
    }
}
