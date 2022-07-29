
int[] arr = { 7, 6, 3, 8, 5 };
double[] arr1 = { 5.2, 4.6, 7.4, 6.4, 8.4 };
string[] arr2 = { "Apple", "Peach", "Banana", "Oragne", "Guava" };
DataStructureAndGenrics.Generics<int> maxInteger = new DataStructureAndGenrics.Generics<int>(arr);
DataStructureAndGenrics.Generics<double> maxDouble = new DataStructureAndGenrics.Generics<double>(arr1);
DataStructureAndGenrics.Generics<string> maxString = new DataStructureAndGenrics.Generics<string>(arr2);
Console.WriteLine("Max Integer from array is: " + maxInteger.showMax());
Console.WriteLine("Max Double from array is: " + maxDouble.showMax());
Console.WriteLine("Max String from array is: " + maxString.showMax());

DataStructureAndGenrics.StackProgram stackProgram = new DataStructureAndGenrics.StackProgram();
stackProgram.Main(args);

DataStructureAndGenrics.Queues queues = new DataStructureAndGenrics.Queues();
queues.Main();

DataStructureAndGenrics.ProgramLinkedList programLinkedList = new DataStructureAndGenrics.ProgramLinkedList();
programLinkedList.Main(args);

DataStructureAndGenrics.HashTable hashTable = new DataStructureAndGenrics.HashTable();
hashTable.Main();

DataStructureAndGenrics.Delegate testDelegate = new DataStructureAndGenrics.Delegate();
testDelegate.Main(args);

DataStructureAndGenrics.BainaryTree bainaryTree = new DataStructureAndGenrics.BainaryTree();
bainaryTree.Main(args);


