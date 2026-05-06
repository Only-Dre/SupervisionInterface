using System.Drawing;
using System.Windows.Forms;

namespace Interface_Sup
{
    public class VerticalProgressBar : ProgressBar
    {
        public Color BarColor { get; set; } = Color.LimeGreen;

        public VerticalProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            double porcentagem = (double)(this.Value - this.Minimum) / (this.Maximum - this.Minimum);
            int alturaFill = (int)(rect.Height * porcentagem);

            // Fundo
            e.Graphics.FillRectangle(Brushes.LightGray, rect);

            // Barra crescendo de baixo pra cima
            Rectangle fill = new Rectangle(0, rect.Height - alturaFill, this.Width, alturaFill);
            e.Graphics.FillRectangle(new SolidBrush(BarColor), fill);
        }
    }
}