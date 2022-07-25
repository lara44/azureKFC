using System;
using System.Collections.Generic;
using System.Text;

namespace azueKFC.Common.Models
{
    class Todo
    {
        public DateTime CreatedTime { get; set; }
        public string TaskDescription { get; set; }
        public string IsCompleted { get; set; }
    }
}
