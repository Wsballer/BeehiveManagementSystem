using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class EggCare : Bee
    {
        float costPerShift = 1.35f;
        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;
        private Queen queen;

        public override float CostPerShift => costPerShift;

        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }

        public EggCare(Queen queen) : base("Egg Care")
        {
            this.queen = queen;
        }
    }
}
