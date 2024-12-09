using BoatLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Member : IMember
{
    #region Instances
    static int counter = 0;
    private int id;
    #endregion

    #region Properties
    public int Id { get { return id; } }
    public string Phone { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public MemberType.MemberTypes Type { get; set; }
    #endregion

    #region Constructor
    // default constructor
    public Member() {
        Type = MemberType.MemberTypes.member;
        counter++;
        id = counter;
    }
    // parameterised constructor
    public Member(MemberType.MemberTypes type)
    {
        Type = type;
        counter++;
        id = counter;
    }
    #endregion

    #region Methods

    #endregion
}

