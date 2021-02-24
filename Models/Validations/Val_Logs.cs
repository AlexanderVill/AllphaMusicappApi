using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllphaMusicapp.Models
{
    [MetadataType(typeof(LogsT.MetaData))]
    public partial class LogsT
    {
        sealed class MetaData
        {
            [Required]
            public string name;
        }
    }
}