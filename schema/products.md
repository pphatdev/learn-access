## Products Table Schema

| Column Name   | Data Type    | Constraints                          | Description                                 |
|---------------|--------------|--------------------------------------|---------------------------------------------|
| id            | INTEGER      | PRIMARY KEY AUTOINCREMENT           | Unique identifier for each canvas product.  |
| name          | TEXT         | NOT NULL                             | Name of the canvas product.                 |
| description   | TEXT         |                                      | Description of the canvas product.          |
| price         | REAL         | NOT NULL                             | Price of the canvas product.                |
| stock         | INTEGER      | NOT NULL                             | Quantity of the canvas product in stock.    |
| category_id   | INTEGER      | FOREIGN KEY(categories.id)           | References the ID from the `categories` table.|
| supplier_id   | INTEGER      | FOREIGN KEY(suppliers.id)            | References the ID from the `suppliers` table.|
| created_date  | TEXT         | NOT NULL                             | Timestamp when the Products was created.   |
| created_by    | INTEGER      | NOT NULL                             | User ID when the Products was created.     |
| status        | BOOLEAN      | NOT NULL                             | Status when the Products was created.      |
| is_deleted    | BOOLEAN      | NOT NULL                             | Is Deleted when the Products was created.  |
