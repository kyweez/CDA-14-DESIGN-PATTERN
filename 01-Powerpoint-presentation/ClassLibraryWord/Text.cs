using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWord
{
    public class Text
    {
        #region ############### PROPERTIES ###############
        private EnumFont Font
        {
            get; set;
        }

        private EnumColor Color
        {
            get; set;
        }

        private bool IsBold
        {
            get; set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public Text()
        {
            Font = EnumFont.Calibri;
            Color = EnumColor.Black;
            IsBold = false;

        }
        #endregion
    }
}
