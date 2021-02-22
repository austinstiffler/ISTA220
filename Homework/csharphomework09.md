# C# Chapter 9 Homework
## Austin Stiffler
### 09 February, 2021


1. An *enum* is a value type defined by a set of named constants.

1. enum Ranks {SR, SA, SN, PO3, PO2, PO1, CPO, SCPO, MCPO}

1. Ranks Austin = Rank.PO1; Ranks Jim = Rank.MCPO;

1. enum Ranks {SR = 1, SA = 2, SN = 3, PO3 = 4, PO2 = 5, PO1 = 6, CPO = 7, SCPO = 8, MCPO = 9};

1. You select the type of an enum by declaring it before the list. For example:
enum Season : short { Spring, Summer, Fall, Winter }

1. A *struct* is a value type.

1. 
	* You can't declare a default constructor for a struct.
	* In a class, you can initialize instance fields at their point of declaration.
	* A struct is a value type. A class is a reference type.
	* Structs live on the stack. Classes live on the heap.
	
1. Structs are stored on the stack. Enums are on the stack.

1. int i = 55;
Console.WriteLine(i.ToString());
Console.WriteLine(55.ToString());

1. struct DoD
{
	public string Navy, Marine Corps, Army, Air Force;
}

1. You can't create a default constructor for a struct because the compiler always generates one.

1. CIL is *Common Intermediate Language*. It is the pseudo-machine code that was converted by the
compiler. CLR is what converts the code into CIL.