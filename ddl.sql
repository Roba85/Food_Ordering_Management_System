create database Food_Ordering_System;

CREATE TABLE Branches
(
  branch_id INT NOT NULL IDENTITY(1,1),
  location VARCHAR(255) NOT NULL,
  PRIMARY KEY (branch_id)
);

CREATE TABLE Customer
(
  customer_id INT IDENTITY(1,1) NOT NULL,
  email VARCHAR(255) NOT NULL UNIQUE,
  password VARCHAR(255) NOT NULL,
  address VARCHAR(255) NOT NULL,
  customer_name VARCHAR(255) NOT NULL,
  PRIMARY KEY (customer_id)
);

CREATE TABLE Customer_phones
(
  phone VARCHAR(15) NOT NULL,
  customer_id INT NOT NULL,
  PRIMARY KEY (phone, customer_id),
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_id)
);

CREATE TABLE Admin
(
  admin_id INT NOT NULL IDENTITY(1,1),
  admin_name VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL UNIQUE,
  password VARCHAR(255) NOT NULL,
  branch_id INT NOT NULL,
  PRIMARY KEY (admin_id),
  FOREIGN KEY (branch_id) REFERENCES Branches(branch_id)
);

CREATE TABLE Menu_items
(
  meal_id INT NOT NULL IDENTITY(1,1),
  category VARCHAR(50) NOT NULL,
  season VARCHAR(50) NOT NULL,
  is_available CHAR(1) NOT NULL,  -- 'Y' or 'N'
  price REAL NOT NULL,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(500) NOT NULL,
  admin_id INT NOT NULL,
  PRIMARY KEY (meal_id),
  FOREIGN KEY (admin_id) REFERENCES Admin(admin_id)
);


CREATE TABLE customer_favorites
(
  customer_id INT NOT NULL,
  meal_id INT NOT NULL,
  PRIMARY KEY (customer_id, meal_id),
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_id),
  FOREIGN KEY (meal_id) REFERENCES Menu_items(meal_id)
);



CREATE TABLE Order_
(
  order_id INT NOT NULL IDENTITY(1,1),
  date DATE NOT NULL,
  total REAL NOT NULL,
  tax REAL NOT NULL,
  payment_method VARCHAR(50) NOT NULL,
  sub_total FLOAT NOT NULL,
  branch_id INT NOT NULL,
  customer_id INT NOT NULL,
  PRIMARY KEY (order_id),
  FOREIGN KEY (branch_id) REFERENCES Branches(branch_id),
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_id)
);


CREATE TABLE Feedback
(
  feedback_id INT NOT NULL IDENTITY(1,1),
  data VARCHAR(255) NOT NULL,
  rate INT NOT NULL,
  review VARCHAR(500) NOT NULL,
  customer_id INT NOT NULL,
  PRIMARY KEY (feedback_id),
  FOREIGN KEY (customer_id) REFERENCES Customer(customer_id)
);




CREATE TABLE Order_items
(
  Quantity INT NOT NULL,
  product_total REAL NOT NULL,
  order_id INT NOT NULL,
  meal_id INT NOT NULL,
  PRIMARY KEY (order_id, meal_id),
  FOREIGN KEY (order_id) REFERENCES Order_(order_id),
  FOREIGN KEY (meal_id) REFERENCES Menu_items(meal_id)
);

=================       Test          ===================

INSERT INTO Branches (location)
VALUES ('Downtown');


INSERT INTO Customer (email, password, address, customer_name)
VALUES ('customer@example.com', 'password123', '123 Street, City', 'Ahmed Ali');


insert into Admin(admin_name,email,password,branch_id)
VALUES('ahmed','admin@example.com','password123',1);


INSERT INTO Menu_items (category, season, is_available, price, name, description, admin_id)
VALUES ('Main Course', 'Winter', 'Y', 10.99, 'Pizza', 'Delicious cheese pizza', 1);


INSERT INTO Order_ (date, total, tax, payment_method, sub_total, branch_id, customer_id)
VALUES ('2025-05-16', 15.00, 1.50, 'Credit Card', 13.50, 1, 1);



INSERT INTO Feedback (data, rate, review, customer_id)
VALUES ('2025-05-16', 5, 'Great food!', 1);


INSERT INTO Order_items (Quantity, product_total, order_id, meal_id)
VALUES (1, 10.99, 1, 1);  -- 1 Pizza ordered