using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Logic
{
    public enum Status
    {
        Successfull,
        Unsuccessfull
            
    }
    public class StatusData<T>
    {
        public Status StatusResult { get; set; }

        public T Data { get; set; }
    }
}
