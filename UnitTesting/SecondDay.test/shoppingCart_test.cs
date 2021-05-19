using Day2;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay.test
{
    [TestFixture]
    class shoppingCart_test
    {
        public ShoppingCart c;
        public static Item i1, i2, i3;
        [SetUp]
        public void init()
        {
            c = new ShoppingCart();
     
        }

        //[TestCase(i1,3,"Added")]
        //[TestCase(i2,1,"Updated")]
        //[TestCase(i3,-2,Throws<ArgumentOutOfRangeException>())]
        //[TestCaseSource(typeof(testCaseItems))]
        //public string AddItemsTest(testCaseItemData t)
        //{
        //    return c.AddItems(t.item,t.quantity);
        //}
        [Test]
        public void AddItemsTest()
        {
            i1 = new Item() { ID = 1, Name = "mobile", Price = 3000 };
            c.Cart.Add(i1, 5);
            i2 = new Item() { ID = 2, Name = "tv", Price = 5000 };
            c.Cart.Add(i2, 2);
            i3 = new Item() { Name = "sony", ID = 3, Price = 5000 };
            string res= c.AddItems(i1,3);
            Assert.AreEqual(res,"Updated");
        }
        [Test]
        public void AddItemsTest2()
        {
            i1 = new Item() { ID = 1, Name = "mobile", Price = 3000 };
            c.Cart.Add(i1, 5);
            i2 = new Item() { ID = 2, Name = "tv", Price = 5000 };
            c.Cart.Add(i2, 2);
            i3 = new Item() { Name = "sony", ID = 3, Price = 5000 };
            string res = c.AddItems(i3, 3);
            Assert.AreEqual(res, "Added");
        }
        [Test]
        public void AddItemsTest3()
        {
            i1 = new Item() { ID = 1, Name = "mobile", Price = 3000 };
            c.Cart.Add(i1, 5);
            i2 = new Item() { ID = 2, Name = "tv", Price = 5000 };
            c.Cart.Add(i2, 2);
            i3 = new Item() { Name = "sony", ID = 3, Price = 5000 };
           
            Assert.That(()=> c.AddItems(i2, -3),Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(1, 1, 1, 1)]
        [TestCase(2, 2, 8, 4)]
        public void getAvgTest(int f, int s, int th, int ex)
        {
            int res = c.getAvg(f, s, th);
            Assert.AreEqual(res, ex);
        }

        [Test]
        [Sequential]
        public void getAvgTest2([Range(0, 9, 3)] int n, [Values(0,1,2,3)] int expected)
        {
            int actual = c.getAvg(n,0,0);
            Assert.AreEqual(actual, expected);
        }


        [TestCaseSource(typeof(testCaseNumbers))]
        public int getAvgTest3(int n1,int n2,int n3)
        {
               return c.getAvg(n1,n2,n3);
            
        }

        [Test]
        public void getAgeTest()
        {
            DateTime d = new DateTime(2000, 12, 1);
            int res = c.getAge(d);
            Assert.AreEqual(21, res);
        }

        [Test]
        public void getAgeTest2()
        {
            DateTime d = new DateTime(2006, 12, 1);
            int res = c.getAge(d);
            Assert.AreEqual(15, res);
        }
        [Test]
        public void getAgeTest3()
        {
            DateTime d = new DateTime(2004, 12, 1);
            int res = c.getAge(d);
            Assert.AreEqual(17, res);
        }

    }


    public class testCaseNumbers : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            StreamReader sr = new StreamReader(@"C:\Users\noorulhoda\source\repos\UnitTesting\SecondDay.test\myData.json");
            string json = sr.ReadToEnd();
            List<MyData> items = JsonConvert.DeserializeObject<List<MyData>>(json);
            foreach(var i in items)
            {
                yield return new TestCaseData(i.one, i.two, i.three).Returns(i.avg);
            }

                
        }
    }


    ///// <summary>
    ///// ///////////////////////////////////////////////////////////////////////////
    ///// </summary>

    //    public class testCaseItems : IEnumerable
    //{
    //    public IEnumerator GetEnumerator()
    //    {
    //        yield return new testCaseItemData(shoppingCart_test.i1, 3).Returns("Updated");
    //        yield return new testCaseItemData(shoppingCart_test.i2, 1).Returns("Updated");
    //        yield return new testCaseItemData(shoppingCart_test.i3, 3).Returns("Added");
    //        yield return new testCaseItemData(shoppingCart_test.i1, -2).Returns(new ArgumentOutOfRangeException());
    //    }
    //}


    ///// <summary>
    ///// ////////////////////////////////////////////////////////////////
    ///// </summary>
    //public class testCaseItemData : TestCaseData
    //{
    //     public  Item item;
    //     public int  quantity;
    //    //public int qty;
    //    public testCaseItemData(Item i, int q)
    //    {
    //        item = i;
    //        quantity = q;
    //    }
       
    //}
}
