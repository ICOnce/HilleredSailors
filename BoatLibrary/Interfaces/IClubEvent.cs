using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IClubEvent
{
    int MemberCount { get; }
    DateTime Date {  get; }
    void AddMember(IMember member);
    List<Member> GetParticipants();
    void ChangeTime(DateTime newTime);
    string ToString();

}

