using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMember
{
    public int Id { get; } 
    string Phone {  get; set; }
    string Name { get; set; }
    string Email { get; set; }
    MemberType.MemberTypes Type { get; set; }

    String ToString();
}
