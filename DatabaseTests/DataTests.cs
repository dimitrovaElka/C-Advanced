using Db;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace DatabaseTests
{
    public class DataTests
    {
    //    [Test]
    //    public void ShouldElementAddAtTheNextFreeCell()
    //    {

    //    }

        [Test]
       
        public void TestValidConstructor(int[] values)
        {
            Database db = new Database(values);
            //FieldInfo fieldInfo = typeof(Database).GetFields()
            //    .First(fi => fi.FieldType == typeof(int[]));
            //IEnumerable<int> fieldValues = fieldInfo.GetValue(db);
            for (int i = 0; i < values.Length; i++)
            {
                Assert.That(db.Data[i], Is.EqualTo(values[i]));
            }

        }
    }
}
