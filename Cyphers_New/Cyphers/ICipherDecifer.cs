using System;
using System.Collections.Generic;
using System.Text;

namespace Cyphers
{
    interface ICipherDecipher
    {
        string Cipher(params object[] arguments);
        string Decipher(params object[] arguments);

    }
}
