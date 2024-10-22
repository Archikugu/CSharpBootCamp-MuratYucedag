# C# Bootcamp - Murat Yücedağ
---

# Lecture 1: Hello World & Basic Variables 📚💻
----------------------------------------------------
In this first lecture, we covered the foundational aspects of C# programming:

- **Hello World**:
  - Used `Console.WriteLine()` to display text.

- **String Variables**:
  - Stored and printed customer information.

- **Integer Variables**:
  - Created a restaurant menu and calculated total prices based on item quantities.

This lecture served as an introduction to C# and console-based applications.

---

# Lecture 2: Data Types And Variables 📚💻
----------------------------------------------------
In this lecture, we explored various data types and variables in C#:

- **Double Variables**:
  - Utilized for fruit prices and weight calculations.

- **Char Variables**:
  - Represented individual characters.

- **String Input**:
  - Collected passenger information through keyboard input.

- **Integer Input**:
  - Recorded quantities of items and calculated total prices.

- **Average Calculation**:
  - Computed average exam scores from user input.

This lecture emphasized the importance of data types in programming.

---

# Lecture 3: Making Decisions 📚💻
----------------------------------------------------
In this lecture, we focused on decision-making structures in C#:

- **If-Else Statements**:
  - Password validation.
  - Checking capital and country combinations.
  - Number validation (checking if it's zero).
  - Exam grade classification based on average scores.
  - City existence check.
  - Username validation for admin access.

- **Modulus Operations**:
  - Calculating remainders and determining if a number is even or odd.

- **Char Decision Making**:
  - Identifying teams based on user input.

- **Sample Project: Restaurant Menu**:
  - Displaying detailed menu items based on user selection.

- **Switch Case**:
  - Month name display based on input.
  - Simple calculator for basic operations using switch cases.

---

# Lecture 4: Loops 📚💻
----------------------------------------------------
In this lecture, we focused on different looping structures in C#:

- **For Loop**:
  - Demonstrated basic usage by printing "C# BootCamp" multiple times.
  - Printed numbers from 0 to 20 and numbers from 0 to 50 in increments of 3.
  - Allowed user input to specify how many times a message should be displayed.
  
- **For Loop with Decision Structures**:
  - Printed multiples of 5 up to 100.
  - Calculated the sum of even numbers from 0 to 20 and displayed them.
  - Counted how many multiples of 7 exist between 0 and 50.
  - Explored a bacteria growth example, showing exponential growth over 24 hours.

- **While Loop**:
  - Printed "Hello Loops" 10 times using a while loop.
  - Displayed numbers that are multiples of 3 between 1 and 10.
  - Calculated the total sum of numbers from 1 to 10.

- **Example Exam Question**:
  - Calculated the sum of the digits of a three-digit number entered by the user.
  - Extracted the hundreds, tens, and ones digits and displayed them along with their sum.

This lecture provided a comprehensive understanding of loops and their applications in C# programming.

---

Here’s a summary for **Lecture 5** that captures the key concepts and code examples from your C# program on loops and star patterns:

---

# Lecture 5: Loops with Stars 📚💻
----------------------------------------------------
In this lecture, we explored various star patterns using loops in C#:

- **Vertical Stars**:
  - Created a vertical column of 10 stars using a single `for` loop.

- **Horizontal Stars**:
  - Printed 10 stars in a row, followed by a new line to separate the output.

- **Vertical Rows of Stars**:
  - Printed 10 rows, each containing 10 stars.

- **Right-Angled Triangle**:
  - Constructed a right-angled triangle where the number of stars increases with each row.

- **Inverted Right-Angled Triangle**:
  - Formed an inverted right-angled triangle by decreasing the number of stars in each row.

- **Rhombus**:
  - Designed a rhombus shape by printing spaces and stars. The rhombus is split into two parts: the top and bottom.

- **Pyramid**:
  - Created a pyramid shape, ensuring proper alignment using spaces before the stars.

- **Inverted Pyramid**:
  - Built an inverted pyramid by decreasing the number of stars while maintaining alignment.

This lecture provided hands-on experience with nested loops and creative pattern generation in console applications.

---

Here’s a summary for **Lecture 6** that highlights the key concepts and code examples related to arrays in C#:

---

# Lecture 6: Arrays 📚💻
----------------------------------------------------
In this lecture, we delved into the basics of arrays in C# and explored various operations:

- **Basic Array Initialization**:
  - Created arrays for colors, cities, and numbers, demonstrating how to initialize and access elements.

- **Listing Array Elements**:
  - Used a `for` loop to print all elements in an array of colors.
  - Implemented a `foreach` loop to display numbers that are multiples of 3.
  - Found the maximum number in an integer array through iteration.

- **Array Properties and Methods**:
  - Accessed the length of an array and sorted its elements using `Array.Sort()`.
  - Reversed the order of elements in an array with `Array.Reverse()`.
  - Utilized `Array.IndexOf()` to find the index of a specific element and the `Max()` and `Min()` methods to identify the largest and smallest elements.

- **User Input**:
  - Collected user-defined country names into an array and displayed them.
  - Calculated the sum of elements in a predefined array.

- **Separating Even and Odd Numbers**:
  - Collected user-inputted integers into an array, then categorized and printed them as either even or odd.

This lecture provided foundational knowledge on how to work with arrays, including basic operations, properties, and user interaction.

---

Here’s a summary for **Lecture 7**, formatted similarly to the summary you provided for Lecture 6:

---

# Lecture 7: Foreach Loop and Sample Exam Application 📚💻
----------------------------------------------------
In this lecture, we delved into the `foreach` loop in C# and developed a sample application for managing student exam scores:

### Foreach Loop Basics:
- **Basic Iteration**: 
  - Used a `foreach` loop to iterate through arrays and lists, demonstrating how to access and display each element in collections such as cities and numbers.
  
- **Filtering Even Numbers**: 
  - Implemented a `foreach` loop to identify and print even numbers from a collection of integers.

### Summation of Elements:
- **Total Calculation**:
  - Used a `foreach` loop to calculate the total of an array of numbers by iterating through each element and accumulating their values.

### User Input and Student Management:
- **Collecting Student Data**: 
  - Designed a system to gather information about students, including their names and exam scores, using user input.

- **Calculating Average Scores**: 
  - Implemented logic to calculate the average of three exam scores for each student and store the results in an array.

### Result Evaluation:
- **Pass/Fail Determination**:
  - Evaluated each student's average score, displaying whether they passed or failed based on their performance, while also handling invalid score entries.

This lecture provided foundational knowledge on utilizing the `foreach` loop in C#, reinforcing how to manage collections and interact with users effectively. The concepts learned are essential for building applications that involve data processing and user engagement.

---

Here’s a summary for **Lecture 8**, formatted in a way similar to your previous summaries:

---

# Lecture 8: Methods in C# 📚💻
----------------------------------------------------
In this lecture, we explored various types of methods in C# and their applications:

### Void Methods:
- **Basic Void Methods**: 
  - Created methods that do not return a value, such as `CustomerList()`, which displays customer names, and `Sum()`, which calculates and prints the sum of two integers.

### Parameterized Void Methods:
- **Using Parameters**: 
  - Developed methods that accept parameters, such as `WriteMethod()`, which prints a customer's name, and `CustomerCard()`, which outputs a full name. 
  - Implemented the `Subtract()` method to perform subtraction on three integers and display the result.

### Methods that Return a Value:
- **Returning Values**: 
  - Created methods like `CustomerName()` and `StudentCard()` that return specific strings, demonstrating how to use return statements effectively.

### Parameterized Methods that Return a Value:
- **Country Card Example**: 
  - Developed the `CountryCard()` method, which takes country details as parameters and returns a formatted string with information about the country.
  - Collected user input for country details and displayed the results, reinforcing the interaction with user input.

### Additional Functionality:
- **Multiplication Method**: 
  - Created a method named `Multiply()` to multiply two numbers and return the result.

### Exam Application:
- **Calculating Exam Results**: 
  - Built an `ExamResult()` method that evaluates a student's average score from three exams, determining whether the student passed or failed based on their average score and returning a descriptive message.
  - Collected student names and exam scores through user input, integrating all concepts learned into a practical application.

This lecture provided a comprehensive understanding of methods in C#, covering both void and return value methods, parameterized methods, and practical applications of these concepts in developing a simple exam evaluation application.

---

Here’s a concise summary for **Lecture 9** that focuses on the ADO.NET concepts demonstrated in your database project:

---

# Lecture 9: ADO.NET and Database Interaction 📚💻
----------------------------------------------------
In this lecture, we explored the basics of using ADO.NET for database operations in C#:

### Overview:
- Developed a console application to manage product-category information from a SQL database.

### Key Components:
1. **SqlConnection**: Established a connection to the SQL Server database using a connection string.
2. **SqlCommand**: Used to execute SQL queries. In this case, we retrieved all records from the `TblCategories` table.
3. **SqlDataAdapter**: Facilitated the retrieval of data into a `DataTable`, which acts as an in-memory representation of the data.
4. **DataTable**: Stored the results of the SQL query, allowing iteration over the rows.

### Data Retrieval:
- Closed the connection after executing the command and used nested loops to print the contents of the `DataTable`, displaying each row's data.

This lecture emphasized how to connect to a database and retrieve data efficiently using ADO.NET, laying the groundwork for more complex database interactions.

---





