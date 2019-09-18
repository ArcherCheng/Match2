using System;

namespace Ahr.Match.Data
{
    public interface IEntityBase
    {
         DateTime? CreateTime { get; set; }
         DateTime? UpdateTime { get; set; }
         int? WriteId { get; set; }
         string WriteIp { get; set; }
     }
}