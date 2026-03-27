namespace In_Class_Assignment_5
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            IShape shape = new Circle("Red", 5.0);
            _shapeListText += shape.GetInfo() + "\n";
            ShapeListLabel = _shapeListText;
        }

        private void RectangleBtn_Clicked(object sender, EventArgs e)
        {
            IShape shape = new Rectangle("Blue", 4.0, 6.0);
            _shapeListText += shape.GetInfo() + "\n";
            ShapeListLabel.Text = _shapeListText;
        }

        private void ClearBtn_Clicked(object sender, EventArgs e)
        {
            ShapeListLabel.Text = "";
        }
    }
}
