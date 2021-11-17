using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentQuirino
{
    public class Template
    {
        private string action, value, status;
        public Template()
        {
        }

        public void setAction(string action)
        {
            this.action = action;
        }

        public void setValue(string value)
        {
            this.value = value;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getAction()
        {
            return action;
        }
        public string getValue()
        {
            return value;
        }

        public string getStatus()
        {
            return status;
        }
    }
}
