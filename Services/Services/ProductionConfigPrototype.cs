using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductionConfigPrototype : IPrototype
    {
        private string _connectionString = "super secret PROD Conn String";
        private string _azureUserName = "AZURE PROD user";
        private string _azurePassword = "AZURE PROD Password";
        public ProductionConfigPrototype()
        {
                
        }

        public ProductionConfigPrototype(ProductionConfigPrototype sourceObject)
        {
            _connectionString = sourceObject._connectionString;
            _azureUserName = sourceObject._azureUserName;
            _azurePassword = sourceObject._azurePassword;
        }
        public IPrototype Clone()
        {
            return new ProductionConfigPrototype(this);
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
