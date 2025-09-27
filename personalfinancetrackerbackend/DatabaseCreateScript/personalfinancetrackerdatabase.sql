DROP DATABASE IF EXISTS personalfinancetracker;
CREATE DATABASE IF NOT EXISTS personalfinancetracker;

use personalfinancetracker;

#user & user_role -> Refine later
CREATE SCHEMA IF NOT EXISTS user;

CREATE SCHEMA IF NOT EXISTS admin;

CREATE SCHEMA IF NOT EXISTS account;

CREATE SCHEMA IF NOT EXISTS budget;

CREATE SCHEMA IF NOT EXISTS category;

CREATE SCHEMA IF NOT EXISTS role;

CREATE TABLE IF NOT EXISTS user.user{
    user_id INT NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    user_name VARCHAR(255) NOT NULL,
    email VARCHAR(320) NOT NULL,
    hashed_password VARCHAR(255) NOT NULL, 
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    CONSTRAINT constraint_user_id user_id PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT constraint_created_at created_at DEFAULT SELECT NOW(),
    CONSTRAINT constraint_updated_at updated_at DEFAULT SELECT NOW(),
    CONSTRAINT constraint_unique_username user_name UNIQUE,
}

CREATE TABLE IF NOT EXISTS role.role{
    role_id INT NOT NULL,
    role_type ENUM('user','admin') NOT NULL,
    CONSTRAINT constraint_role_id role_id PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT constraint_role_type role_type DEFAULT 'user'
}

#Create many-many table -> check not sure
CREATE TABLE IF NOT EXISTS user.user_role{
    user_role_id INT NOT NULL, 
    user_id INT NOT NULL,
    role_id INT NOT NULL,
    CONSTRAINT constraint_user_role_id user_role_id PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT constraint_foreign_key_user_id FOREIGN KEY(userid) REFERENCES user.user(userid),
    CONSTRAINT constraint_foreign_key_role_id FOREIGN KEY(role_id) REFERENCES role.role(role_id)
}

CREATE TABLE IF NOT EXISTS admin.admin_role{
    admin_role_id INT NOT NULL, 
    admin_id INT NOT NULL,
    role_id INT NOT NULL,
    CONSTRAINT constraint_admin_role_id admin_role_id PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT constraint_foreign_key_admin_id FOREIGN KEY(admin_id) REFERENCES user.user(admin_id),
    CONSTRAINT constraint_foreign_key_role_id FOREIGN KEY(role_id) REFERENCES role.role(role_id)
}

CREATE TABLE IF NOT EXISTS admin.admin{
    admin_id INT NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    hashed_password VARCHAR(255) NOT NULL,
    user_name VARCHAR(255) NOT NULL,
    email VARCHAR(320) NOT NULL,
    created_at DATETIME NOT NULL,
    updated_at DATETIME NOT NULL,
    CONSTRAINT constraint_admin_id admin_id PRIMARY KEY AUTO_INCREMENT
    CONSTRAINT constraint_created_at created_at DEFAULT SELECT NOW(),
    CONSTRAINT constraint_updated_at updated_at DEFAULT SELECT NOW(),
    CONSTRAINT constraint_unique_username user_name UNIQUE,
}

CREATE TABLE IF NOT EXISTS account.account{
    account_id INT NOT NULL,
    user_id INT NOT NULL,
    balance INT NOT NULL DEFAULT 0,
    CONSTRAINT constraint_account_id account_id PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT constraint_balance_not_less_than_zero CHECK(balance < 0),
    CONSTRAINT constraint_foreign_key_account_id FOREIGN KEY(user_id) REFERENCES user(user_id),
}

CREATE TABLE IF NOT EXISTS transaction.transaction{
    transaction_id INT NOT NULL,
    accountid INT NOT NULL,
    amount INT DEFAULT 0,
    transactiondate DATETIME DEFAULT SELECT NOW(),
    transaction_description VARCHAR(255), 
    CONSTRAINT constraint_transaction_id transaction_id PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT constraint_foreign_key_transaction_id FOREIGN KEY(account_id) REFERENCE account(account_id)
}

CREATE TABLE IF NOT EXISTS budget.budget{
    budget_id INT NOT NULL,
    amount INT NOT NULL,
    user_id INT NOT NULL,
    category_id INT NOT NULL,
    CONSTRAINT constraint_budget_id budget_id PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT constraint_budget_amount_not_below_zero CHECK(budget <0)
    CONSTRAINT constraint_foreign_key_user_id FOREIGN KEY(user_id) REFERENCES user(user_id),
    CONSTRAINT constraint_foreign_key_category_id FOREIGN KEY(catergory_id) REFERENCES category(categoryid)
}

CREATE TABLE IF NOT EXISTS category.category{
    categoryid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    category VARCHAR(255) NOT NULL,
    CONSTRAINT constraint_category_id category_id PRIMARY KEY AUTO_INCREMENT,
}

#Insert category (ASSUMING all is done)
INSERT INTO category.category (category)
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