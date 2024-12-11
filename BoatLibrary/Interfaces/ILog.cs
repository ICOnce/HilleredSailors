using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ILog
{
    public interface ILog
    {
        public int EntryCount { get; }
        public void AddEntry(string entry);
        public string GetEntry(int id);
        public List<string> GetAll();
        public String ToString();
    }
}

