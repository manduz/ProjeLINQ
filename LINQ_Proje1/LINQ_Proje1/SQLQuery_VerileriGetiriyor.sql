--burada yazýp vs studio da alacaðýz


select o.CustomerID,o.EmployeeID, o.OrderID, o.OrderDate,
(select ContactName from Customers where CustomerID = o.CustomerID) 
as ContactName

from Orders o

---customers tabloda ve orders tablodaki customerID ler eþit olanalrý al


