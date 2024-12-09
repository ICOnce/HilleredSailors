using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MemberRepo : IMemberRepository
{
    private List<IMember> MemberList;
    public int MemberCount { get { return MemberList.Count; } }

    public MemberRepo() { 
        MemberList = new List<IMember>();
    }
    public void AddMember(IMember member)
    {
        MemberList.Add(member);
    }

    public void DeleteMember(int id)
    {
        foreach (var member in MemberList) {
            if (member.Id==id) {
                MemberList.Remove(member);
                return;
            }
        }
    }

    public List<IMember> GetAll()
    {
        return MemberList;
    }

    public IMember GetMember(int id)
    {
        foreach (var member in MemberList) {
            if (member.Id==id) return member;
        }
        return null;
    }

    public void UpdateMember(int ID, IMember member)
    {
        foreach (var m in MemberList)
        {
            if (m.Id == ID) {
                MemberList.Remove(m);
                MemberList.Add(member);
            }
        }
    }
}

