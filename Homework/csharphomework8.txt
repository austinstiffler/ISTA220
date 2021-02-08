# C# Homework Chapter 8
## Austin Stiffler
### 03 February, 2021


1. If a field is a reference type, a *deep copy* will perform a new copy of the referred object; while a *shallow copy* will only copy the reference.

1. The value of a reference after declared and initialized is a named memory location on the heap.

1. int  i = 0; would be an example of declaring a value type.

1. Use the *new* keyword to declare a reference type. For example: Swan austin = new Swan();

1. Yes, you can assign NULL to a value type by placing a '?' after it. Example: int? i = null;

1. No, because you cannot assign a null value to a non-nullable value type.

1. 
	* Stack memory is like a stack of boxes piled on top of one another,
	* Heap memory is like a large pile of boxes strewn around a room rather than stacked neatly on top of one another.
	
1.  For the time being, simply accept that all classes are *specialized types* of System.Object and that you can use System.Object to create a variable that can refer 
to any reference type.

1. *Ref* makes the parameter an alias for the actual argument rather than a copy of the argument. The method may change the value of the parameter, and this change is made to the 
actual argument rather than to a local copy.

1. *Out* makes the parameter an alias for the actual argument rather than a copy of the argument. The method must assign a value to the parameter, and this value is made 
to the actual argument.

1. *Boxing* is the process of converting a value type to the type object or to any interface type implemented by this value type, while *unboxing* is the process of converting 
reference type into the value type

1. *Cast*  is an operation that checks whether converting an item of one type to another is safe before actually making the copy. 