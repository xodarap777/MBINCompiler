﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcBaseBuildingGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x20)]
        public string Name;
    }
}
