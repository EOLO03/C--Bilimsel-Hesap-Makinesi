namespace Bilimsel_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rakamlar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text != "0")
            {
                textBox1.Text += btn.Text;
            }
            else
            {
                textBox1.Clear();
                textBox1.Text += btn.Text;
            }

        }

        double s1, s2; // s1: sayı 1   s2: sayı 2
        string işaret;
        private void İşlemler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                if (s1 != 0)
                {
                    double sayı;
                    double.TryParse(textBox1.Text, out sayı);
                    textBox1.Text = (s1 + sayı).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                işaret= btn.Text;
                label1.Text = s1 + " " + işaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "-")
            {
                if (s1 != 0)
                {
                    double sayı;
                    double.TryParse(textBox1.Text, out sayı);
                    textBox1.Text = (s1 - sayı).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                işaret = btn.Text;
                label1.Text = s1 + " " + işaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "/")
            {
                if (s1 != 0)
                {
                    double sayı;
                    double.TryParse(textBox1.Text, out sayı);
                    if (sayı == 0) label1.Text = "Hata"; else textBox1.Text = (s1 / sayı).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                işaret = btn.Text;
                label1.Text = s1 + " " + işaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "*")
            {
                if (s1 != 0)
                {
                    double sayı;
                    double.TryParse(textBox1.Text, out sayı);
                    textBox1.Text = (s1 * sayı).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                işaret = btn.Text;
                label1.Text = s1 + " " + işaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "%")
            {
                if (s1 != 0)
                {
                    double sayı;
                    double.TryParse(textBox1.Text, out sayı);
                    if (sayı == 0) label1.Text = "Hata"; else textBox1.Text = (s1 % sayı).ToString();
                }
                double.TryParse(textBox1.Text, out s1);
                işaret = btn.Text;
                label1.Text = s1 + " " + işaret;
                textBox1.Text = "0";
            }
            else if (btn.Text == "n!")
            {
                double sayı;
                double fakt = 1;
                double.TryParse(textBox1.Text, out sayı);
                try
                {
                    for (int i = 1; i <= sayı; i++)
                    {
                        fakt = fakt * i;
                    }
                    if (fakt.ToString() == "Infinity")
                    {
                        label1.Text = "Hata"; textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = fakt.ToString();
                        label1.Text = sayı + "!";
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                    textBox1.Text = "0";
                }
            }
            else if (btn.Text == "√")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Sqrt(s1).ToString();
                label1.Text = "√" + s1;
            }
            else if (btn.Text == "∛ ")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Pow(s1, (double)1 / 3).ToString();
                label1.Text = "∛ " + s1;
            }
            else if (btn.Text == "π")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.PI.ToString();
                label1.Text = "π";
            }
            else if (btn.Text == "sin")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Sin(Math.PI * s1 / 180).ToString();
                label1.Text = "sin " + s1;
            }
            else if (btn.Text == "cos")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Cos(Math.PI * s1 / 180).ToString();
                label1.Text = "cos " + s1;
            }
            else if (btn.Text == "tan")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Tan(Math.PI * s1 / 180).ToString();
                label1.Text = "tan " + s1;
            }
            else if (btn.Text == "x²")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = (s1 * s1).ToString();
                label1.Text = s1 + "²";
            }
            else if (btn.Text == "ln")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Log(s1).ToString();
                label1.Text = "ln " + s1;
            }
            else if (btn.Text == "log")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.Log10(s1).ToString();
                label1.Text = "log" + s1;
            }
            else if (btn.Text == "1/x")
            {
                double.TryParse(textBox1.Text, out s1);
                label1.Text = "1/" + s1;
                if (s1 != 0) textBox1.Text = (1 / s1).ToString(); else label1.Text = "Hata";
            }
            else if (btn.Text == "e")
            {
                double.TryParse(textBox1.Text, out s1);
                textBox1.Text = Math.E.ToString();
            }
            else if (btn.Text == "C")
            {
                s1 = 0;
                s2 = 0;
                işaret = "";
                textBox1.Text = "0";
                label1.Text = "";
            }
            if (btn.Text == "=")
            {
                label1.Text = "";
                double.TryParse(textBox1.Text, out s2);
                if (işaret == "+") textBox1.Text = (s1 + s2).ToString();
                if (işaret == "-") textBox1.Text = (s1 - s2).ToString();
                if (işaret == "*") textBox1.Text = (s1 * s2).ToString();
                if (işaret == "/") if (s2 == 0) label1.Text = "Hata"; else textBox1.Text = (s1 / s2).ToString();
                if (işaret == "%") if (s2 == 0) label1.Text = "Hata"; else textBox1.Text = (s1 % s2).ToString();
            }// Alperen "EOLO03;" Kılıç
        }
    }
}