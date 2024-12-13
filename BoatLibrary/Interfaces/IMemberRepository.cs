using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMemberRepository
{
    int MemberCount { get; }
    Member GetMember(int id);
    List<Member> GetAll();
    void AddMember(Member member);
    void DeleteMember(int id);
    void UpdateMember(int ID, Member member);
    String ToString();
}