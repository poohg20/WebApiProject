using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SyncAwait
    {
        public string GetContent()
        {
            Thread.Sleep(2000);
            return "A";
        }

        public int GetCount()
        {
            Thread.Sleep(5000);
            return 1;
        }

        public string GetName()
        {
            Thread.Sleep(3000);
            return "ABC";
        }
        public async Task<string> GetContentAsync()
        {
            await Task.Delay(2000);
            return "PQR";
        }

        public async Task<int> GetCountAsync()
        {
            await Task.Delay(5000);
            return 4;
        }

        public async Task<string> GetNameAsync()
        {
            await Task.Delay(3000);
            return "Success in run";
        }
    }
}
