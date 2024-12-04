using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ILog
{
    public interface ILog
    {
        int EntryCount { get; }

        void AddEntry(string entry);
        string GetEntry(int id);
        List<string> GetAll();
        String ToString();
    }
}

