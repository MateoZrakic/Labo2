using System;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcolaClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntA.Text) ||
                string.IsNullOrWhiteSpace(EntB.Text) ||
                string.IsNullOrWhiteSpace(EntC.Text))
            {
                LblRisultato.Text = "Inserisci tutti i coefficienti!";
                LblRisultato.TextColor = Colors.Orange;
                return;
            }

            try
            {
                double a = Convert.ToDouble(EntA.Text);
                double b = Convert.ToDouble(EntB.Text);
                double c = Convert.ToDouble(EntC.Text);

                if (a == 0)
                {
                    LblRisultato.Text = "Il coefficiente 'a' non può essere 0!";
                    LblRisultato.TextColor = Colors.Orange;
                    return;
                }

                double delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    LblRisultato.Text = $"Due soluzioni reali:\n" +
                                        $"x₁ = {x1:F2}\n" +
                                        $"x₂ = {x2:F2}";
                    LblRisultato.TextColor = Colors.Green;
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);

                    LblRisultato.Text = $"Unica soluzione reale:\n" +
                                        $"x = {x:F2}";
                    LblRisultato.TextColor = Colors.Blue;
                }
                else
                {
                    LblRisultato.Text = "Nessuna soluzione reale";
                    LblRisultato.TextColor = Colors.Red;
                }
            }
            catch
            {
                LblRisultato.Text = "Inserisci solo numeri validi!";
                LblRisultato.TextColor = Colors.Red;
            }
        }
    }
}
