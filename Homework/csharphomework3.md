# C# Chapter 3 Homework
## Austin Stiffler
### 20 January, 2021

1. A *method* is a named block of code that optionally accepts input and returns output.

1. A *function* is a name block of code that returns a value. It does not take a command. A subprocedure takes an action. A procedure is a programming construct that gives a command
to do something.

1. A *return statement* consists of the keyword *return* followed by an expression that specifies the returned value and a semicolon.
If you want a method to return information, you must include at *return statement* at the end of the processing in the method body.

1. An *expression-bodied* method consists of a single expression that returns a value whose type matches the method's return type, or,
for methods that return 'void', that performs the same operation.

1. The *scope* of a variable is simply the region of the program in which that variable is usable.

1. A *field* is a variable of any type that is declared directly in a class.

1. If two identifiers have the same name and declared in the same scope, they are said to be *overloaded*.
*Overloaded methods* are primarily useful when you need to perform the same operation on different data types or varying groups of information.
You can have more than one method with the same name, differentiated by the parameter.

1. If the method requires information (as specified by its parameters), you must supply an argument for each parameter, and the value of each argument must be compatible with the
type of its corresponding parameter. If the method you're calling has two or more parameters, you must separate the arguments with commas.
Call a method by using a parameter list (parentheses). If arguments not required leave list empty. If it requires argument place inside parameter list.

1. Write a method that requires a *parameter list* by: writing the method within a class, specifying the method name, parameter list, return type,
 followed by the body of the method between the braces.
 
1. You specify a parameter as optional in a method by providing a default value for the parameter in the method declaration.

1. To pass an argument to a method as a *named parameter*, you specify the name of the parameter, followed by a colon and the value to use.

1. You return values from a method by using the return function. You can return multiple values from a method by using a *tuple*.

1. A *tuple* is simply a small collection of values. You indicate a method that returns a tuple by specifying a list of types as part of the method definition; one type for each value
returned. " int addition = sidea + sideb; int subtraction = sidea - sideb; return (addition, subtraction); "

1. *Recursion* is a function that is calling itself inside the body of the method.

1. The compiler resolves ambiguities between named arguments and optional parameters by distinguishing between methods by different parameter lists. It will take the version
that most closely matches the method call.

1. The *Component Object Model (COM)* is a platform-independent, distributed, object-oriented system for creating binary software components that can itneract. The *Common Language Runtime (CLR)* runs the code and provides 
services that make the development process easier. The CLR is dependent on the COM because it does not support overloaded methods; instead, it uses methods that can take optional
parameters.