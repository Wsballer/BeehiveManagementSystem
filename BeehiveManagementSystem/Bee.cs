using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class Bee
    {
        public Bee(string job)
        {
            Job = job;
        }

        public string Job { get; private set; }

        public virtual float CostPerShift { get; }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected virtual void DoJob() { /* the subclass overrides this */ }
    }
}
