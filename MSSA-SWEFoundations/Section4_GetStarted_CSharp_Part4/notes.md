# Discover value types and reference types
C# Data Fundamentals: Value and Reference Types
This guide provides a reference for the fundamental concepts of data in C#, including how it's stored and the two primary categories of data types: value types and reference types.

How Computers See Data 💾
At the most basic level, all data in an application is stored in the computer's memory as a series of bits.

Bit: The most basic unit of data, representing a simple binary switch as either a 1 (on) or a 0 (off).
Byte: A sequence of 8 bits. A single byte can represent 256 different combinations.
Textual Data: To handle text, computers use encoding systems like ASCII (American Standard Code for Information Interchange). In this system, each character (e.g., the letter 'a') is mapped to a numeric value (e.g., 97), which is then stored in memory as a binary byte (01100001).
What is a Data Type?
A data type is a blueprint that tells the C# compiler and runtime how much memory to allocate for a variable. Choosing the right data type is essential for writing efficient code.

The Two Kinds of Types: Value vs. Reference
All data types in C# fall into one of two fundamental categories, which differ in how and where their values are stored.

Value Types

Variables of a value type directly contain their data.
Think of the variable as a box that holds the actual value inside it.
Examples include int, bool, char, and other simple numeric types.
Reference Types

Variables of a reference type store a reference (an address or a "pointer") to their data, which is stored elsewhere in memory.
Think of the variable as a piece of paper with directions to find the box.
Simple Value Types
Many of the most common data types you'll use are "simple value types."

These types are built directly into the C# language with keywords.

These keywords are actually aliases (nicknames) for predefined types that exist in the .NET Library.

For example, the keyword int is an alias for the .NET type System.Int32. Likewise, char is an alias for System.Char, and bool is an alias for System.Boolean.

#