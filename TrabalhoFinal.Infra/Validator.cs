using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.Infra
{
    public static class Validator
    {
        public static void Validate(IObjectValidation domainObject)
        {
            domainObject.Validate();
        }
    }
}
