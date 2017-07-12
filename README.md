# Lab3_Var1
Third practical task in C#

This simple console application extends the code of Lab2_Var1 by introducing simple collection fields in `Student` class
and `TestCollections` class.

The application executes the following list of tasks:

* Creates a `StudentCollection` object. Adds several different `Student`s to the collection. Prints the contents of the collection.
* Sorts the collection by last name, birth date and AGP using `<collection><T>.Sort(...)` method. Outputs the result of sorting.
* Prints average AGP of all `Student`s
* Prints `Student`s with education == `Specialist`.
* Prints groups of Students by their AGP.
* Creates `TestCollections` object. Searches for the first, middle, last and an abcent element
in collections of the `TestCollection` object. Prints search times.
* Creates a `StudentCollection<string>` object. Adds several `Student` objects to collection and prints the collection.

// MODIFY for extended variant

-----------------------------------------------------------------------------------------------------------------

As required by the task the universal delegate is defined:

```
delegate System.Collections.Generic.KeyValuePair<TKey, TValue> GenerateElement<TKey, TValue>(int j);
```
