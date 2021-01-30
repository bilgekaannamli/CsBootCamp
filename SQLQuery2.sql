--Select
Select * from Customers
--Sınırlandırma
--ANSI olduğu için tek tırnak
Select * from Customers where City = 'London'
--case insensitive/Büyük ve küçük harf duyarlılığı yok
select * from Products where CategoryID = 1 or CategoryID = 3
--<> farklı olan demek
Select * from Products where CategoryID = 1 and UnitPrice<>10
--önce ilk yazılına göre, sonra onun içerisinde ikinci yazılana göre sıralar
Select * from Products order by CategoryID, ProductName
--Büyükten küçüğe
Select * from Products order by UnitPrice desc --default: asc
Select * from Products where CategoryID = 1 order by UnitPrice desc
--Satır saydırma
Select COUNT(*) from Products where CategoryID = 2
--Gruplayarak saydırma
Select COUNT(*) from Products group by CategoryID
--Gruplayarak listeleme
Select CategoryID from Products group by CategoryID
Select CategoryID, COUNT(*) "Count" from Products group by CategoryID
--Say ve satır sayısı 10'dan küçük olanları listele
Select CategoryID, COUNT(*) "Count" from Products group by CategoryID having COUNT(*)<10
Select CategoryID, COUNT(*) "Count"--, Products.UnitPrice
from Products 
where UnitPrice>20
group by CategoryID 
having COUNT(*)<10


--Burada "join" bir DTO: Data Transformation Object
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID


Select * from [Order Details]

--Select *
--from Products p inner join [Order Details] od
--on p.ProductID = od.ProductID

Select *
from Customers c inner join Orders o
on c.CustomerID = o.CustomerID

Select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID

--Burada itibaren tekrar izle
--Baştaki excel kısmını da tekrar izle
--ANSI standartlarında SQL öğrendik
--"is null" PK'e uygulanır: Orders'ın PK CustomerID'deki boşları arar. 
Select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null