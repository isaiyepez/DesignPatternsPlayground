using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class DevConfigPrototype : IPrototype
    {
        private string _connectionString = "super secret Dev Conn String";
        private string _azureUserName = "AZURE DEV user";
        private string _azurePassword = "AZURE DEV Password";
        public DevConfigPrototype()
        {
           
        }

        public DevConfigPrototype(DevConfigPrototype sourceObject)
        {
            _connectionString = sourceObject._connectionString;
            _azureUserName = sourceObject._azureUserName;
            _azurePassword = sourceObject._azurePassword;
        }
        public IPrototype Clone()
        {
           return new DevConfigPrototype(this);
        }

        public string GetConnectionString()
        { 
            return _connectionString; 
        }
    }
}
