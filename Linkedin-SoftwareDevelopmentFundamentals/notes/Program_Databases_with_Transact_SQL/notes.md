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