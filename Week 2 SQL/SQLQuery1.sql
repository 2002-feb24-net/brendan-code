select firstname, lastname, customerid, country from customer where Country != 'US';
--2
select firstname, lastname, customerid, country from customer where country = 'Brazil';
--3
select * from Employee where title = 'sales support agent';
--4
select BillingCountry
from Invoice
GROUP BY BillingCountry;
select * from Invoice;
--5
select count(InvoiceId), sum(Total)
from Invoice
where Year(InvoiceDate) = '2009'; OR

Select count(*), SUM(Total) As Total
FROM Invoice
Where Year(InvoiceDate) = 2009;
--6
select count(customerId)
from invoice
where CustomerId = 37;
--7
select BillingCountry, Total
from Invoice
where Total > 0
Order By Total DESC;
--8
SELECT *
FROM Invoice;
SELECT SUM(Total), BillingCountry
From Invoice
Group By BillingCountry
Order By Sum(Total) desc;
--9 Insert into table_name (column1, column2, column3,...)
--values (value1, value2, value3,...)
Select * from Employee;
Insert Into Employee (EmployeeId, LastName, FirstName, Title)
Values (100, 'Moore', 'Mark', 'Teacher');

Select * from Employee
Where EmployeeId = 100;