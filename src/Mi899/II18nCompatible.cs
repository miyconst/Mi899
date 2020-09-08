using System;
using System.Collections.Generic;
using System.Text;

namespace Mi899
{
    internal interface II18nCompatible
    {
        string Name { get; }
        void InitializeI18n();
    }
}
