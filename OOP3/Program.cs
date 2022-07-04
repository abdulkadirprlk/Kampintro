using OOP3;
using System.Collections.Generic;

ICreditManager consumerLoanManager = new ConsumerLoanManager();
ICreditManager vehicleLoanManager = new VehicleLoanManager();
ICreditManager mortgageLoanManager = new MortgageLoanManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.MakeApplication(mortgageLoanManager,databaseLoggerService); 

List<ICreditManager> credits = new List<ICreditManager>() {consumerLoanManager ,vehicleLoanManager};

//applicationManager.MakeALoanPreInformation(credits);

