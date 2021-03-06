﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyAirport.Pim.Entities
{
    [DataContract]
    public class MultipleBagageFault
    {
        [DataMember]
        public List<BagageDefinition> ListBagages { get; set; }
        [DataMember]
        public string CodeIata { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
