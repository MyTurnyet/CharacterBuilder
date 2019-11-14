using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Attributes;

namespace Characters.Display
{
    public interface IJsonInterpreter
    {
        string Serialize(object objectToSerialize);
    }
}
