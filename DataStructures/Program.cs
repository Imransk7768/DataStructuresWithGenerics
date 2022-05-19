using System;
namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>  Welcome to DataStructures Using Generics  <<<<");
            bool end = true;
            Console.WriteLine("1. Add Data\n2. In Reverse Data\n3. Insert Data\n4. Remove First Node Element\n5. Remove Last Node Element\n6. Search Node\n" +
                "7. Insert New Data\n8. Delete Node At Particular Position\n9. Stack Push\nEnd Of Program ");
            while (end)
            {
                DataStructure<string> structure = new DataStructure<string>();
                OrderedList<int> ordlist = new OrderedList<int>();
                Console.WriteLine("Enter Option For Exicute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Add into Linked List");
                        structure.Add("Rehan");
                        structure.Add("Ashok");
                        structure.Add("Sirish");
                        structure.Display();
                        break;
                    case 2:
                        structure.AddInReverseOrder("Rehan");
                        structure.AddInReverseOrder("Ashok");
                        structure.Add("Rehan");
                        structure.Add("Sirish");
                        structure.Display();
                        break;
                    case 3:
                        structure.Add("Sirish");
                        structure.Add("Rehan");
                        int num = structure.Search("Sirish");
                        structure.InsertAtParticularPosition(num + 1, "Ashok");
                        structure.Display();
                        break;
                    case 4:
                        structure.Add("Sirish");
                        structure.Add("Ashok");
                        structure.Add("Rehan");
                        structure.RemoveFirstNode();
                        structure.Display();
                        break;
                    case 5:
                        structure.Add("Sirish");
                        structure.Add("Ashok");
                        structure.Add("Rehan");
                        structure.RemoveLastNode();
                        structure.Display();
                        break;
                    case 6:
                        structure.Add("Sirish");
                        structure.Add("Ashok");
                        structure.Add("Rehan");
                        structure.Search("Ashok");
                        break;
                    case 7:
                        structure.Add("Sirish");
                        structure.Add("Ashok");
                        structure.Add("Rehan");
                        int newNode = structure.Search("Ashok");
                        structure.InsertAtParticularPosition(newNode + 1, "Anil");
                        structure.Display();
                        break;
                    case 8:
                        structure.Add("Sirish");
                        structure.Add("Ashok");
                        structure.Add("Rehan");
                        int node = structure.Search("Ashok");
                        structure.InsertAtParticularPosition(node + 1, "Anil");
                        structure.Display();
                        Console.WriteLine("\nElement Delete SuccessFully");
                        structure.DeleteNodeAtParticularPosition(node + 1);
                        structure.Display();
                        break;
                    case 9:
                        ordlist.Push(70);
                        ordlist.Push(30);
                        ordlist.Push(56);
                        ordlist.IsEmpty();
                        ordlist.Display();
                        break;
                    default:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                }
            }
        }
    }
}