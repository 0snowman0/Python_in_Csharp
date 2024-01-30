// Imports the IronPython.Hosting namespace, which contains classes for hosting Python scripts in C#.
using IronPython.Hosting;

// Imports the Microsoft.Scripting.Hosting namespace, which contains additional classes for hosting Python scripts in C#.
using Microsoft.Scripting.Hosting;

// Defines a string variable named `PathPy` that contains the path to the Python file to be executed.
// The `PathPy` variable is used by the `UseFile()` method of the `ScriptRuntime` object to load the Python file from the disk.
string PathPy = @"E:/Computer/GitHub/PaythonInCsharp/PaythonInCsharp/PythonFile.py";

// Creates a `ScriptRuntime` object, which is used to run Python scripts in C#.
// The `CreateRuntime()` method creates a new `ScriptRuntime` object.
ScriptRuntime Py = Python.CreateRuntime();

// Uses the `UseFile()` method of the `ScriptRuntime` object to load the Python file from the `PathPy` variable and create a dynamic object that represents the Python code.
// The `UseFile()` method returns a dynamic object that represents the code.
dynamic PyProggram = Py.UseFile(PathPy);


// **Prints "Hello world" using the Python script.**
PyProggram.print_python("Hello world");


// **Calls the `calculateABC()` function from the Python script and prints the result.**
Console.WriteLine("\nabc function:");
 PyProggram.calculateABC(-9);



// **Reads four items from the dynamic list in the Python script and prints them to the console.**
Console.WriteLine("\nread from list:");
PyProggram.ReadInDynamicList(0);
PyProggram.ReadInDynamicList(1);
PyProggram.ReadInDynamicList(2);
PyProggram.ReadInDynamicList(3);


// **Adds a new item to the dynamic list in the Python script and prints all items in the list.**
Console.WriteLine("\nAdd To list:");
PyProggram.AddToList("new Item");
PyProggram.ReadInDynamicList(4);


// **Evaluates the mathematical expression "1+2+3*9" using the Python script and prints the result.**
Console.Write("\nresult:");
PyProggram.evaluate_math_expression("1+2+3*9");


// Waits for user input before exiting the program.
Console.ReadKey();
