## Transactions Table Schema

| Column Name      | Data Type    | Constraints                          | Description                                 |
|------------------|--------------|--------------------------------------|---------------------------------------------|
| id               | INTEGER      | PRIMARY KEY AUTOINCREMENT           | Unique transaction ID.                      |
| customer_id      | INTEGER      | FOREIGN KEY(customers.id)           | References the ID from the `customers` table.|
| total_price      | REAL         | NOT NULL                             | Total transaction amount.                   |
| payment_method   | TEXT         | NOT NULL                             | Payment method (e.g., cash, card).         |
| transaction_status| TEXT         | NOT NULL                             | Status of the transaction (e.g., completed, pending). |
| timestamp        | TEXT         | NOT NULL                             | Timestamp of when the transaction occurred. |
| created_date  | TEXT         | NOT NULL                             | Timestamp when the Transaction was created.   |
| created_by    | INTEGER      | NOT NULL                             | User ID when the Transaction was created.     |
| status        | BOOLEAN      | NOT NULL                             | Status when the Transaction was created.      |
| is_deleted    | BOOLEAN      | NOT NULL                             | Is Deleted when the Transaction was created.  |