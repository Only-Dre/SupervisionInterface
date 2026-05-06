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
            // Definição de forma do Retângulo
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height); // Define Largura e Altura
            double porcentagem = (double)(this.Value - this.Minimum) / (this.Maximum - this.Minimum); // Definição dos valores aplicados à barra de Progresso
            int alturaFill = (int)(rect.Height * porcentagem); // Limite de preenchimento do topo da barra

            // Fundo
            e.Graphics.FillRectangle(Brushes.LightGray, rect);

            // Barra crescendo de baixo pra cima
            Rectangle fill = new Rectangle(0, rect.Height - alturaFill, this.Width, alturaFill);
            e.Graphics.FillRectangle(new SolidBrush(BarColor), fill);
        }
    }
}