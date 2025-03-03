## Users Table Schema

| Column Name   | Data Type    | Constraints                          | Description                                 |
|---------------|--------------|--------------------------------------|---------------------------------------------|
| id            | INTEGER      | PRIMARY KEY AUTOINCREMENT           | Unique user identifier.                     |
| username      | TEXT         | NOT NULL UNIQUE                      | Username (must be unique).                  |
| password      | TEXT         | NOT NULL                             | User's password.                            |
| role          | TEXT         | NOT NULL                             | Role of the user (e.g., admin, cashier).    |
| created_date  | TEXT         | NOT NULL                             | Timestamp when the Users was created.   |
| created_by    | INTEGER      | NOT NULL                             | User ID when the Users was created.     |
| status        | BOOLEAN      | NOT NULL                             | Status when the Users was created.      |
| is_deleted    | BOOLEAN      | NOT NULL                             | Is Deleted when the Users was created.  |