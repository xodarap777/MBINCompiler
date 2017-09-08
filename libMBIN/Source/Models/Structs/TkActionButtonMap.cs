﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkActionButtonMap : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ActionId;
        public bool ScaleToFitFont;
        public TkInputEnum PadButtonId;
        public List<TkPlatformButtonPair> Platforms;
    }
}
