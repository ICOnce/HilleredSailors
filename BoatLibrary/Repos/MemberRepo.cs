using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MemberRepo : IMemberRepository
{
    #region Instances
    private List<IMember> _memberList;
    #endregion

    #region Properties
    public int MemberCount { get { return _memberList.Count; } }
    #endregion

    #region Constructor
    public MemberRepo() { 
        _memberList = new List<IMember>();
    }
    #endregion

    #region Methods
    public void AddMember(IMember member)
    {
        _memberList.Add(member);
    }
    public void DeleteMember(int id)
    {
        foreach (var member in _memberList) 
        {
            if (member.Id == id) 
            {
                _memberList.Remove(member);
                return;
            }
        }
    }
    public List<IMember> GetAll()
    {
        return _memberList;
    }
    public IMember GetMember(int id)
    {
        foreach (var member in _memberList) 
        {
            if (member.Id == id)
            {
                return member;
            }
        }
        return null;
    }
    public void UpdateMember(int ID, IMember member)
    {
        foreach (var m in _memberList)
        {
            if (m.Id == ID) 
            {
                _memberList.Remove(m);
                _memberList.Add(member);
            }
        }
    }
    #endregion
}

