-- Customers Table
CREATE TABLE customers (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    first_name TEXT NOT NULL,
    last_name TEXT NOT NULL,
    email TEXT UNIQUE,
    phone TEXT UNIQUE,
    address TEXT,
    created_date TEXT NOT NULL,
    created_by INTEGER NOT NULL,
    status BOOLEAN NOT NULL,
    is_deleted BOOLEAN NOT NULL,
    FOREIGN KEY (created_by) REFERENCES users(id)
);