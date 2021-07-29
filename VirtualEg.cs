using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication
{
    class UGC
    {
        string[] rules = { "Dress", "Identity Card" };
        public virtual void Rules()
        {
            foreach(var r in rules)
            {
                Console.WriteLine("Rule:{0}",r);
            }
        }
    }
    class MIT : UGC
    {
        string MITrule = "No Mobile";
        public override void Rules()
        {
            base.Rules();
            Console.WriteLine("MIT Rule :{0}",MITrule);
        }
    }
    class AnnaUniversity : UGC
    {
        string AnnaRules = "Only Formals";
        public override void Rules()
        {
            base.Rules();
            Console.WriteLine("Anna University Rules :{1}",AnnaRules);
        }
    }
    class VirtualEg
    {
        static void Main()
        {
            UGC u = new UGC();
            Console.WriteLine("UGC Rules");
            u.Rules();
            MIT m = new MIT();
            Console.WriteLine("MIT Rules");
            m.Rules();
            AnnaUniversity au = new AnnaUniversity();
            Console.WriteLine("Anna Rules");
            au.Rules();
        }
    }
}
