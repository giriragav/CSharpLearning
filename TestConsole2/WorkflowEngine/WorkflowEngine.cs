using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        
        public void ExecuteTasks(IWorkflow workflow)
        {
            foreach (IWorkflowAcitiviy activity in workflow.GetWorkflowActivities())
                activity.Execute();
        }



    }
}
