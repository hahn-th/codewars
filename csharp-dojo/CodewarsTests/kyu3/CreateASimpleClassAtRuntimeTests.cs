using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codewars.kyu3;

namespace CodewarsTests.kyu3
{
    [TestClass]
    public class CreateASimpleClassAtRuntimeTests
    {
        [TestMethod]
        public void BasicTest()
        {
            Random rand = new Random();
            Type myType = typeof(object);
            Dictionary<string, Type> properties;

            // Define first class
            properties = new Dictionary<string, Type> { { "SomeInt", typeof(int) }, { "SomeString", typeof(string) }, { "SomeObject", typeof(object) } };
            CreateASimpleClassAtRuntime.DefineClass("SomeClass", properties, ref myType);
            // Instantiate first class
            var myInstance = Activator.CreateInstance(myType);
            // Define second class
            properties = new Dictionary<string, Type> { { "AnotherObject", typeof(object) }, { "SomeDouble", typeof(double) }, { "AnotherString", typeof(string) } };
            CreateASimpleClassAtRuntime.DefineClass("AnotherClass_N" + rand.Next(100), properties, ref myType);
            // Instantiate second class
            myInstance = Activator.CreateInstance(myType);
            
            // Try to redefine first class
            if (CreateASimpleClassAtRuntime.DefineClass("SomeClass", properties, ref myType) == true)
                Assert.Fail("This class is already defined");
        }
    }
}
public class SomeClass
{ /* This class should not conflict with your runtime classes */ }
