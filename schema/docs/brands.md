## Brand Table Schema

| Column Name   | Data Type    | Constraints                          | Description                                 |
|---------------|--------------|--------------------------------------|---------------------------------------------|
| id            | INTEGER      | PRIMARY KEY AUTOINCREMENT            | Unique category identifier.                 |
| name          | TEXT         | NOT NULL UNIQUE                      | Name of the category (must be unique).      |
| description   | TEXT         |                                      | Description of the category.                |
| created_date  | TEXT         | NOT NULL                             | Timestamp when the category was created.    |
| created_by    | INTEGER      | NOT NULL                             | User ID when the category was created.      |
| status        | BOOLEAN      | NOT NULL                             | Status when the category was created.       |
| is_deleted    | BOOLEAN      | NOT NULL                             | Is Deleted when the category was created.   |
