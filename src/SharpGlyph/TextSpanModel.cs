﻿using System.Collections.Generic;
using System.Windows;

namespace SharpGlyph
{
    public class TextSpanModel : List<TextModel>
    {
        public int TagId { get; set; }

        public string FontName { get; set; }

        public Rect Box { get; set; }

        public bool IsSideways { get; set; }
    }
}