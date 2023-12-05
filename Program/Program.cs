using System.Collections;
using BinaryTreeLib;
using ClassLib;
namespace Program;

internal static class Program
{
    static public void PostOrder<T>(BinaryTreeNode<T>? current) where T : IComparable<T>
    {
        if (current == null)
        {
            return;
        }
    
        PostOrder(current?.Left);
        PostOrder(current?.Right);
        Console.WriteLine(current!.Data);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Generic collection:");
        List<StringClass> StringGenericList = new List<StringClass>();
        StringGenericList.Add(new StringClass("Cat"));
        StringGenericList.Add(new StringClass("Bird"));
        StringGenericList.Add(new StringClass("Kitten"));
        StringGenericList.Add(new StringClass("Fish"));
        Console.WriteLine("List:");
        foreach (StringClass Line in StringGenericList)
        {
            Console.WriteLine(Line);
        }
        Console.WriteLine("First string with length = 4 {" + StringGenericList.FirstOrDefault(s => s.Length == 4) + "}");
        StringGenericList.Remove(StringGenericList.FirstOrDefault(s => s.Value == "Kitten"));
        Console.WriteLine("List after deleting {Kitten}:");
        foreach (StringClass Line in StringGenericList)
        {
            Console.WriteLine(Line);
        }
        Console.WriteLine();

        Console.WriteLine("Non-generic collection:");
        ArrayList StringList = new ArrayList();
        StringList.Add(new StringClass("One"));
        StringList.Add(new StringClass("Two"));
        StringList.Add(new StringClass("Three"));
        StringList.Add(new StringClass("Four"));
        Console.WriteLine("List:");
        foreach (StringClass Line in StringList)
        {
            Console.WriteLine(Line);
        }
        Console.WriteLine("First string with length = 4 {" + StringList.OfType<StringClass>().FirstOrDefault(s => s.Length == 4) + "}");
        StringList.Remove(StringList.OfType<StringClass>().FirstOrDefault(s => s.Value == "Two"));
        Console.WriteLine("List after deleting {Two}:");
        foreach (StringClass Line in StringList)
        {
            Console.WriteLine(Line);
        }
        Console.WriteLine();

        Console.WriteLine("Simple array:");
        StringClass[] StringArray = new StringClass[4];
        StringArray[0] = new StringClass("Rad");
        StringArray[1] = new StringClass("Yellow");
        StringArray[2] = new StringClass("Brown");
        StringArray[3] = new StringClass("Blue");
        Console.WriteLine("Array:");
        foreach (StringClass Line in StringArray)
        {
            if (Line != null)
            {
                Console.WriteLine(Line);
            }
        }
        Console.WriteLine("Array element with index = 1 {" + StringArray[1] + "}");
        Console.WriteLine("First array element with length = 5: {" + Array.Find(StringArray, s => s != null && s.Length == 5)+ "}");
        StringArray[3] = null;
        Console.WriteLine("Array after deleting value of element with index 3:");
        foreach (StringClass Line in StringArray)
        {
            if (Line != null)
            {
                Console.WriteLine(Line);
            }
        }
        Console.WriteLine();

        Console.WriteLine("Binary tree foreach (enumerator):");
        BinaryTree<StringClass> BinaryTree = new();
        BinaryTree.Insert(new StringClass("Bread"));
        BinaryTree.Insert(new StringClass("Apple"));
        BinaryTree.Insert(new StringClass("Aqua"));
        BinaryTree.Insert(new StringClass("Sea"));
        foreach (StringClass Line in BinaryTree)
        {
            if (Line != null)
            {
                Console.WriteLine(Line);
            }
        }

        Console.WriteLine();

        Console.WriteLine("Binary tree PostOrder:");
        PostOrder(BinaryTree.Root);
    }
}
