using System; 

 
namespace _11.VersionAttribute 
 { 
     [Version("version 1.2")] 
 
 
     class Sample 
     { 
         static void Main() 
         { 
             Type type = typeof(Sample); 
             object[] attr = type.GetCustomAttributes(false); 
             foreach (VersionAttribute item in attr) 
             { 
                 Console.WriteLine(item.Version); 
             } 
         } 
     } 
 } 
