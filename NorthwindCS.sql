-- Select -- 
SELECT ContactName Adi, CompanyName SirketAdi,City Sehir FROM Customers

SELECT * FROM Products WHERE CategoryID = 1 and UnitPrice > 10

-- ORDER BY Sıralama yapar ASC küçükten büyüğe, DESC büyükten küçüğe
-- ASC veya DESC yazılmadığı taktirde, varsayılan olarak (ASC) küçükten büyüğe sıralar
SELECT * FROM Products ORDER BY ProductName 


-- GROUP BY  -> COUNT(), MAX(), MIN(), SUM(), AVG()

-- Tablonun satır sayısını döndürür COUNT()
SELECT COUNT(*) Adet FROM Products 

SELECT COUNT(*) Adet FROM Products WHERE UnitsInStock > 15

-- Tablodaki tekrar eden kategorileri gruplayıp, hangi kategoride ne kadar ürün olduğunu yazdıran sorgu
-- Group by sorgusu Having' dir.
select CategoryID, count(*) Unit from Products group by CategoryID having  count(*) < 10

