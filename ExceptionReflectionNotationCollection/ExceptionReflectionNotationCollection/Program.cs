Console.WriteLine("1.Exception\n2.Reflection\n3.GarbageCollection");
Console.WriteLine("Enter your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());
switch(choice)
{ 
    case 1:

        ExceptionReflectionNotationCollection.Exception exception = new ExceptionReflectionNotationCollection.Exception();
        exception.Main(args);
        break;
        
    case 2: 

          ExceptionReflectionNotationCollection.Reflection reflection = new ExceptionReflectionNotationCollection.Reflection();
          reflection.Main(args);
        break;
    case 3:
           ExceptionReflectionNotationCollection.GarbageCollection garbageCollection = new ExceptionReflectionNotationCollection.GarbageCollection();  
           garbageCollection.Main(args);
        break ;
    default:
        Console.WriteLine("Enter valid option");
        break ;

 }