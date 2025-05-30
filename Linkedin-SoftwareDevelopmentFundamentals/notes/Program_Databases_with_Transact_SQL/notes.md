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

## Explore existing views

## SchemaBind a view

## Leverage view objects with indexes