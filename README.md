# Generics

1. Box of T
Create a class Box&lt;&gt; that can store anything.
It should have two public methods:
 void Add(element)
 element Remove()
 int Count { get; }
Adding should add on top of its contents. Remove should get the topmost element.

2. Generic Array Creator
Create a class ArrayCreator with a method and a single overload to it:
 static T[] create(int length, T item)
The method should return an array with the given length and every element should be set to the given default item.

3. Generic Scale
Create a class Scale&lt;T&gt; that holds two elements - left and right. The scale should receive the elements through its
single constructor:
 Scale(T left, T right)
The scale should have a single method:
 T getHeavier()
The greater of the two elements is heavier. The method should return null if elements are equal.

Problem 1. Generic Box
Create a generic class Box that can be initialized with any type and store the value. Override the ToString() method
to print the type and the value of the data stored in the format {class full name: value}.

Problem 2. Generic Box of String
Use the class that you&#39;ve created for the previous problem and test it with the class System.String. On the first line,
you will get n - the number of strings to read from the console. On the next n lines, you will get the actual strings.
For each of them create a box and call its ToString() method to print its data on the console.

Problem 3. Generic Box of Integer
Use the description of the previous problem but now, test your generic box with Integers.

Problem 4. Generic Swap Method Strings
Create a generic method that receives a list containing any type of data and swaps the elements at two given
indexes.
As in the previous problems read n number of boxes of type String and add them to the list. On the next line,
however you will receive a swap command consisting of two indexes. Use the method you&#39;ve created to swap the
elements that correspond to the given indexes and print each element in the list.

Problem 5. Generic Swap Method Integers
Use the description of the previous problem but now, test your list of generic boxes with Integers.

Problem 6. Generic Count Method Strings
Create a method that receives as argument a list of any type that can be compared and an element of the given
type. The method should return the count of elements that are greater than the value of the given element.
Modify your Box class to support comparing by value of the data stored.
On the first line, you will receive n - the number of elements to add to the list. On the next n lines, you will receive
the actual elements. On the last line, you will get the value of the element to which you need to compare every
element in the list.

Problem 7. Generic Count Method Doubles
Use the description of the previous problem but now, test your list of generic boxes with doubles.

Problem 8. Custom List
Create a generic data structure that can store any type that can be compared. Implement functions:
 void Add(T element)
 T Remove(int index)
 bool Contains(T element)
 void Swap(int index1, int index2)
 int CountGreaterThan(T element)
 T Max()
 T Min()
Create a command interpreter that reads commands and modifies the custom list that you have created. Set the
custom list’s type to string. Implement the commands:
 Add &lt;element&gt; - Adds the given element to the end of the list
 Remove &lt;index&gt; - Removes the element at the given index
 Contains &lt;element&gt; - Prints if the list contains the given element (True or False)
 Swap &lt;index&gt; &lt;index&gt; - Swaps the elements at the given indexes
 Greater &lt;element&gt; - Counts the elements that are greater than the given element and prints their count
 Max - Prints the maximum element in the list
 Min - Prints the minimum element in the list
 Print - Prints all elements in the list, each on a separate line
 END - stops the reading of commands
There will not be any invalid input commands.

Problem 9. Custom List Sorter
Extend the previous problem by creating an additional Sorter class. It should have a single static method Sort()
which can sort objects of type CustomList containing any type that can be compared. Extend the command list to
support one additional command Sort:
 Sort - Sort the elements in the list in ascending order.

Problem 10. *Custom List Iterator
For the print command, you have probably used a for loop. Extend your custom list class by making it to implement
IEnumerable&lt;T&gt;. This should allow you to iterate your list in a foreach statement.

Problem 11. Tuple
There is something, really annoying in C#. It is called a Tuple. It is a class, which may store a few objects but let’s
focus on the type of Tuple which contains two objects. The first one is “item1” and the second one is “item2”. It is
kind of like a KeyValuePair except – it simply has items, which are neither key nor value. The annoyance is coming
from the fact, that you have no idea what these objects are holding. The class name is telling you nothing, the
methods which it has – also. So, let’s say for some reason we would like to try to implement it by ourselves and
provide it in Java, just for practicing generics.
The task: Create a class “Tuple”, which is holding two objects. Like we said, the first one, will be “item1” and
the second one - “item2”. The tricky part here is to make the class hold generics. This means, that when you create a
new object of class - “Tuple”, there should be a way to explicitly, specify both the items type separately.
Input
The input consists of three lines:
 The first one is holding a person name and an address. They are separated by space(s). Your task is to collect
them in the tuple and print them on the console. Format of the input:
&lt;&lt;first name&gt; &lt;last name&gt;&gt; &lt;address&gt;
 The second line holds a name of a person and the amount of beer (int) he can drink. Format:
&lt;name&gt; &lt;liters of beer&gt;
 The last line will hold an Integer and a Double. Format:
&lt;Integer&gt; &lt;Double&gt;
Output
 Print the tuples’ items in format: {item1} -&gt; {item2}
Constraints
Use the good practices we have learned. Create the class and make it have getters and setters for its class variables.
The input will be valid, no need to check it explicitly!

Problem 12. Threeuple
Create a Class Threeuple. Its name is telling us, that it will hold no longer, just a pair of objects. The task is simple,
our Threeuple should hold three objects. Make it have getters and setters. You can even extend the previous class
Input
The input consists of three lines:
 The first one is holding a name, an address and a town. Format of the input:
&lt;&lt;first name&gt; &lt;last name&gt;&gt; &lt;address&gt; &lt;town&gt;
 The second line is holding a name, beer liters, and a Boolean variable with value - drunk or not. Format:
&lt;name&gt; &lt;liters of beer&gt; &lt;drunk or not&gt;
 The last line will hold a name, a bank balance (double) and a bank name. Format:
&lt;name&gt; &lt;account balance&gt; &lt;bank name&gt;
Output
 Print the Threeuples’ objects in format: {firstElement} -&gt; {secondElement} -&gt; {thirdElement}