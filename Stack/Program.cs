// See https://aka.ms/new-console-template for more information
using Stack;

try
{
    ResizeStackOnArray<string> stack = new ResizeStackOnArray<string>();
    // добавляем четыре элемента
    stack.Push("Kate");
    stack.Push("Sam1");
    stack.Push("Sam2");
    stack.Push("Sam3");
    stack.Push("Sam4");
    stack.Push("Sam5");
    stack.Push("Sam6");
    stack.Push("Sam7");
    stack.Push("Sam8");
    stack.Push("Alice");
    stack.Push("Tom");

    // извлекаем один элемент
    var head = stack.Pop();
    Console.WriteLine(head);    // Tom

    // просто получаем верхушку стека без извлечения
    head = stack.Peek();
    Console.WriteLine(head);    // Alice
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}


Console.Read();
