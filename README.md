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
