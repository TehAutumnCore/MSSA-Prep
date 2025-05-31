# Program Databases with Transact-SQL

# Introduction: 
Automate Systems: Learn to use triggers and stored procedures to automate database tasks and ensure consistent user experiences.
Maintain Database Integrity: Implement transactions and error-handling routines to protect and enhance database functionality.
Create and Use Views and Functions: Understand how to create views and user-defined functions to streamline and optimize database operations.

Should be familiar with SQL Server Management Studio(SSMS)
Comfortable writing Transact-SQL commands
Using SQL Server 2019 and SSMS 18.0
Microsoft SQL Server 2019 Essential Training
Steps:
SQL Server + SSMS Setup Notes

1. *Installed SQL Server 2022 Developer Edition*
    - Downloaded from the official Microsoft website
    - Chose Basic installation
    - Install location: C:\Program Files\Microsoft SQL Server
    - Default instance name: MSSQLSERVER
    - Admin user: GARY\Gary
    - Connection string: Server=localhost;Database=master;Trusted_Connection=True;

2. *Installed SQL Server Management Studio (SSMS)*
    - Version: 21.1.3+5.36127.28
    - Installed separately from SQL Server
    - Used for managing and querying the database

3. *Connected to SQL Server in SSMS*
    - Server name: localhost
    - Authentication: Windows Authentication
    - Opened Options > Additional Connection Parameters tab
    - Entered: <!--safe ONLY for local/testing/practice/learning--> 
      TrustServerCertificate=True;
      Encrypt=False;
    - Clicked Connect and successfully connected

4. *Restored WideWorldImporters sample database*
    - Downloaded WideWorldImporters-Full.bak *https://github.com/Microsoft/sql-server-samples/releases/tag/wide-world-importers-v1.0*
    - Moved the .bak file to:
      C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup
    - In SSMS, right-clicked Databases > Restore Database
    - Selected Device then ... and browsed to the .bak file
    - Restored the database successfully

5. *Environment is ready for T-SQL practice*
    - Can now open .sql files and run queries in SSMS
    - Make sure the database context is set to WideWorldImporters before running scripts




# Create Views of the Data
## Save a query as a view object
Views are essentially saved SELECT queries that return virtual tables displaying data from your main database tables.They fetch the current state of the data everytime the view is called so they don't need to be updated or maintained.
Creating a view: You can create a view by writing a SELECT query and using the CREATE VIEW statement along with the view's name and the AS keyword.
Permissions Required: To create a view, you need CREATE VIEW permission in the database and ALTER permission on the schema where the view is being created

*Schema*: A container or namespace within a database that holds and organizes database objects such as tables, views, and procedures.
*Table*: A collection of related data organized in rows and columns within a database. Each table has a defined structure(columns with data types) and holds the actual data records(rows).
*View*: A virtual table based on the result-set of a stored query. It does not store data itself but presents data from one or more tables(or views) as if it were a table.
*USE*: Changes the current database context to the specified database.
*GO*: A batch separator recognized by tools like SSMS. It signals the end of a batch of T-SQL commands to be sent to the server. 
*SELECT*: Retrieves data from one more tables or views.
*TOP*: Limits the number of rows returned by a query to the specified number.
`*`(Asterisk): Selects ALL columns from the table.
*FROM*: Specifies the table or view from which to retrieve data.
*WHERE*: Filters rows returned by the query based on a specified condition.
*OR*: A loical operator that combines two conditions; returns true if either condition is true.
*INNER JOIN*: Combines rows from two tables when there is a match between specified columns in both tables. Returns only rows that satisfy the join condition.
*ON*: Specifies the condition on which two tables should be joined. Defines the relationship between the columns in the join.
*AS*: Assigns an alias (temporary name) to a table or column in the query for easier reference or clarity.
*CREATE VIEW*: Defines a virtual table (called a view) based on the result set of a SQL query. A view doesn't store data itself; it just shows data from one or more tables.
*VIEW*:A saved SQL query that behaves like a table. You can SELECT from it, but cannot always INSERT, UPDATE, or DELETE unless it's a simple view.
*UNION*: Combines the result of two SELECT queries into a single result set. Duplicate rows are removed by default (Use UNION ALL to keep duplicates.) Columns must match in number and type between both queries.
*'String' AS Alias*:In the line 'Primary Contact' AS ContactType, you're assigning a fixed string value (in this case 'Primary Contact') to a column alias. It's used to label constant values in your result set.


