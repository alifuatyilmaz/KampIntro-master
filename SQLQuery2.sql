select ContactName Adi ,CompanyName SirketAdi,City Sehir from Customers

select * from Customers where City = 'London'

select * from Customers where Country = 'USA'

select * from Products where CategoryID = 1;

select * from Products where CategoryID = 1 or CategoryID = 3;

select * from Products where CategoryID = 1 and UnitPrice > 10;

select * from Products order by UnitPrice desc -- Büyükten küçüğe sıralar

select * from Products order by CategoryID,ProductID --CategoryID'ye göre sıralar.Sonra kendi içinde ProductID'ye göre sıralar.

select * from Products order by CategoryID,ProductID desc --Tersten sıralar (ascending , descending)

select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*) from Products -- Products tablosunda kaç satır olduğunu listeler.

select count(*) from Products where CategoryID = 2 -- Products tablosunda CategoryyID'si 2 olan kaç satır olduğunu listeler.

select categoryID,count(*) from Products group by CategoryID -- Hangi categoryID'de kaç adet olduğunu gösterir.

select categoryID,count(*) from Products group by CategoryID having count(*)<10 -- Ürün sayısı 10 dan az olan category'leri listele

select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 -- UnitPrice'ı 20 den fazla olanları ve ürün sayısı 10 dan az olan category'leri listele

select *
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID -- Inner Join ile 2 tabloyu birleştirdik. CategoryID'leri eşit olan satırların tüm bilgilerini getirdi.
--Hem Products hemde Categories tablosundan verileri aldık.

select Products.ProductID , Products.ProductName , Products.UnitPrice , Categories.CategoryName -- Herhangi tablodan istediğimiz bilgileri getirebiliriz.
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID , Products.ProductName , Products.UnitPrice , Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

select * from Products p inner join [Order Details] od  -- Inner join sadece iki tabloda eşleşen kayıtları getirir.
on p.ProductID = od.ProductID

select * from Products p left join [Order Details] od  -- Eşleşmeyenleride getirmek için left veyaright join kullan.
on p.ProductID = od.ProductID

select * from Customers c inner join Orders o  -- 830 kayıt
on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o  -- 832 kayıt. Solda olup sağda olmayan kayıtları getirir.
on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o  -- 2 kayıt
on c.CustomerID = o.CustomerID where o.CustomerID is null

select * from Customers c right join Orders o  -- 832 kayıt. Sağda olup solda olmayan kayıtları getirir.
on c.CustomerID = o.CustomerID

select * from Products p inner join [Order Details] od  -- Inner joinle birden fazla tabloyu eşleştirme.
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID