using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
    class ToDoList
    {
        static void Main()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("What would you like to do today? (Add/View)");
            Console.WriteLine("--------------------------");
            string userAction = Console.ReadLine();
            if (userAction == "Add")
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("What task are you adding to your To-Do List?");
                Console.WriteLine("--------------------------");
                string userTask = Console.ReadLine();
                Item newTask = new Item(userTask);
            }
            else if (userAction == "View")
            {
                int listCount = Item.GetAll().Count;

                if (listCount == 0)
                {
                    Console.WriteLine("You have no tasks in your To-Do List!");
                } 
                else 
                {
                    var userList = Item.GetAll();
                    Console.WriteLine(userList);
                }
            }
            else 
            {
                Console.WriteLine("Please enter a valid option. (Add/View)");
            }
        }    
    }

}