## Explore existing views
Finding Views: You can find existing views in SQL Server using the Graphical interfact(GUI) in Management Studio by navigating to the database and expanding the "Views" folder.
Using T-SQL Commands: Alternatively, you can use T-SQL commands to query system catalog views like sys.objects and sys.schemas to get information aobut views.
Detailed view Information: For specific details aobut a view, you can query sys.SQL_modules or use the sp_helptext stored procedure to see the full text of the view's definition

*sys.objects*: A system catalog view that returns a row for each user-defined, schema-scoped object(tables,views, stored procedures, etc) in the database.
*type_desc*: A column in sys.objects that describes the type of object (e.g., 'VIEW', 'USER_TABLE', 'SQL_STORED_PROCEDURE').
*schema_id*: A column in system views that refers to the schema(logical namespace) an object belongs to. It can be used to join with sys.schemas.
*sys.schemas*: A system view listing all defined schemas in the current database. Useful to identify the owner/group of database objects.
*sys.sql_modules*: A system catalog view that contains the source code(definition) of views, stored procedures, triggers, and functions. You query this when you wan to programmatically retrieve the SQL text used to define a view or procedure.
*OBJECT_ID('schema.object')*: returns the unique object ID for a specified object.(like a view or table)
*sp_helptext 'object_name'*: A system stored procedure that prints the T-SQL definition of a view, function, or stored procedure line by line

## SchemaBind a view
Schema Binding: Schema binding locks the view and the table together, preventing changes to teh table that would break the view. 
Preventing Errors: It ensures that structural changes to the underlying table, such as renaming columns, do not cause errors in the view.
Security Benefits: Using Schema binding and column aliases can mask the actual structure of the database from end users, end users, enhancing security by preventing unauthorized access to sensitive information.

*WITH SCHEMABINDING*: Locks the view definition ot the schema of the underlying tables. Prevents changes to the structure of teh base tables unless the view is dropped first.
*ALTER VIEW*: Modifies the definition of an existing view without dropping it. Commonly used to Add/Remove columns, add SCHEMABINDING, Update logic or column aliases
*'AS ' Column Alias*(Quoted Alias): When using aliases with spaces or special characters, single quotes can be used in SQL Server.
*EXEC sp_rename*" A system stored procedure used to rename tables, columns, indexes, or other database objects
*sys.dm_sql_referencing_entities*: A dynamic management function that returns a list of objects(e.g., views, stored procedures) that depend on a specific table or object. Helps identify dependencies before renaming/dropping column, table, or view.
*sys.sql_modules*: A system catalog view that contains the actual SQL definition of objects like views, triggers, and procedures. Can be joined with other system views to inspect source code and bind metadata.
*DROP VIEW*: Deletes a view from the database. Required before altering the structure of a table referenced by a schemabound view.

## Leverage view objects with indexes
Materialized ViewS: Adding an index to a view creates a materialized view, which stores a duplicate copy of the data, reducing the need for repeated joins and improving query performance.
Deterministic Views: The view must be deterministic, meaning it always returns teh same result when given the same input, to be indexed.
Schema  Binding: The view must be schema-bhound to the underlying tables, ensuring structural changes to teh tables do not break the view.

*CREATE UNIQUE CLUSTERED INDEX*: 
    Creates an index on the view(or table). 
    Unique: Ensures indexed columns contain no duplicate combinations. 
    Clustered: Sorts and stores the data rows in the table based on the index key.
    Required to make a view materialized(precomputed and stored), improving performance.
*Indexed Views*: A materialized view in SQL Server. The data is physically stored, not just computed on query.
    Requires:
        WITH SCHEMABINDING
        A unique clustered index
    Speeds up queries that join or filter on the view's indexed columns.
Naming Conventions in Indexes:
IDX_StockItemDetails is a typical naming pattern
    IDX_ prefix indicates it's an index
    Followed by the view or table name.

