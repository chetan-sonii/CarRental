-- ====================================================
-- 0. Create DB and use it
-- ====================================================
CREATE DATABASE IF NOT EXISTS db_car_rental
  CHARACTER SET = utf8mb4
  COLLATE = utf8mb4_unicode_ci;
USE db_car_rental;

-- ====================================================
-- 1. Create tables
-- ====================================================

-- 1.1 USERS (Admin)
CREATE TABLE IF NOT EXISTS tbl_users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 1.2 CARS (FIXED: Changed TINYINT to VARCHAR to match VB Code)
CREATE TABLE IF NOT EXISTS tbl_cars (
    reg_no VARCHAR(20) PRIMARY KEY,
    brand VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    available VARCHAR(10) NOT NULL DEFAULT 'Yes', -- Changed to store 'Yes'/'No'
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 1.3 CUSTOMERS
CREATE TABLE IF NOT EXISTS tbl_customers (
    cust_id INT AUTO_INCREMENT PRIMARY KEY,
    cust_name VARCHAR(100) NOT NULL,
    address VARCHAR(255),
    phone VARCHAR(20),
    email VARCHAR(100) UNIQUE,
    password VARCHAR(100) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 1.4 RENTALS
CREATE TABLE IF NOT EXISTS tbl_rentals (
    rent_id INT AUTO_INCREMENT PRIMARY KEY,
    car_reg VARCHAR(20),
    cust_id INT,
    rent_date DATE,
    return_date DATE,
    fees DECIMAL(10,2),
    status VARCHAR(20) DEFAULT 'Pending', -- Changed ENUM to VARCHAR for flexibility
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_rentals_car FOREIGN KEY (car_reg) REFERENCES tbl_cars (reg_no)
        ON DELETE SET NULL ON UPDATE CASCADE,
    CONSTRAINT fk_rentals_cust FOREIGN KEY (cust_id) REFERENCES tbl_customers (cust_id)
        ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ====================================================
-- 2. Seed data
-- ====================================================

SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE tbl_rentals;
TRUNCATE TABLE tbl_users;
TRUNCATE TABLE tbl_customers;
TRUNCATE TABLE tbl_cars;
SET FOREIGN_KEY_CHECKS = 1;

-- 2.1 Insert Admin
INSERT INTO tbl_users (username, password) VALUES ('admin', '1234');

-- 2.2 Insert Cars (Using 'Yes' instead of 1)
INSERT INTO tbl_cars (reg_no, brand, model, price, available) VALUES
('MH01-AB-1001', 'Toyota', 'Fortuner', 2500.00, 'Yes'),
('MH01-AB-1002', 'Toyota', 'Innova Crysta', 1800.00, 'Yes'),
('MH01-AB-1003', 'Toyota', 'Camry Hybrid', 3000.00, 'Yes'),
('MH01-AB-1004', 'Honda', 'City', 1200.00, 'Yes'),
('MH01-AB-1005', 'Honda', 'Civic', 1500.00, 'Yes'),
('MH01-AB-1006', 'Honda', 'Amaze', 900.00, 'Yes'),
('MH01-AB-1007', 'Hyundai', 'Creta', 1400.00, 'Yes'),
('MH01-AB-1008', 'Hyundai', 'Verna', 1300.00, 'Yes'),
('MH01-AB-1009', 'Hyundai', 'Tucson', 2200.00, 'Yes'),
('MH01-AB-1010', 'Maruti', 'Swift', 800.00, 'Yes'),
('MH01-AB-1011', 'Maruti', 'Baleno', 900.00, 'Yes'),
('MH01-AB-1012', 'Maruti', 'Brezza', 1100.00, 'Yes'),
('MH01-AB-1013', 'Tata', 'Nexon EV', 1600.00, 'Yes'),
('MH01-AB-1014', 'Tata', 'Harrier', 2000.00, 'Yes'),
('MH01-AB-1015', 'Tata', 'Safari', 2300.00, 'Yes'),
('MH01-AB-1016', 'Mahindra', 'XUV700', 2400.00, 'Yes'),
('MH01-AB-1017', 'Mahindra', 'Thar', 2100.00, 'Yes'),
('MH01-AB-1018', 'Mahindra', 'Scorpio-N', 1900.00, 'Yes'),
('MH01-AB-1019', 'Kia', 'Seltos', 1500.00, 'Yes'),
('MH01-AB-1020', 'Kia', 'Sonet', 1200.00, 'Yes'),
('MH01-AB-1021', 'BMW', '3 Series', 5000.00, 'Yes'),
('MH01-AB-1022', 'BMW', '5 Series', 7000.00, 'Yes'),
('MH01-AB-1023', 'BMW', 'X1', 5500.00, 'Yes'),
('MH01-AB-1024', 'Audi', 'A4', 4800.00, 'Yes'),
('MH01-AB-1025', 'Audi', 'Q3', 5200.00, 'Yes'),
('MH01-AB-1026', 'Audi', 'A6', 7200.00, 'Yes'),
('MH01-AB-1027', 'Mercedes', 'C-Class', 5100.00, 'Yes'),
('MH01-AB-1028', 'Mercedes', 'E-Class', 7500.00, 'Yes'),
('MH01-AB-1029', 'Mercedes', 'GLA', 5400.00, 'Yes'),
('MH01-AB-1030', 'Land Rover', 'Range Rover Evoque', 9000.00, 'Yes'),
('MH01-AB-1031', 'Land Rover', 'Discovery Sport', 8500.00, 'Yes'),
('MH01-AB-1032', 'Jaguar', 'XE', 6000.00, 'Yes'),
('MH01-AB-1033', 'Jaguar', 'F-Pace', 8800.00, 'Yes'),
('MH01-AB-1034', 'Volvo', 'XC40', 5300.00, 'Yes'),
('MH01-AB-1035', 'Volvo', 'XC60', 7100.00, 'Yes'),
('MH01-AB-1036', 'Tesla', 'Model 3', 6500.00, 'Yes'),
('MH01-AB-1037', 'Tesla', 'Model Y', 7000.00, 'Yes'),
('MH01-AB-1038', 'Ford', 'Mustang', 12000.00, 'Yes'),
('MH01-AB-1039', 'Ford', 'Endeavour', 2800.00, 'Yes'),
('MH01-AB-1040', 'Volkswagen', 'Virtus', 1400.00, 'Yes'),
('MH01-AB-1041', 'Volkswagen', 'Taigun', 1500.00, 'Yes'),
('MH01-AB-1042', 'Skoda', 'Slavia', 1450.00, 'Yes'),
('MH01-AB-1043', 'Skoda', 'Kodiaq', 3200.00, 'Yes'),
('MH01-AB-1044', 'Jeep', 'Compass', 2100.00, 'Yes'),
('MH01-AB-1045', 'Jeep', 'Wrangler', 4500.00, 'Yes'),
('MH01-AB-1046', 'MG', 'Hector', 1700.00, 'Yes'),
('MH01-AB-1047', 'MG', 'ZS EV', 1900.00, 'Yes'),
('MH01-AB-1048', 'Renault', 'Kiger', 950.00, 'Yes'),
('MH01-AB-1049', 'Nissan', 'Magnite', 900.00, 'Yes'),
('MH01-AB-1050', 'Porsche', 'Macan', 15000.00, 'Yes');

-- 2.3 Insert Customers
INSERT INTO tbl_customers (cust_name, address, phone, email, password) VALUES
('Rahul Sharma', '12, MG Road, Mumbai', '9876543210', 'rahul@gmail.com', '1234'),
('Priya Patel', '45, Navrangpura, Ahmedabad', '9876543211', 'priya@gmail.com', '1234'),
('Amit Singh', '78, Civil Lines, Delhi', '9876543212', 'amit@gmail.com', '1234'),
('Sneha Reddy', '34, Banjara Hills, Hyderabad', '9876543213', 'sneha@gmail.com', '1234'),
('Vikram Malhotra', '56, Koramangala, Bangalore', '9876543214', 'vikram@gmail.com', '1234'),
('Anjali Das', '89, Park Street, Kolkata', '9876543215', 'anjali@gmail.com', '1234'),
('Rohit Verma', '23, Sector 17, Chandigarh', '9876543216', 'rohit@gmail.com', '1234'),
('Pooja Gupta', '67, Gomti Nagar, Lucknow', '9876543217', 'pooja@gmail.com', '1234'),
('Suresh Nair', '90, Panampilly Nagar, Kochi', '9876543218', 'suresh@gmail.com', '1234'),
('Neha Joshi', '11, Deccan Gymkhana, Pune', '9876543219', 'neha@gmail.com', '1234'),
('Arjun Mehta', '101, Satellite, Ahmedabad', '9876543220', 'arjun@gmail.com', '1234'),
('Kavita Iyer', '202, Mylapore, Chennai', '9876543221', 'kavita@gmail.com', '1234'),
('Ravi Kumar', '303, Boring Road, Patna', '9876543222', 'ravi@gmail.com', '1234'),
('Meera Rao', '404, Indiranagar, Bangalore', '9876543223', 'meera@gmail.com', '1234'),
('Sanjay Mishra', '505, Kankerbagh, Patna', '9876543224', 'sanjay@gmail.com', '1234'),
('Divya Kapoor', '606, Vasant Vihar, Delhi', '9876543225', 'divya@gmail.com', '1234'),
('Manish Jain', '707, Malviya Nagar, Jaipur', '9876543226', 'manish@gmail.com', '1234'),
('Riya Sen', '808, Salt Lake, Kolkata', '9876543227', 'riya@gmail.com', '1234'),
('Karan Johar', '909, Juhu, Mumbai', '9876543228', 'karan@gmail.com', '1234'),
('Simran Kaur', '111, Model Town, Ludhiana', '9876543229', 'simran@gmail.com', '1234'),
('Aditya Roy', '222, Bandra, Mumbai', '9876543230', 'aditya@gmail.com', '1234'),
('Nisha Yadav', '333, Hinoo, Ranchi', '9876543231', 'nisha@gmail.com', '1234'),
('Varun Dhawan', '444, Andheri, Mumbai', '9876543232', 'varun@gmail.com', '1234'),
('Ishita Bhalla', '555, Green Park, Delhi', '9876543233', 'ishita@gmail.com', '1234'),
('Rajesh Koothrappali', '666, Indrapuri, Bhopal', '9876543234', 'rajesh@gmail.com', '1234'),
('Penny Hofstadter', '777, Civil Lines, Nagpur', '9876543235', 'penny@gmail.com', '1234'),
('Sheldon Cooper', '888, University Road, Pune', '9876543236', 'sheldon@gmail.com', '1234'),
('Leonard Hofstadter', '999, Ashram Road, Ahmedabad', '9876543237', 'leonard@gmail.com', '1234'),
('Howard Wolowitz', '121, Space City, Bangalore', '9876543238', 'howard@gmail.com', '1234'),
('Bernadette Rostenkowski', '131, Microbiology Lab, Mumbai', '9876543239', 'bernadette@gmail.com', '1234');

-- 2.4 Insert Rentals
INSERT INTO tbl_rentals (car_reg, cust_id, rent_date, return_date, fees, status) VALUES
('MH01-AB-1001', 1, '2025-12-01', '2025-12-05', 10000.00, 'Returned'),
('MH01-AB-1004', 2, '2025-12-10', '2025-12-12', 2400.00, 'Returned'),
('MH01-AB-1010', 3, '2026-01-01', '2026-01-03', 1600.00, 'Returned'),
('MH01-AB-1021', 4, '2026-01-05', '2026-01-10', 25000.00, 'Returned'),
('MH01-AB-1036', 5, '2026-01-15', '2026-01-20', 32500.00, 'Returned');

-- Active Rentals
INSERT INTO tbl_rentals (car_reg, cust_id, rent_date, return_date, fees, status) VALUES
('MH01-AB-1002', 6, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 3 DAY), 5400.00, 'Active'),
('MH01-AB-1007', 7, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 2 DAY), 2800.00, 'Active'),
('MH01-AB-1016', 8, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 5 DAY), 12000.00, 'Active');

-- Pending Requests
INSERT INTO tbl_rentals (car_reg, cust_id, rent_date, return_date, fees, status) VALUES
('MH01-AB-1050', 9, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 1 DAY), 15000.00, 'Pending'),
('MH01-AB-1045', 10, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 2 DAY), 9000.00, 'Pending');

-- 2.5 Mark Active Cars as 'No' (using string instead of int)
UPDATE tbl_cars SET available = 'No' WHERE reg_no IN ('MH01-AB-1002', 'MH01-AB-1007', 'MH01-AB-1016');