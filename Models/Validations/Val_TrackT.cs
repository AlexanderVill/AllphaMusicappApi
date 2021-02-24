using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllphaMusicapp.Models
{
    [MetadataType(typeof(TrackT.MetaData))]
    public partial class TrackT
    {
        sealed class MetaData
        {
            [Required]
            public string name;
        }
    }
}