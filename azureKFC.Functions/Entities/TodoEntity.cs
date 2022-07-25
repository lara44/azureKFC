using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace azureKFC.Functions.Entities
{
    class TodoEntity: TableEntity
    {
        public DateTime CreatedTime { get; set; }
        public string TaskDescription { get; set; }
        public string IsCompleted { get; set; }
    }
}
}
