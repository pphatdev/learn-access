-- Transactions Table
CREATE TABLE transactions (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    customer_id INTEGER,
    total_price REAL,
    payment_method TEXT,
    transaction_status TEXT,
    notes TEXT,
    timestamp TEXT,
    created_date TEXT NOT NULL,
    created_by INTEGER NOT NULL,
    status BOOLEAN NOT NULL,
    is_deleted BOOLEAN NOT NULL,
    transaction_type TEXT,
    FOREIGN KEY (customer_id) REFERENCES customers(id),
    FOREIGN KEY (created_by) REFERENCES users(id)
);