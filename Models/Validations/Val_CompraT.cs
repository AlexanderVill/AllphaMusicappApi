using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllphaMusicapp.Models
{
    [MetadataType(typeof(CopraT.MetaData))]
    public partial class CopraT
    {
        sealed class MetaData
        {
            [Required]
            public string name;
        }
    }
}