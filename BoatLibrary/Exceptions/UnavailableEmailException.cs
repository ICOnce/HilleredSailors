using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UnavailableEmailException: Exception
{

    public UnavailableEmailException() 
    {

    }

    public UnavailableEmailException(string message)
        : base(message)
    {

    }

}