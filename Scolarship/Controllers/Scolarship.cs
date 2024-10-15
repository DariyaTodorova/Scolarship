using System;
using Scolarship.Model;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Runtime.CompilerServices;
using Scolarship.View;

namespace Scolarship.Controllers
{

    public class Scolarship
    {

        Display disp = new Display();
        ScolarshipView myScol = new ScolarshipView();
        public Scolarship()
        {
            disp.Input();

            myScol.Income = disp.Income;
            myScol.AverageGrade = disp.AverageGrade;

            disp.Income = myScol.GetValidatedIncome();
            disp.AverageGrade = myScol.GetValidatedAverageGrade();
            disp.MinWage = myScol.GetValidatedMinimumWage();


        }

    }
}
