namespace ClassLibraryWord
{
    public class Text
    {
        #region ############### PROPERTIES ###############
        public EnumFont Font
        {
            get; private set;
        }

        public EnumColor Color
        {
            get; private set;
        }

        public bool IsBold
        {
            get; private set;
        }
        #endregion

        #region ############### CONSTRUCTORS ###############        
        public Text(EnumFont _font, EnumColor _color, bool _isBold)
        {
            Font = _font;
            Color = _color;
            IsBold = _isBold;

        }

        public Text() : this(EnumFont.Calibri, EnumColor.Black, false)
        {
        }
        #endregion

        #region ############### EVENT ###############
        public delegate void DelegateObjectModification(Text _currentText);
        public event DelegateObjectModification TextHasChanged;
        #endregion

        #region ############### METHODS ###############
        public void ChangeBold()
        {
            IsBold = (IsBold != true);
            TextHasChanged(this);
        }

        public void ChangeFont(EnumFont _newFont)
        {
            Font = _newFont;
            TextHasChanged(this);
        }

        public void ChangeColor(EnumColor _newColor)
        {
            Color = _newColor;
            TextHasChanged(this);
        }

        public Text CopyCurrentState()
        {
            return new Text(Font, Color, IsBold);
        }
        #endregion
    }
}