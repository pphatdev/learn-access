-- User Details Table
CREATE TABLE user_details (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    user_id INTEGER,
    first_name TEXT,
    last_name TEXT,
    hire_date TEXT,
    dob TEXT,
    pob TEXT,
    id_card TEXT,
    address TEXT,
    created_date TEXT NOT NULL,
    status BOOLEAN NOT NULL,
    is_deleted BOOLEAN NOT NULL,
    FOREIGN KEY (user_id) REFERENCES users(id)
);
