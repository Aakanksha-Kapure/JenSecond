using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication

{
    abstract class RBI
    {
        internal string rule = "Customer should have aadhar card";
        //abstract method
        abstract public int HomeLoan();
        abstract public int EduLoan();
        //Non Abstract Method
        internal void Rules()
        {
            Console.WriteLine("Rules to be followed by all bank:{0}", rule);
        }

    }

    abstract class SBI : RBI
    {
        //SBI abstract method
        abstract public void SBICustomer();

        //RBI abstract method
        public override int HomeLoan()
        {
            return 8;
        }
        public override int EduLoan()
        {
            return 10;
        }
    }
    class SBIBranch : SBI
    {
        public override void SBICustomer()
        {
            Console.WriteLine("It has 1 Lakh Customer");
        }

    }

    class AbstractEg
    {
        static void Main()
        {
            //cannot create obj for abstract cls
            //RBI r = new RBI();
            //SBIbranc sbiobj =  new SBI();
            //Console.WriteLine("SbiHomeLoan:{0}", sbiobj.HomeLoan());
            //Console.WriteLine("SbiEduLoan:{0}", sbiobj.EduLoan());

            //sbiobj.Rules();
            SBIBranch sBIBranch = new SBIBranch();
            Console.WriteLine("SbiHomeLoan:{0}", sBIBranch.EduLoan());
            Console.WriteLine("SbiEDULoan:{0}", sBIBranch.HomeLoan());
            sBIBranch.SBICustomer();
            sBIBranch.Rules();
            /*//run time Polymorphism

            //reference of parent class
            RBI rbiobj = new SBIBranch();
            //Object of child class 
            Console.WriteLine("SbiHomeLoan:{0}", rbiobj.EduLoan());
            Console.WriteLine("SbiEDULoan:{0}", rbiobj.HomeLoan());

            SBI sbiobj = new SBIBranch();
            sbiobj.SBICustomer();

            sbiobj.Rules();
            rbiobj.Rules();*/

        }

    }

}