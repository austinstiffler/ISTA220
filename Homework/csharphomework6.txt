# C# Homework Chapter 6
## Austin Stiffler
### 27 January, 2021


1. *Exceptions* indicate an error condition inside of a try block that causes a program to crash.

1. The block will run to completion.

1. In unhandled exceptions, the runtime will attempt to locate and execute a matching *catch* handler for the *try block*. If there is
no matching *catch* handler, the calling method immediately exits, and execution returns to the caller, where process is repeated. If the
handler is found, the handler runs and execution conthinues with the first statement that follows the *catch* handler.

1. If an exception block fails to handle a particular error, the program will terminate with an unhandled exception. You would need to use a general exception to handle all exceptions.

1. The parent class for all exceptions is *exception*. If you catch *exception*, the handler traps every possible exception that can occur.

1. Use the message property that will tell you the type of exception.

1. Integer checking prevents integer overflow.

1. The range of values that a signed Int32 type can contain is -2,147,483,648 to 2,147,843,648.

1.
	* The range of values for an unsigned Int32 type is 0 to 4,294,967,295.
	* Signed integers are positive or negative. Unsigned integers are only positive.
	* They represent the same amount of numbers.
	
1. A *finally* block ensures that a statement always runs.

1. If there is nothing to do after an error.