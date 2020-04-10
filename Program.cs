using System;

namespace oy

{
    class Program
    {
         
        static void Main(string[] args)
        {
          
        
         
        
           
        }
        class DocumentorWorker
        {
          public virtual void openDocument()
         {
            Console.WriteLine("Документ открыт");
         }
          public virtual void EditDocument()
          {
             Console.WriteLine("Редактирование документа доступно вверсии Про"); 
          }
          public virtual void saveDocument()
          {
            Console.WriteLine("Сохранение документа доступно в версии Про");
          }

        }
        class ProDocumentWorker: DocumentorWorker
        {
         public override void EditDocument()
         {
          Console.WriteLine("Документ отредактирован");  
         } 
         public override void saveDocument()
         {
          Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");  
         } 


        }
        class ExpertDocumentWorker:ProDocumentWorker
        {
            public override void saveDocument()
            {
            Console.WriteLine("Документ сохранен в новом формате");
            }

        }
    }
}
