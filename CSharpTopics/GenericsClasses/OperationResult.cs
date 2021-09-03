using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClasses
{
    public class OperationResult<TEntity> where TEntity : class
    {
        public List<string> MessageList { get; private set; }
        public bool Success => !MessageList.Any();
        public TEntity Entity { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public string Ok(TEntity entity)
        {
            return "Status code 200: Success " + entity;
        }

        public void SetStatusCode(int code, TEntity entity)
        {
            Console.WriteLine($"Status code: {code}");
            Console.WriteLine(entity);

            foreach (var msg in MessageList)
            {
                Console.WriteLine(msg);
            }


            MessageList.Clear();
        }
    }
}
