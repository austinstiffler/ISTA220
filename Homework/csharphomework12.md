# C# Chapter 12 Homework
## Austin Stiffler
### 17 February, 2021

1. Inheretence promotes the principle of *don't repeat yourself* by organizing like objects in the same class.
This way you do not need to repeat variables, etc for like objects; you just have to declare it once.

1. class DerivedClass : BaseClass { ... }

1. Yes. Structs inherit from  system.valuetype.

1. If you do not have a default constructor in a base class when creating a derived class, the compiler will attempt
to silently insert a call to the base class' default constructor before executing the code in the derived-class
constructor.

1. You cannot assign a variable of a derived class to another variable of its base class because the base class
does not inherit the derived class objects.

1. You can assign a variable of a derived class to another variable of a derived class because they are both under
the same base class.

1. You can assign a variable of a base class to another variable of a derived class because the derived class inherits
the base class objects. It will provide a runtime error because the derived class has functionality that the base
class does not.

1. If you want to have two methods to have the same signature, thus hiding the derived class method, you can silence
the warning by using the *new* keyword.

1. A *virtual* method is a method that is intended to be overridden. You would define this if you want to provide
different implementations of the same method.

1. *Override* declares another implementation of a method if a base class declares that the method is virtual.

1. Use the *this* prefix and apply it to the parameter in the method.

1. You would define an extension type to extend an existing type with additional static methods that become immediately
available to your code in any statements that reference data of the type being extended.

1. Substitutability is a principle in object-oriented programming stating that, in a computer program, if S 
is a subtype of T, then objects of type T may be replaced with objects of type S without altering any of the 
desirable properties of the program. 