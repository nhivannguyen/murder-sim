using System.Runtime.InteropServices;
using MurderSim.Objects;
using NUnit.Framework;
using Moq;
using MurderSim.Commands;

namespace MurderSim.Tests
{
    [TestFixture]
    public class TalkCmdTest
    {
        Player _p = new Player("Tester", "who makes sure things run");
        NonPlayer _npc = new NonPlayer("Robo", "not controlled by player");
        Location _lab = new Location(new[] {"lab", "indoor"}, "Lab", "a lab room to test stuff");
        //private static string _input = "talk to Robo";
        //CmdController _cmdcon = new CmdController(_input);
        CmdController _cmdcon = new CmdController("talk to Robo");

        [SetUp]
        public void Mke_World()
        {
            _npc.Location = _lab;
        }

        [Test]
        public void Test_Greet_When_In_Same_Location_With_One_Npc()
        {
            _p.Location = _lab;
            //mockLocation.Verify(m => m.UponEnter(), Times.AtLeastOnce());
            Assert.AreEqual("Robo said: Hi, you are at Lab, a lab room to test stuff. Is there anything you want to ask me?\n\r", _p.Location.UponEnter());
        }

        [Test]
        public void Test_Greet_When_Not_In_Same_Location()
        {
            Assert.AreNotEqual("Robo said: Hi, you are at Lab, a lab room to test stuff. Is there anything you want to ask me?\n\r", _p.Location.UponEnter());
        }

        [Test]
        public void Test_Talk_When_In_Same_Location()
        {
            _p.Location = _lab;
            Assert.AreEqual("I have nothing to say to you, Tester", _cmdcon.ExeCmd(_p));
        }

        [Test]
        public void Test_Talk_When_Not_In_Same_Location()
        {
            _p.Location = _lab;

            // TODO: Add your test code here
            Assert.AreEqual("This person is not in this room", _cmdcon.ExeCmd(_p));
        }
    }
}