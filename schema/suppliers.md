## Suppliers Table Schema

| Column Name   | Data Type    | Constraints                          | Description                                 |
|---------------|--------------|--------------------------------------|---------------------------------------------|
| id            | INTEGER      | PRIMARY KEY AUTOINCREMENT           | Unique supplier identifier.                 |
| name          | TEXT         | NOT NULL                             | Supplier name.                              |
| contact_name  | TEXT         |                                      | Contact person's name.                      |
| phone         | TEXT         |                                      | Supplier phone number.                      |
| email         | TEXT         |                                      | Supplier email address.                     |
| address       | TEXT         |                                      | Supplier physical address.                  |
| created_date  | TEXT         | NOT NULL                             | Timestamp when the Suppliers was created.   |
| created_by    | INTEGER      | NOT NULL                             | User ID when the Suppliers was created.     |
| status        | BOOLEAN      | NOT NULL                             | Status when the Suppliers was created.      |
| is_deleted    | BOOLEAN      | NOT NULL                             | Is Deleted when the Suppliers was created.  |
