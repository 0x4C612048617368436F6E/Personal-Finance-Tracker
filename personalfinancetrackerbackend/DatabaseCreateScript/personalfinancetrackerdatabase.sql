DROP DATABASE IF EXISTS personalfinancetracker;
DROP SCHEMA IF EXISTS user;
DROP SCHEMA IF EXISTS admin;
DROP SCHEMA IF EXISTS account;
DROP SCHEMA IF EXISTS budget;
DROP SCHEMA IF EXISTS category;
DROP SCHEMA IF EXISTS role;
CREATE DATABASE IF NOT EXISTS personalfinancetracker;

use personalfinancetracker;

CREATE TABLE IF NOT EXISTS user (
    user_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    user_name VARCHAR(255) NOT NULL,
    email VARCHAR(320) NOT NULL,
    hashed_password VARCHAR(255) NOT NULL, 
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT constraint_unique_username UNIQUE (user_name)
);

CREATE TABLE IF NOT EXISTS role(
    role_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY ,
    role_type ENUM('user','admin') NOT NULL DEFAULT 'user'
)

CREATE TABLE IF NOT EXISTS user_role(
    user_role_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
    user_id INT NOT NULL,
    role_id INT NOT NULL,
    CONSTRAINT constraint_foreign_key_user_id FOREIGN KEY(user_id) REFERENCES user(user_id),
    CONSTRAINT constraint_foreign_key_role_id FOREIGN KEY(role_id) REFERENCES role(role_id)
)

CREATE TABLE IF NOT EXISTS admin_role(
    admin_role_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
    admin_id INT NOT NULL,
    role_id INT NOT NULL,
    CONSTRAINT constraint_foreign_key_admin_id FOREIGN KEY(admin_id) REFERENCES admin(admin_id),
    CONSTRAINT constraint_foreign_key_role_id_fk FOREIGN KEY(role_id) REFERENCES role(role_id)
)

CREATE TABLE IF NOT EXISTS admin(
    admin_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    hashed_password VARCHAR(255) NOT NULL,
    user_name VARCHAR(255) NOT NULL,
    email VARCHAR(320) NOT NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ,
    CONSTRAINT constraint_unique_username UNIQUE (user_name)
)

CREATE TABLE IF NOT EXISTS account(
    account_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    balance INT NOT NULL DEFAULT 0,
    CONSTRAINT constraint_balance_not_less_than_zero CHECK(balance < 0),
    CONSTRAINT constraint_foreign_key_account_id FOREIGN KEY(user_id) REFERENCES user(user_id)
)

CREATE TABLE IF NOT EXISTS transaction(
    transaction_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    account_id INT NOT NULL,
    amount INT DEFAULT 0,
    transaction_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    transaction_description VARCHAR(255), 
    CONSTRAINT constraint_foreign_key_transaction_id FOREIGN KEY(account_id) REFERENCES account(account_id)
)

CREATE TABLE IF NOT EXISTS budget(
    budget_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    amount INT NOT NULL,
    user_id INT NOT NULL,
    category_id INT NOT NULL,
    CONSTRAINT constraint_budget_amount_not_below_zero CHECK(amount < 0),
    CONSTRAINT constraint_foreign_key_user_id_budget FOREIGN KEY(user_id) REFERENCES user(user_id),
    CONSTRAINT constraint_foreign_key_category_id FOREIGN KEY(category_id) REFERENCES category(category_id)
)

DROP TABLE IF EXISTS category;

CREATE TABLE IF NOT EXISTS category(
    category_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    category VARCHAR(255) NOT NULL
)

#Insert category (ASSUMING all is done)
INSERT INTO category (category)
VALUES ('Housing'),('Transportation'),('Food'),
('Utilities'),('Insurance'),('Medical & Healthcare'),
('Saving, Investing, & Debt Payments'),('Personal Spending'),
('Recreation & Entertainment'),('Miscellaneous')

#Might have to refine: https://www.quicken.com/blog/budget-categories/

#Insert roles
INSERT INTO role (role_type)
VALUES ('user'),('admin')

#backup just in case
BACKUP DATABASE personalfinancetracker
TO DISK='C:\\Users\\benja\\Desktop'
WITH DIFFERENTIAL