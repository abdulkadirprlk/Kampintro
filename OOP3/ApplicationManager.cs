using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method injection
        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService )
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Calculate();
            loggerService.Log();
        }

        public void MakeALoanPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
