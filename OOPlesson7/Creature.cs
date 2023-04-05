using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace OOPlesson7
{
    public  abstract class Creature
    {
        //5. Orklar, Goblinlər kimi bütün növ entitylər üçün ortaq xassələri və
        //metodları olan Creature adlı abstract sinif yaradardın.

       public int age { get; set; }
        public int weight  { get; set; }


    }
    public class ork:Creature
    {
        private string name;
        private string viev;
        public static int health()
        {
            return ork.health();
        }
    } 
    public class Goblin:Creature
    {
        private string name;
        private string viev;
        public static int  health()
        {
            return Goblin.health();
        }

    }

    




}
