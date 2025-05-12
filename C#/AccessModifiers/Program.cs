using System;

namespace AccessModifierDemo{
    class BaseClass{
        public string publicVar = "Public Variable";
        private string privateVar = "Private Variable";
        protected string protectedVar = "Protected Variable";
        internal string internalVar = "Internal Variable";
        protected internal string protectedInternalVar = "Protected Internal Variable";
        private protected string privateProtectedVar = "Private Protected Variable";

        public void ShowBaseMembers(){
            Console.WriteLine(publicVar);
            Console.WriteLine(privateVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(privateProtectedVar + "\n");
        }
    }

    class DerivedClass : BaseClass{
        public void ShowDerivedMembers(){
            Console.WriteLine(publicVar);                 
            // Console.WriteLine(privateVar);            
            Console.WriteLine(protectedVar);              
            Console.WriteLine(internalVar);               
            Console.WriteLine(protectedInternalVar);      
            Console.WriteLine(privateProtectedVar + "\n");       
        }
    }

    class OtherClass{
        public void ShowOtherClassAccess(){
            BaseClass obj = new BaseClass();
            Console.WriteLine(obj.publicVar);             
            // Console.WriteLine(obj.privateVar);         
            // Console.WriteLine(obj.protectedVar);       
            Console.WriteLine(obj.internalVar);           
            Console.WriteLine(obj.protectedInternalVar);  
            // Console.WriteLine(obj.privateProtectedVar);
        }
    }

    class Program{
        static void Main(){
            BaseClass baseObj = new BaseClass();
            baseObj.ShowBaseMembers();

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.ShowDerivedMembers();

            OtherClass otherObj = new OtherClass();
            otherObj.ShowOtherClassAccess();
        }
    }
}
