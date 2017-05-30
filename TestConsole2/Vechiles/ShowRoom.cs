using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechiles
{
    public class ShowRoom
    {
        public void TryVechiles(List<MotorVechicle> vechiles)
        {
            foreach(MotorVechicle vechile in vechiles)
            {
                vechile.TestDrive();
            }
        }
    }
}
