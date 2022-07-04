using OOP2;


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.FirstName = "Abdulkadir";
customer1.LastName = "Parlak";
customer1.CustomerId = "12345";
customer1.TcId = "123234123";

CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.TaxId = "1234567890";
customer2.CompanyName = "Kodlama.io";
customer2.CustomerId = "54321";

Customer customer3 = new CoorporateCustomer();
Customer customer4 = new IndividualCustomer();


CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);

//Gerçek Müşteri - Tüzel Müşteri
//SOLID

