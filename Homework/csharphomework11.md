# C# Chapter 11 Homework
## Austin Stiffler
### 18 February, 2021


1. A *parameter array* is used to pass a variable number of arguments to a method.

1. You define a method that takes an arbitrary number of arguments by using the *params* keyword as an array
parameter modifier when you define the method parameters.

1. You call a method that takes an arbitrary number of arguments by using any number of integer arguments without worrying
about creating an array. You can call the method with any number of arguments.

1. It would include a multidimensional array which will cause a compile error.

1. A method can have any number of parameters.

1. Parameter arguments do not have to have the same type as long as params object[] was used in 
the argument.

1. Non-optional parameters must be passed, whereas optional do not.

1. You define a method that takes different types of arguments by using *params object[]*.

1. public static int Min(params int[] paramList)

1. public static void Hole(params object[] paramList)