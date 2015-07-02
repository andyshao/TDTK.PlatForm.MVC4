using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTK.PlatForm.MVC4.BLL;
using TDTK.PlatForm.MVC4.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TDTK.PlatForm.MVC4.BLL.Tests
{
    [TestClass()]
    public class CardLoginTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //BLL.CardLogin cl = new CardLogin();
            //Model.CardLogin cll = new Model.CardLogin();
            //cll.UserCode = "ypf";
            //cll.UserName = "杨朋飞";
            //cll.CardID = "9999999999";
            //int r = cl.Add(cll);
            //Assert.AreEqual(1, r);

        }

        [TestMethod()]
        public void DeleteTest()
        {
            BLL.CardLoginBLL cl = new CardLoginBLL();
            Model.CardLogin cll = new Model.CardLogin();
            cll.ID = 26;
            bool r = cl.Delete(cll);
            Assert.AreEqual(true, r);
        }
    }
}
