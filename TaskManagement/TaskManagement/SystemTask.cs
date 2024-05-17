using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    internal class SystemTask
    {
        Tasks[] space { get; set; }
        int count = 0;
        public SystemTask(int i)
        {
            space = new Tasks[i];
        }

        public void AddTask(Tasks task)
        {
            for (int i=0; i<space.Length; i++)
            {
                if (space[i]==null)
                {
                    space[i] = task;
                    count++;
                    break;
                }

            }
        }
        public void showTasks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Task number: {i + 1}");
                Console.Write("   Task: " + space[i].title);
                Console.Write("   Description: " + space[i].description);  
                Console.Write("   Status: " + space[i].status);
                Console.WriteLine("");
            }
        }
        public void deleteTask(int index)
        {
            if(index<count && index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    space[i] = space[i + 1];
                }
                count--;
            }
            else { Console.WriteLine("Invalid index"); }           
        }
        public void markTask(int index)
        {
            if (index < count && index>=0 )
            {
             space[index].status = true;
            }
            else { Console.WriteLine("Invalid index"); }    
        }


    }
}
