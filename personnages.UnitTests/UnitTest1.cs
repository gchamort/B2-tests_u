using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using champi.Classes;
using champi.Exceptions;

namespace champi.UnitTests
{
    [TestClass]
    public class BagTests
    {
        [TestMethod]
        [ExpectedException(typeof(EBagIsFull))]
        public void AddItem_BagIsFull_ThrowException()
        {
            Picker jo = new Picker(10);

            for (int i = 0; i != 11; i++)
            {
                jo.AddItem(new Chanterelle());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(EBagIsEmpty))]
        public void PopItem_BagIsEmpty_ThrowException()
        {
            Picker jo = new Picker(10);

            jo.PopItem();
        }
    }
}
