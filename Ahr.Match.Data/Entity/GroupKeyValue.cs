using System;
using System.Collections.Generic;

namespace Ahr.Match.Data.Entity
{
    public partial class GroupKeyValue
    {
        public int Id { get; set; }
        public string KeyGroup { get; set; }
        public int KeySeq { get; set; }
        public string KeyValue { get; set; }
        public string KeyLabel { get; set; }
        public bool IsChecked { get; set; }
    }
}
