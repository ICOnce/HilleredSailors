using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMemberRepository
{
    public int MemberCount { get; }
    public Member GetMember(int id);
    public List<Member> GetAll();
    public void AddMember(Member member);
    public void DeleteMember(int id);
    public void UpdateMember(int ID, Member member);
    public string ToString();
}