# Create User-Defined Functions
## Deterministic vs nondeterministic functions
A function is deterministic if it always returns the same result when given the same input
nondeterminisitic if the result can vary, even with the same input

*GETDATE()*: Returns current date and time; non-deterministic
*RAND()*: Returns a random float between 0 and 1; non-deterministic
*MAX()*: Returns max; deterministic
*MIN()*: Returns min; deterministic
*AVG()*: Returns average; deterministic
*FORMAT(date,format_string)*: Returns a formatted string version of a date, number, etc. Format strings follow .NET style(like 'd', 'mmm ddm yyyy); often non-deterministic because the output may depend on language/locale settings

## Scalar-valued user-defined functions

*CREATE FUNCTION*: Used to define a user-defined function(UDF)
*@InputNumber, @Output*: Local variables are declared with @ and scoped to the function or batch.
*SET*: Assigns a value to a variable
*RETURN*: Used in functions to return a value to the caller.(required for scalar-valued functions)
*PRINT*: Displays a message or scalar value in the console.(such as Console.WriteLine or print().)
*DROP FUNCTION*: Deletes a user-defined function from the database
*Scalar-Valued Function*: Returns a single scalar value(as opposed to a table-valued function which returns a set).

## IF ELSE and CASE statements
IF ELSE Statements: These are used to evaluate a condition and return on evalue if the condition is true and a different value if the condition is false. For example, determining if the number is even or odd.
CASE Statements: These allow you to evaluate multiple conditions and return the first true condition's value. For example, checking if a day is a weekend or not.

*CREATE OR ALTER FUNCTION*: Creates a function if it doesn't exist, or updates(alters)it if it does
*IF...ELSE*: Used for conditional branching inside procedures and functions
*Modulus*: Returns the remainder after division
*CASE*: A SQL expression for conditional logic (similar to a switch or nested if/else)
*CHAR(n)*: Fixed-Length character string type. (char(10) always stores 10 characters)

## Table-valued user-defined functions
Table-Valued Functions: Unlike scalar valued functions that return asingle value, table-valued functions return a result set made up of columns and rows, similar to a table.
Input Parameters: Table-valued functions can include input parameters that modify the output mkaing them more flexible than views. 
Creation Process: The process involves writing a SELECT statement, defining the function with input parameters, and using RETURN caluse to output the result set.

*Table-Valued Function*: A function that returns a result set (table) rather than a single value.

# Work with Stored Procedures
## Write and execute a stored procedure
Stored Procedures: These can perform multiple tasks in a single routine, including modifying data, unlike views or functions.
Naming Conventions: Use consistent prefixes like usp_ for user-stored procedures to help identify oibject types in code.
Creation and Execution: Use the CREATE or ALTER command followed by the procedure name, actions, andd EXEC command to run it.
Advantages: Stored procedures add an abstraction layer, enhancing security and making maintenance easier and can perform multiple actions in one command, improving performance.

*CREATE OR ALTER PROCEDURE*: Creates a new stored procedure or modifies it if it already exists- similar to functions(CREATE OR ALTER FUNCTION)
*PROCEDURE/PROC*: Defines a stored procedure - a reusable block of SQL Statements stored in the database.
*EXECUTE/EXEC*: Runs a stored procedure. Can be followed by parameters if the procedure takes any.
*usp prefix/uspViewEmployees*: Conventionally means "user stored procedure". Not required, just common naming practice

*Stored procedures*: uspProcedureName or usp_ProcedureName (user stored procedure)
*SQL Server's built in procedures* use the sp_prefix(do not use, these are for built in)
*Functions*: ufnFunctionName or fn_FunctionName 
*views*: vViewName or vw_ViewName

## Stored procedure input parameters
Input Parameters: Stored Procedures can include input parameters to alter their actions, making them flexible and dynamic.
Data Modification: Unlike functions and views, stored procedures can write data to tables, not just return existing values.
Creation Process: The video demonstrates creating a stored procedure that inserts a new row into a table, highlighting how to declare input parameters and use them within the procedure.

*ParameterName(input parameter syntax)*: A way to define variables that are passed into a stored procedure or function. Used to customize procedure behaviour.
*Declare(within a procedure)*: Allocates and initializes a local variable within the body of a stored procedure or batch.
*SET(within a procedure)*: Assigns a value to a variable. In procedures, often used to prepare values before insertion or logic.
*INSERT INTO...VALUES*: Adds a new row to a table with the specified column values
*DELETE FROM...WHERE*: Removes rows from a table that match a specified condition.

## Stored procedure output parameters
Output Parameters: Stored procedures can pass information back to the calling application using output parameters, which are useful for communicating success messages or status updates.
Creation:When creating a stored procedure with an output parameter, you need to delcare the parameter with the OUTPUT keyword.
Usage: The calling application must have a local variable to receive the output value and all commands (variable declaration, procedure execution, and value usage) needs to be executed together.

*Output(parameter modifier)*: Used to indicate that a parameter can return a value back to the caller. Enables stored procedures to pass data back.
*FORMAT (function)*: Formats date/time or number values into a readable string using a specified format. 

## Create a database trigger
Triggers: special stored procedures that automatically execute in response to specific events(e.g., insert, update, delete) on a table.
Automation: Triggers can automate tasks such as logging changes to an audit table without manual intervention.
Implementation: The video demonstrates creating a trigger that logs changes to a colors table into an audit table, showcasing how triggers can enhance database functionality and integrity.

# Create Transactions
## Ensure data Consistency with transactions
Transactions: group multiple actions into a single unit of work to ensure all actions are completed successfully or none at all.
Commit and Rollback: If all actions in a transaction succeed, the transaction is comited, permanently saving teh changes. If any action fails, the transaction is rolled back, undoing all changes to maintain data consistency.
Example Scenario: Transferring money between bank accounts requires both deduction from one account and addition to another to be successful. If either action fails, the transaction is rolled back to prevent data inconsistency.

## Create a transaction
Begin Transaction: Use the BEGIN TRANSACTION command to start a transaction, optionally naming it for easier identification.
Commands Within Transaction: Any commands executed after starting the transaction are part of a single unit of work, which can be committed or rolled back.
Commit or Rollback: Use COMMIT to finalize changes or ROLLBACK to undo them, ensuring data consistency and preventing partial updates.

*BEGIN TRANSACTION [name] [WITH MARK]*: Starts a new transaction block. WITH MARK can label the transaction for recovery purposes.
*ROLLBACK TRANSACTION[name]*: Reverses all changes made in the current transaction, effectively undoing them.
*COMMIT TRANSACTION[name]*: Saves all changes made in the current transaction to the database permanently.

## Transaction savepoints
Save Points: These allow you to roll back a portion of a transaction while committing other parts, providing more control over complex transactions.
@@TRANCOUNT Variable: This system variable tracks the number of active transactions, helping manage nested transactions.
Usage: Save points are created with the SAVE TRANSACTION command and can be referenced to roll back to specific points within a transaction, ensuring finer control over data modifications.

*SAVE TRANSACTION [SavepointName]*: Creates a savepoint within a transaction that you can roll back to without rolling back the entire transaction.
*ROLLBACK TRANSACTION [SavepointName]*: Reverts all changes made after the specified savepoint, but keeps the transaction open so you can still commit.
*@@TRANCOUNT*:Returns the number of active transactions for the current session.

## Automatically roll back transactions:
Default Behavior: SQL Server does not automatically roll back transactions when an error occurs; only the failed command is not executed.
XACT_ABORT Setting: Enabling XACT_ABORT ensures that the entire transaction is rolled back if any runtime error is encountered.
Session-Specific: The XACT_ABORT setting applies only to the current session and resets to default (off) in new sessions.

*SET XACT_ABORT ON | OFF*:Controls whether SQL Server automatically rolls back the entire transaction if a run-time error occurs.
    ON: Rolls back the whole transaction on error.
    OFF: Leaves the transaction open; manual rollback required.
Example: SET XACT_ABORT ON;
*@@OPTIONS*: Returns the current SET options active for the session as a bitmask. You can use it to check if specific options like XACT_ABORT are enabled.

# Implement Error Handling
## What is error handling?
Error handling involves planning for potential errors and creating responses to handle them gracefully, ensuring that programs can continue running smoothly.
Purpose: It helps manage disruptions caused by both mechanical issues (like server or network problems) and human errors (like incorrect data types).
Implementation: Error handling routines can reroute or interrupt the execution of a routine, allowing the system to attempt alternative actions or fix issues without failing completely.

## Capture errors with TRY and CATCH
TRY and CATCH Blocks: These are used to handle errors in SQL Server. Code within the TRY block is executed, and if an error occurs, the CATCH block is executed.
Error Information: Functions within the CATCH block can provide detailed error information, such as error number, message, and severity.
Branching Logic: Using IF ELSE and CASE statements within the CATCH block allows for different responses based on the type of error encountered.

*TRY...CATCH*:Used to handle errors in T-SQL by wrapping potentially failing code in a TRY block and responding to errors in a CATCH block.
*ERROR_NUMBER()*:Returns the number of the error that caused the CATCH block to run.
*ERROR_MESSAGE()*: Returns the complete text of the error message.
*ERROR_SEVERITY()*: Returns the severity level of the error.
*ERROR_STATE()*: Returns the state number of the error (useful for debugging).
*ERROR_LINE()*: Returns the line number at which the error occurred.
*ERROR_PROCEDURE()*: Returns the name of the stored procedure or trigger where the error occurred (if applicable).
*XACT_STATE()*:Returns the current state of a user transaction:
    1: Active
    0: No active transaction
    -1: Uncommittable transaction (must be rolled back)

## Generate Errors with THROW
Custom Error Messages: The THROW command allows you to create custom error messages that can be inserted anywhere in your SQL code.
Error Handling: Using THROW within a TRY block transfers execution to the CATCH block, enabling you to handle errors gracefully.
Re-throwing Errors: You can use THROW without arguments in a CATCH block to re-throw the last error encountered, providing flexibility in error management.

*THROW*: Raises an exception in T-SQL. It can be used in two ways:

## Manage Transaction control
Combining Transactions with Error Handling: Integrate TRY and CATCH blocks with transactions to control when to commit or roll back changes based on errors.
Rollback on Error: If an error occurs within the TRY block, the CATCH block executes a rollback to undo all changes, ensuring data consistency.
Custom Error Messages: Use custom messages to inform users about the rollback and the reason for it, enhancing user experience and clarity.
*ROLLBACK TRANSACTION*: Undoes all changes made in the current transaction and ends the

# Data Type Conversions and NULLs
## Implicit data type conversions
Implicit Conversion: SQL Server automatically converts different data types to a compatible type when needed, but this can sometimes lead to ambiguous results.
Explicit Conversion: Use the CONVERT and CAST functions to explicitly specify the desired data type, ensuring the correct operation is performed.
Data Type Precedence: During implicit conversions, SQL Server elevates data types to a higher precedence type to avoid loss of precision. Understanding this precedence is crucial for accurate data handling.

*CONVERT()*: Explicitly converts an expression from one data type to another.
*CAST()*: Another way to explicitly convert a value from one data type to another, often more portable across databases than CONVERT().



## Understand NULL values
Meaning of NULL: NULL represents unknown, missing, or not knowable values, not zero or nothing.
Comparison Impact: Comparing NULL values can lead to unexpected results, as NULL is not equal to any value, including another NULL.
Best Practices: Avoid using NULLs when possible by providing default values that are easily recognizable and out of the range of real data.

*DEFAULT*: Specifies a default value for a column when no value is provided during INSERT.



## The ISNULL function
SNULL Function: This function replaces NULL values with a specified replacement value, making data more consistent and easier to work with.
Usage: ISNULL takes two arguments: the expression to evaluate and the replacement value if the expression is NULL.
Performance Consideration: Using ISNULL in the JOIN or WHERE clauses can affect performance, so it's better to use it in the SELECT clause for large tables.

*ISNULL()*: A function that replaces NULL with a specified replacement value.

## Merge rows with COALESCE
COALESCE Function: This function evaluates multiple expressions and returns the first non-NULL value, making it useful for handling and replacing NULL values.
Multiple Expressions: Unlike ISNULL, COALESCE can take multiple expressions and evaluate them in sequence, providing more flexibility.
Merging Data: COALESCE can merge values from multiple columns into a single column, reducing the number of NULL values and providing a more comprehensive dataset.