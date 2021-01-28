using ClassLibraryVisitorPattern;
using System.Windows.Forms;

namespace WindowsFormsAppVisitorPattern
{
    public partial class FormVisitorPattern : Form
    {
        #region ############### PROPERTIES ###############
        private ShapeGroup Drawing
        {
            get; set;
        }
        private ShapeGroup Arms
        {
            get; set;
        }
        private ShapeGroup Legs
        {
            get; set;
        }
        private Circle Head
        {
            get; set;
        }
        private Rectangle Body
        {
            get; set;
        }
        private DrawVisitor Drawer
        {
            get; set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public FormVisitorPattern()
        {
            Drawing = new ShapeGroup();

            // Head
            Head = new Circle(400, 100, 100);
            Drawing.AddShape(Head);

            // Body
            Body = new Rectangle(400, 200, 100, 100);
            Drawing.AddShape(Body);

            // Legs
            Legs = new ShapeGroup(100, 100);
            Legs.AddShape(new Rectangle(410, 300, 100, 10));
            Legs.AddShape(new Rectangle(480, 300, 100, 10));
            Drawing.AddShape(Legs);

            // Arms
            Arms = new ShapeGroup();
            Arms.AddShape(new Rectangle(320, 200, 10, 80));
            Arms.AddShape(new Rectangle(500, 200, 10, 80));
            Drawing.AddShape(Arms);

            InitializeComponent();
        }
        #endregion

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Drawer = new DrawVisitor(e.Graphics);
            Drawing.Accept(Drawer);
        }
    }
}