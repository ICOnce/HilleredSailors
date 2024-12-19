using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMember
{
    public int Id { get; set; } 
    public string Phone {  get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public MemberType.MemberTypes Type { get; set; }
    public String ToString();
}
