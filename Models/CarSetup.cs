using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1parcfermeoptimizer.Models
{
    public class CarSetup
    {
        // Aerodynamic settings
        public double FrontWingLeft { get; set; }
        public double FrontWingRight { get; set; }
        public double RearWing { get; set; }

        public CarSetup() 
        {
            FrontWingLeft = 5; // Default value
            FrontWingRight = 5; // Default value
            RearWing = 5; // Default value
        }

    }
}
