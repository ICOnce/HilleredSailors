using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MemberNotFoundException : Exception
{

    public MemberNotFoundException()
    {

    }

    public MemberNotFoundException(string message)
        : base(message)
    {

    }

}