using System;
using System.Collections.Generic;
using System.Text;
using CommonMark;

namespace Mi899
{
    public class MdToHtmlConverter
    {
        public string Convert(string md)
        {
            if (string.IsNullOrWhiteSpace(md)) 
            {
                return md;
            }

            string html = "<style>* { font-family: Consolas; } a { text-decoration: none; }</style>" + CommonMarkConverter.Convert(md);

            return html;
        }
    }
}
