--burada yaz�p vs studio da alaca��z


select o.CustomerID,o.EmployeeID, o.OrderID, o.OrderDate,
(select ContactName from Customers where CustomerID = o.CustomerID) 
as ContactName

from Orders o

---customers tabloda ve orders tablodaki customerID ler e�it olanalr� al


