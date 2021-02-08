# C# Programming Homework 02
## Austin Stiffler
### 13 January, 2021

1. A *local variable* is a variable that is declared inside a method or block of code. It is local only to the method or block of code in which it was declared.

1. A *statement* is a command that performs and action, such as calculating a value and storing the result or displaying a message to a user. You combine statements to create methods.

1. *Identifiers* are the names that you use to identify the elements in your programs, such as namespaces, classes, methods, and variables.

1. *Keywords* are the 77 reserved C# identifiers; each with a particular meaning. You cannot use these identifiers for your own purpose. They are colored blue when you type them.

1. A *variable* is a named location in memory that may contain a value.

1.  
    1. You declare a variable by specifying the type of data it will hold in a declaration statement.
	1. You assign a value to a variable by using the assignment operator (=).
	1. No. You must assign a value to a variable before you can use it; otherwise, your program will not compile. This requirement is called *definite assignment rule*.
	1. Yes. You can declare a variable and initialize serveral variables to the same value.
	
1. If you open a project rather than a solution, Visual Studio autiomatically creates a new solution file for it. This can be confusing if you are not aware of this feature because it can
result in you accidentally generating multiple solutions for the same project.

1. Arithmetic operators and variable types are related, because the action that an arithmetic operator takes depends on the variable type.

1. You turn an integer into a string by using the ToString method.

1. You turn a string into an integer by using the int.Parse method.

1. Precedence governs the order in which an expression's operators are evalued. Associativity governs the direction (left or right) in which the operators are evalued.
An example would be for precedence would be ' 1 + 2 * 3 '. The multiplication "*" would take precedence before addition "+", resulting in an answer of 7.
An example of associativity would be ' 8 / 2 * 4 '. Associativity moves left to right with like operators (* or /, and + or -), so the answer would be 16.

1. *Definite assignment rule* is a rule simply stating that every variable must have a value before it is read from.

1. Prefix and postfix increment and decrement operators evaluate differently in that in prefix the value will change before it is evaluated. In postfix, the value will be evaluated first.

1. *String interpolation* directs the computer to evaluate an expression in a string, including multiple variables and operators.

1. The *var* keyword causes the compiler to deduce the type of variables from the types of the expressions used to initialize them.
