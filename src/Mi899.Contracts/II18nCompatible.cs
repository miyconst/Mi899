using Mi899.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mi899
{
    public interface II18nCompatible
    {
        string Name { get; }
        void ApplyI18n(I18n i18n);
        IEnumerable<IComponent> SelectI18nCompatibleComponents();
    }
}
