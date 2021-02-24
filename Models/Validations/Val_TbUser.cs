using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllphaMusicapp.Models
{
    [MetadataType(typeof(TbUser.MetaData))]
    public partial class TbUser
    {
        sealed class MetaData
        {
            [Required]
            public string name;
        }
    }
}