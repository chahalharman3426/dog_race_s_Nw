using Microsoft.VisualStudio.TestTools.UnitTesting;
using dog_race_s_Nw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dog_race_s_Nw.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            dog_race_s_Nw.Better better = new dog_race_s_Nw.Better();
            int result=better.resultDeclaration("Sandeep set the bet on 1 with 20",1,100);
            if (result == 120)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }


        [TestMethod()]
        public void Form2Test()
        {
            dog_race_s_Nw.DogRunning run= new dog_race_s_Nw.DogRunning();
            
            if (run.lastPoint()==710)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }


    }
}