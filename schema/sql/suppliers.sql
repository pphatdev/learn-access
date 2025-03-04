-- Suppliers Table
CREATE TABLE suppliers (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    contact_name TEXT,
    phone TEXT,
    email TEXT,
    address TEXT,
    created_date TEXT NOT NULL,
    created_by INTEGER NOT NULL,
    status BOOLEAN NOT NULL,
    is_deleted BOOLEAN NOT NULL,
    FOREIGN KEY (created_by) REFERENCES users(id)
);