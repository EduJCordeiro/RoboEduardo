using Robocode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboEduardo
{
    public class EduardoJRobot : Robot
    {
        public override void Run()
        {
            

            while(true)
            {
                Ahead(100);
                TurnLeft(40);
                Fire(3);
                
            }
        }
        
    }
}
