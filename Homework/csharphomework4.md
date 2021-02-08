# C# Chapter 4 Homework
## Austin Stiffler
### 21 January, 2021

1. The possible values of a *boolean expression* are always true or false.

1. 
	* The equality operators are: == (equal to) and != (not equal to).
	* The relational operators are: < (less than), <= (less than or equal to), > (greater than), and >= (greater than or equal to).
	* The logical operators are: ! (NOT), && (AND) and || (OR).
	* All operators are the same becuae they are evaluating expressions to true or false. They are different because logical operators depend on multiple values to be either true or false.

1. *Short-circuiting* is when it is not necessary to evaluate past the first operand of a logical expression.

1. For &&, *short-circuiting* would be applied if the first operand evaluates to false. For ||, *short-circuiting* would be applied if the first operand evaluates to true.

1. The () (precedence override) operator has the highest precedence. The = (assignment) operator has the lowest precedence.

1. The the body of your if/else statement has more than one line, the curly braces will evaluate all lines as a block. If you do not have curly braces, they will be evaluated separately.

1. If you omit *break* in a *switch* statement, the *switch* statement will fall-through.

1.
	* *Switch* is the keyword for initiating a switch statement.
	* *Case* label is a label to compare the expressions.
	* *Break* statements ends the execution of the switch statement and cause the program to continue at the first statement that follows the closing brace of the *switch* statement.
	* *Default* labels are optional, and ran if none of the constant expression values are equal to the controlling expression values.

1. 
	* recurr1() will multiply 5 by 4, then 4 by 3, then 3 by 2, then 2 by 1, then returns 1. Answer is 120.
	* recurr2() will multiply 1 by 5, then 5 by 4, then 20 by 3, then 60 by 2, then 120 by 1. Answer is 120.

1. A *recursive* method is a method that calls itself.
	``` static void Main(string[] args)
        {
            Console.WriteLine("Chapter 4 homework");
            long sumOfNumbers = SumOfNumbers(10);
            Console.WriteLine(sumOfNumbers);
            long productofnumbers = ProductOfNumbers(12);
            Console.WriteLine(productofnumbers);
        }

        private static long ProductOfNumbers(long n)
        {
            Console.WriteLine($"calling ProductOfNumbers({n})");
            if (n == 1)
                return 1;
            else
                return n * ProductOfNumbers(n - 1);
        }

        private static long SumOfNumbers(long n)
        {
            Console.WriteLine($"calling SumOfNumbers({n})");
            if (n == 0)
                return 0;
            else
                return n + SumOfNumbers(n - 1);
        }
 		
1. 
	* The complement of raining and snowing is the same as the union of raining or snowing.
	* The complement of not running and walking is the same as the union of not running or not walking.