# TransactionSource

Specifies the nature and initiator of a transaction. 

Crucial for recurring and merchant-initiated transactions as per card scheme rules. 
Omit for customer-initiated e-commerce transactions.


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `FirstRecurring` | first-recurring  |
| `Recurring`      | recurring        |
| `Unscheduled`    | unscheduled      |