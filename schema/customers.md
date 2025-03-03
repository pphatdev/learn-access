## Customers Table Schema

| Column Name   | Data Type    | Constraints                          | Description                                 |
|---------------|--------------|--------------------------------------|---------------------------------------------|
| id            | INTEGER      | PRIMARY KEY AUTOINCREMENT            | Unique customer identifier.                 |
| first_name    | TEXT         | NOT NULL                             | Customer's first name.                      |
| last_name     | TEXT         | NOT NULL                             | Customer's last name.                       |
| email         | TEXT         | UNIQUE                               | Customer's email address (must be unique).  |
| phone         | TEXT         | UNIQUE                               | Customer's phone number (must be unique).   |
| address       | TEXT         |                                      | Customer's address.                         |
| created_date  | TEXT         | NOT NULL                             | Timestamp when the Customers was created.   |
| created_by    | INTEGER      | NOT NULL                             | User ID when the Customers was created.     |
| status        | BOOLEAN      | NOT NULL                             | Status when the Customers was created.      |
| is_deleted    | BOOLEAN      | NOT NULL                             | Is Deleted when the Customers was created.  |
