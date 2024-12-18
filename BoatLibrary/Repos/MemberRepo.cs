﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MemberRepo : IMemberRepository
{
    #region Instances
    private List<Member> _memberList;
    #endregion

    #region Properties
    public int MemberCount { get { return _memberList.Count; } }
    #endregion

    #region Constructor
    public MemberRepo() { 
        _memberList = new List<Member>();
        Member b = new Member(MemberType.MemberTypes.admin);
        b.Name = "peter";
        b.Phone = "12345678";
        b.Email = "123";
        _memberList.Add(b);
    }
    #endregion

    #region Methods
    public void AddMember(Member member)
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
    public List<Member> GetAll()
    {
        return _memberList;
    }
    public Member GetMember(int id)
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
    public void UpdateMember(int ID, Member member)
    { 
        foreach (var m in _memberList)
        {
            if (m.Id == ID) 
            {
                m.Name = member.Name;
                m.Phone = member.Phone;
                m.Email = member.Email;
                m.Type = member.Type;
                return; 
            }
        }
    }
    #endregion
}

