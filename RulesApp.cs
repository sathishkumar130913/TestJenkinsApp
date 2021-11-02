using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jenkins.CoreApp;

namespace TestJenkinsApp
{    
    public class RulesApp
    {
         RuleLogic objRulelogic = new RuleLogic();
         public int Addlogic(int a, int b)
         {
           return objRulelogic.Sumlogic(5, 5);
         }
    }
}
