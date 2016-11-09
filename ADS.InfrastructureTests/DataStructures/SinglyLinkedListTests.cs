using Microsoft.VisualStudio.TestTools.UnitTesting;
using ADS.ADS.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.ADS.DataStructures.Tests
{
    [TestClass()]
    public class SinglyLinkedListTests
    {
        [TestMethod()]
        public void AddTest()
        {
            SinglyLinkedList<int> zoznam = new SinglyLinkedList<int>();

            zoznam.Add(2);
            zoznam.Add(3);
            zoznam.Add(9);
            zoznam.Add(1);

            int ocakavana;
            ocakavana = 3;

            int realna = zoznam.First.Next.Data;

            Assert.AreEqual(ocakavana, realna);
            

        }
    }
}