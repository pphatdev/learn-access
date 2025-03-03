## Employees Table Schema

| Column Name   | Data Type    | Constraints                          | Description                                 |
|---------------|--------------|--------------------------------------|---------------------------------------------|
| id            | INTEGER      | PRIMARY KEY AUTOINCREMENT           | Unique employee identifier.                 |
| user_id       | INTEGER      | FOREIGN KEY(users.id)               | References the ID from the `users` table.   |
| first_name    | TEXT         | NOT NULL                             | Employee's first name.                      |
| last_name     | TEXT         | NOT NULL                             | Employee's last name.                       |
| hire_date     | TEXT         |                                      | Employee's hire date.                       |
| dob           | TEXT         |                                      | Employee's date of birth.                   |
| pob           | TEXT         |                                      | Employee's place of birth.                  |
| id_card       | TEXT         |                                      | Employee's identification card number.      |
| address       | TEXT         |                                      | Employee's address.                         |
| created_date  | TEXT         | NOT NULL                             | Timestamp when the Users was created.   |
| created_by    | INTEGER      | NOT NULL                             | User ID when the Users was created.     |
| status        | BOOLEAN      | NOT NULL                             | Status when the Users was created.      |
| is_deleted    | BOOLEAN      | NOT NULL                             | Is Deleted when the Users was created.  |
