Method 1
int GreaterCount<T, U>(IEnumerable<T> items, T x)
where T : IComparable<T>

This method returns all items which are bigger than x. 
The type constraint means that T must inherit from the comparable interface, so that we can compare it to x which is also of type T.
This is necsesary because if T is an object type that dosnt inherit from comparable the program will break, as it cant compare the objects.

Method 2
int GreaterCount<T, U>(IEnumerable<T> items, T x)
where T : U
where U : IComparable<U>

This method also returns all items which are bigger than x. 
The type constraint says that T must inherit from U which then inturn must inherit from the Comparable interface. 
Because U is Comparable T must then also be Comparable and we can then compare T and x.
