create database DBAdvertisement

use DBAdvertisement

CREATE TABLE Users
(
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    RegistrationDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE Categories
(
    CategoryID INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(50) NOT NULL
);


CREATE TABLE Advertisements
(
    AdvertisementID INT PRIMARY KEY IDENTITY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    Title NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Price DECIMAL(10,2),
    PostDate DATETIME DEFAULT GETDATE()
);

-- Створення 5 користувачів
INSERT INTO Users (Username, Password) VALUES ('User', '123');
INSERT INTO Users (Username, Password) VALUES ('Slava', 'Password2');
INSERT INTO Users (Username, Password) VALUES ('Orel', 'Password3');
INSERT INTO Users (Username, Password) VALUES ('Max', 'Password4');
INSERT INTO Users (Username, Password) VALUES ('Oleg', 'Password5');


-- Додавання 10 категорій
INSERT INTO Categories (CategoryName) VALUES ('Automobiles');
INSERT INTO Categories (CategoryName) VALUES ('Real Estate');
INSERT INTO Categories (CategoryName) VALUES ('Electronics');
INSERT INTO Categories (CategoryName) VALUES ('Furniture');
INSERT INTO Categories (CategoryName) VALUES ('Jobs');
INSERT INTO Categories (CategoryName) VALUES ('Services');
INSERT INTO Categories (CategoryName) VALUES ('Pets');
INSERT INTO Categories (CategoryName) VALUES ('Fashion');
INSERT INTO Categories (CategoryName) VALUES ('Books');
INSERT INTO Categories (CategoryName) VALUES ('Sporting Goods');

-- Додавання 20 оголошень (
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (1, 1, 'Used 2019 Honda Civic', 'In excellent condition, mileage: 20000km', 15000);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (2, 1, '2022 BMW X5', 'Brand new with premium package', 60000);

INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (3, 2, 'Luxury Apartment in Downtown', '3 BHK, 2000 sq ft', 250000);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (4, 2, 'Vacant Land for Sale', '5000 sq ft', 100000);

-- Electronics
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (5, 3, 'Apple iPhone 12', 'Used, in good condition, 64GB, Blue', 700);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (1, 3, 'Samsung Smart TV', 'Brand new, 55 inches, 4K UHD', 600);

-- Furniture
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (2, 4, 'Leather Sofa Set', '3+1+1, Brown, Used', 800);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (3, 4, 'Dining Table', 'Brand new, 6-seater, Oak Wood', 1200);

-- Jobs
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (4, 5, 'Web Developer Needed', '3+ years experience, proficient in JavaScript', 5000);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (5, 5, 'Graphic Designer', 'Experienced in Adobe Suite, Part time job', 2000);

-- Services
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (1, 6, 'Home Cleaning Service', 'Professional cleaning, using safe chemicals', 100);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (2, 6, 'Math Tutor', 'Experienced Math tutor for grades 5-10', 20);

-- Pets
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (3, 7, 'Golden Retriever Puppies', 'Healthy and vaccinated, 2 months old', 800);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (4, 7, 'Fish Tank', '50-gallon tank, with LED lights', 200);

-- Fashion
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (5, 8, 'Levi’s Jeans', 'Brand new, size 32, Dark Blue', 50);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (1, 8, 'Nike Running Shoes', 'Used, size 10, Black', 70);

-- Books
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (2, 9, 'Harry Potter Set', 'Complete set, used, in good condition', 120);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (3, 9, 'Kindle Paperwhite', 'Used, good condition, with cover', 80);

-- Sporting Goods
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (4, 10, 'Treadmill', 'Used, fully functional, Brand: Lifespan', 300);
INSERT INTO Advertisements (UserID, CategoryID, Title, Description, Price) VALUES (5, 10, 'Mountain Bike', 'Brand new, 18 speed, Brand: Trek', 600);

select * from Advertisements