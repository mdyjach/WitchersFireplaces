using System.Drawing;

namespace WitchersFireplaces
{
    internal class Fireplace
    {
        public bool IsActive { get; private set; }
        public int[] Influenced { get; private set; }
        private Button button;

        public Fireplace() 
        { 
            IsActive = true;
            button = new Button();
            Influenced = new int[0];
        }

        public Fireplace(Button button, int[] influenced, bool isActive = false)
        {
            this.button = button;
            IsActive = isActive;
            Influenced = influenced;
            SetColor();
        }

        public void ChangeState()
        {
            IsActive = !IsActive;
            SetColor();
        }

        private void SetColor()
        {
            button.BackColor = IsActive ? Color.Red : Color.LightGray;
        }
    }
}
