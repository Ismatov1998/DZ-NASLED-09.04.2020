using System;

namespace oy

{
    class Program
    {
         
        static void Main(string[] args)
        {
          
        string klyuchpro,klyuchexp,pro="1234",exp="4321";
          Console.WriteLine("Введите ключ Pro: ");
          klyuchpro= Console.ReadLine();
          Console.WriteLine("Введите ключ exp: ");
          klyuchexp= Console.ReadLine();
          if(klyuchpro==pro && klyuchexp==exp)
          {
            DocumentorWorker z=new ProDocumentWorker();
            z.EditDocument();
            z.saveDocument();
            ProDocumentWorker j=new ExpertDocumentWorker();
            j.saveDocument(); 
          }
          else 
          {
           DocumentorWorker p=new DocumentorWorker();
            p.openDocument();
            p.EditDocument();
            p.saveDocument();
          }
         
        
           
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
