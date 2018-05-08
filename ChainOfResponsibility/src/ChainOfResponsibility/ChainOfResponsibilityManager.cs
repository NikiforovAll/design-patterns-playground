using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    public class ChainOfResponsibilityManager
    {
        private Dictionary<string, string> relationshipConfig;

        public ChainOfResponsibilityManager(Dictionary<string, string> relationshipConfig)
        {
            this.relationshipConfig = relationshipConfig;
        }
        public Approver CreateChainOfApprovers(List<Approver> approvers)
        {
            var configValues = relationshipConfig.Values;
            Approver mainApprover = approvers.First(el => !configValues.Contains(el.Id, StringComparer.InvariantCultureIgnoreCase));

            foreach (var approver in approvers)
            {
                if (relationshipConfig.TryGetValue(approver.Id, out string currentApproverId))
                {
                    var activeApprover = approvers.First(el => el.Id == currentApproverId);
                    if (activeApprover != null)
                    {
                        approver.SetSuccessor(activeApprover);
                    }
                }
            }

            return mainApprover;
        }
    }
}