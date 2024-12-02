# Cost Accounting Program

## Description
**GPT Task 1**: A simple program to help users track their daily expenses. The program prompts the user to input the number of days they wish to track expenses, and for each day, it asks for the expense amount. After collecting the data, the program calculates and displays both the total and average expense per day.

## Features
- Input validation for user entries.
- Allows tracking of expenses for a user-defined number of days.
- Calculates the total amount of expenses and the average expense per day.
- Handles both positive and negative values, recognizing "earnings" as negative expenses.

## How to Run
1. Clone the repository or download the source code.
2. Open the project in Visual Studio or another C# IDE.
3. Compile and run the program.
4. Enter the number of days and then input your expenses for each day when prompted.

## Learning Highlights
- Understanding arrays and how to store data for multiple days.
- Using loops to process user input.
- Basic input validation with `double.TryParse`.
- Performing simple arithmetic operations like sum and average.

## Example
Input:  
Enter the number of days: 5  
Expenses for Day 1: 100  
Expenses for Day 2: 50  
Expenses for Day 3: -30  
Expenses for Day 4: 200  
Expenses for Day 5: 0

Output:  
Total expenses: 320  
Average daily expense: 64
