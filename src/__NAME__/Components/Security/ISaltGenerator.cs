using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace __NAME__.Components.Security
{
    public interface ISaltGenerator
    {
        byte[] GenerateSaltValue(int length);
    }
}
