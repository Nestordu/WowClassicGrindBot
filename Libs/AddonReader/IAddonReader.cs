﻿using System.Drawing;

namespace Libs
{
    public interface IAddonReader
    {

        void Refresh();
        Color GetColorAt(DataFrame cell);
    }
}