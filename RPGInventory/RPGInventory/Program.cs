using RPGInventory.Containers;
using RPGInventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            //BagTest();
            SackTest();
            RemoveTest();
            Console.ReadLine();
        }

        private static void RemoveTest()
        {
            Bag myBag = new Bag(3);

            var item1 = new Sword();
            var item2 = new Potion();
            var item3 = new Sword();

            myBag.AddItem(item1);
            myBag.AddItem(item2);
            myBag.AddItem(item3);

            myBag.DisplayContents();

            var removed = myBag.RemoveItem();
            Console.WriteLine("Removed a {0}", removed.Name);
        }

        private static void BagTest()
        {
            
        }

        private static void SackTest()
        {
            Sack sack = new Sack(4);

            var item1 = new Sword();
            var item2 = new Potion();

            sack.AddItem(item1);
            sack.AddItem(item2);

            sack.DisplayContents();
        }
    }
}
