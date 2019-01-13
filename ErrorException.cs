using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA47Team10a_GalaxyLibrary
{
    class ErrorException:ApplicationException
    {
        public ErrorException() : base() { }
        public ErrorException(string s) : base(s) { }
    }
}
