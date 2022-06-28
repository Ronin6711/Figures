CREATE TABLE Products (
	ID INT PRIMARY KEY,
	"NameProduct" nvarchar(255)
);

INSERT INTO Products
VALUES
	(1, 'BMW'),
	(2, 'Bentley'),
	(3, 'Altair'),
	(4, 'Audi'),
	(5, 'Black One'),
	(6, 'Bianchi');

CREATE TABLE Categories (
	ID INT PRIMARY KEY,
	"NameCategories" nvarchar(255)
);

INSERT INTO Categories
VALUES
	(1, 'Car'),
	(2, 'Bike'),
	(3, 'Electric');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(ID),
	CategoryId INT FOREIGN KEY REFERENCES Categories(ID),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 3),
	(2, 1),
	(3, 2),
	(3, 3),
	(4, 1),
	(5, 2);

Select p."NameProduct", c."NameCategories"
From Products p
left join ProductCategories pc on p.ID = pc.ProductId
left join Categories c on pc.CategoryId = c.ID