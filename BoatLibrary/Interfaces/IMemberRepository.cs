using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMemberRepository
{
    int MemberCount { get; }

    IMember GetMember(int id);
    List<IMember> GetAll();
    void AddMember(IMember member);
    void DeleteMember(int id);
    void UpdateMember(int ID, IMember member);
    String ToString();

}