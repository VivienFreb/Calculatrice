using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }

        List<string> calcul    = new List<string>();
        List<string> calcultmp = new List<string>();
        List<string> operateur = new List<string>(new string[] { "*", "/", "+", "-" });

        double resultat = 0;
        public double Factoriel(double nbr)
        {
            if (nbr == 1)
                return 1;
            else
                return nbr * Factoriel(nbr - 1);
        }

        public double AuCarre(double nbr)
        {
            return nbr * nbr;
        }

        public double RacineCarree(double nbr)
        {
            return Math.Sqrt(nbr);

        }

        public double FaireCalcul(List<string> unCalculAFaire)
        {
            int index = 0;
            resultat = 1;
            foreach (string str in unCalculAFaire)
            {
                Console.WriteLine("ALLO 2 : " + str);
            }

            if(unCalculAFaire.Contains("*") || unCalculAFaire.Contains("/"))
            {
                
                if (unCalculAFaire.Contains("*"))
                {
                    index = unCalculAFaire.IndexOf("*");
                    resultat = Convert.ToDouble(calcul[index - 1]) * Convert.ToDouble(calcul[index + 1]);
                }

                if (unCalculAFaire.Contains("/"))
                {
                        index = unCalculAFaire.IndexOf("/");
                        Console.WriteLine(Convert.ToString(calcul[index + 1]));
                        if(Convert.ToString(calcul[index + 1]) == "0")
                        {
                            throw new ArithmeticException("Division par 0 impossible !");
                        }
                        resultat = Convert.ToDouble(calcul[index - 1]) / Convert.ToDouble(calcul[index + 1]);
                }
                unCalculAFaire.RemoveRange(index-1, 2);
                
                unCalculAFaire[index-1] = Convert.ToString(resultat);

                FaireCalcul(unCalculAFaire);

            }
            else if(unCalculAFaire.Contains("+") || unCalculAFaire.Contains("-"))// On a les signes + ou - 
            {
                if (unCalculAFaire.Contains("+"))
                {
                    index = unCalculAFaire.IndexOf("+");
                    resultat = Convert.ToDouble(calcul[index - 1]) + Convert.ToDouble(calcul[index + 1]);
                }

                if (unCalculAFaire.Contains("-"))
                {
                    index = unCalculAFaire.IndexOf("-");
                    resultat = Convert.ToDouble(calcul[index - 1]) - Convert.ToDouble(calcul[index + 1]);
                }


                unCalculAFaire.RemoveRange(index - 1, 2);


                unCalculAFaire[index - 1] = Convert.ToString(resultat);
                
                FaireCalcul(unCalculAFaire);
            }
            else // on a le résultat
            {
                resultat = Convert.ToDouble(unCalculAFaire[0]);
                Console.WriteLine("RESULTAT : " + resultat);
            }

            return resultat;
        }


        private void bt_0_Click(object sender, EventArgs e)
        {


            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "0";
                tb_historique.Text = tb_historique.Text + "0";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "0";
                tb_resultat.Text = tb_resultat.Text + "0";
            }

        }

        private void bt_1_Click(object sender, EventArgs e)
        {        

                if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
                {
                    tb_resultat.Text = "1";
                    tb_historique.Text = tb_historique.Text + "1";
                }
                else
                {
                    tb_historique.Text = tb_historique.Text + "1";
                    tb_resultat.Text = tb_resultat.Text + "1";
                }
        }

        private void bt_2_Click(object sender, EventArgs e)
        {

            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "2";
                tb_historique.Text = tb_historique.Text + "2";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "2";
                tb_resultat.Text = tb_resultat.Text + "2";
            }
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "3";
                tb_historique.Text = tb_historique.Text + "3";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "3";
                tb_resultat.Text = tb_resultat.Text + "3";
            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "4";
                tb_historique.Text = tb_historique.Text + "4";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "4";
                tb_resultat.Text = tb_resultat.Text + "4";
            }
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "5";
                tb_historique.Text = tb_historique.Text + "5";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "5";
                tb_resultat.Text = tb_resultat.Text + "5";
            }
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "6";
                tb_historique.Text = tb_historique.Text + "6";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "6";
                tb_resultat.Text = tb_resultat.Text + "6";
            }
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "7";
                tb_historique.Text = tb_historique.Text + "7";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "7";
                tb_resultat.Text = tb_resultat.Text + "7";
            }
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "8";
                tb_historique.Text = tb_historique.Text + "8";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "8";
                tb_resultat.Text = tb_resultat.Text + "8";
            }
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = "9";
                tb_historique.Text = tb_historique.Text + "9";
            }
            else
            {
                tb_historique.Text = tb_historique.Text + "9";
                tb_resultat.Text = tb_resultat.Text + "9";
            }
        }
        private void bt_pi_Click(object sender, EventArgs e)
        {
            int length = tb_resultat.Text.Length;

            if ((tb_resultat.Text == "0" && tb_resultat.Text != null) || operateur.Contains(tb_resultat.Text))
            {
                tb_resultat.Text = Convert.ToString(Math.PI);
                tb_historique.Text = tb_historique.Text + Convert.ToString(Math.PI);
            }
            else
            {
                tb_historique.Text = tb_historique.Text.Remove(tb_historique.Text.Length - length);
                tb_historique.Text = tb_historique.Text + Convert.ToString(Math.PI);
                tb_resultat.Text = Convert.ToString(Math.PI);
            }
        }

        private void bt_cos_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) || tb_resultat.Text == null || tb_resultat.Text == "0")
            {

            }
            else
            {
                double angle = Math.PI * Convert.ToDouble(tb_resultat.Text) / 180.0;
                double cos = Math.Cos(angle);
                cos = Math.Round(cos, 10);
                
                tb_historique.Text = "cos(" + tb_resultat.Text + ")";

                tb_resultat.Text = Convert.ToString(cos);
                calcul.Add(tb_resultat.Text);

                calcul.Add("+");
            }
        }

        private void bt_sin_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) || tb_resultat.Text == null || tb_resultat.Text == "0")
            {

            }
            else
            {
                double angle = Math.PI * Convert.ToDouble(tb_resultat.Text) / 180.0;
                double sin = Math.Sin(angle);
                sin = Math.Round(sin, 10);

                tb_historique.Text = "sin(" + tb_resultat.Text + ")";

                tb_resultat.Text = Convert.ToString(sin);
            }
        }

        private void bt_tan_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) || tb_resultat.Text == null || tb_resultat.Text == "0")
            {

            }
            else
            {
                double angle = Math.PI * Convert.ToDouble(tb_resultat.Text) / 180.0;
                double tan = Math.Tan(angle);
                tan = Math.Round(tan, 5);

                tb_historique.Text = "tan(" + tb_resultat.Text + ")";

                tb_resultat.Text = Convert.ToString(tan);
            }
        }

        private void bt_factoriel_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) || tb_resultat.Text == null || tb_resultat.Text == "0")
            {
                
            }
            else
            {
                double factoriel = Factoriel(Convert.ToDouble(tb_resultat.Text));
                tb_resultat.Text = Convert.ToString(factoriel);
                tb_historique.Text = tb_historique.Text + "!";
            }
        }
            

        private void bt_racinecarre_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) || tb_resultat.Text == null || tb_resultat.Text == "0")
            {

            }
            else
            {
                int length = tb_resultat.Text.Length;
                double racinecarree = RacineCarree(Convert.ToDouble(tb_resultat.Text));
                Console.WriteLine(tb_historique.Text);
                tb_historique.Text = tb_historique.Text.Remove(tb_historique.Text.Length - length);
                Console.WriteLine(tb_historique.Text);

                tb_historique.Text = tb_historique.Text + "√" + tb_resultat.Text;

                tb_resultat.Text = Convert.ToString(racinecarree);


            }
        }


        private void bt_virgule_Click(object sender, EventArgs e) //Faire un contain virgule, pour en avoir qu'une.
        {
            if (operateur.Contains(tb_resultat.Text) || tb_resultat.Text.Contains(",") || tb_resultat.Text.Contains("."))
            {
                tb_resultat.Text = tb_resultat.Text;
            }
            else
            {
                tb_resultat.Text = tb_resultat.Text + ",";
                tb_historique.Text = tb_historique.Text + ",";
            }


        }

        private void bt_aucarre_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) || tb_resultat.Text == null || tb_resultat.Text == "0")
            {

            }
            else
            {
                double aucarre = AuCarre(Convert.ToDouble(tb_resultat.Text));
                tb_resultat.Text = Convert.ToString(aucarre);
                tb_historique.Text = tb_historique.Text + "²";
            }
        }

        private void bt_addition_Click(object sender, EventArgs e)
        {
            if(operateur.Contains(tb_resultat.Text))
            {
                string historique = tb_historique.Text;
                historique = historique.Remove(historique.Length - 1);
                tb_historique.Text = historique + "+";
                calcul.RemoveAt(calcul.Count - 1);
                calcul.Add("+");
            }
            else{
                calcul.Add(tb_resultat.Text);
                tb_historique.Text = tb_historique.Text + "+";
                calcul.Add("+");
            }

            tb_resultat.Text = "+";


        }

        private void bt_soustraction_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) && operateur.Contains(calcul.Last()))
            {
                string historique = tb_historique.Text;
                historique = historique.Remove(historique.Length - 1);
                tb_historique.Text = historique + "-";
                calcul.RemoveAt(calcul.Count - 1);
                calcul.Add("-");

            }
            else
            {
                calcul.Add(tb_resultat.Text);
                tb_historique.Text = tb_historique.Text + "-";
                calcul.Add("-");
            }

            tb_resultat.Text = "-";

        }

        private void bt_multiplication_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) && operateur.Contains(calcul.Last()))
            {
                string historique = tb_historique.Text;
                historique = historique.Remove(historique.Length - 1);
                tb_historique.Text = historique + "*";
                calcul.RemoveAt(calcul.Count - 1);
                calcul.Add("*");
            }
            else
            {
                calcul.Add(tb_resultat.Text);
                tb_historique.Text = tb_historique.Text + "*";
                calcul.Add("*");
            }

            tb_resultat.Text = "*";
        }

        private void bt_division_Click(object sender, EventArgs e)
        {
            if (operateur.Contains(tb_resultat.Text) && operateur.Contains(calcul.Last()))
            {
                string historique = tb_historique.Text;
                historique = historique.Remove(historique.Length - 1);
                tb_historique.Text = historique + "/";
                calcul.RemoveAt(calcul.Count - 1);
                calcul.Add("/");

            }
            else
            {
                calcul.Add(tb_resultat.Text);
                tb_historique.Text = tb_historique.Text + "/";
                calcul.Add("/");
            }

            tb_resultat.Text = "/";
        }
        private void bt_chiffrenegatif_Click(object sender, EventArgs e)
        {
          
            if (tb_resultat.Text.StartsWith("-"))
            {
                tb_resultat.Text = tb_resultat.Text.Remove(0, 1);
                tb_resultat.Text = "" + tb_resultat.Text;
                tb_historique.Text = tb_historique.Text.Remove(tb_historique.Text.Length - tb_resultat.Text.Length) + tb_resultat.Text;
            }
            else
            {
                tb_historique.Text = tb_historique.Text.Remove(tb_historique.Text.Length - (tb_resultat.Text.Length)) + "-" + tb_resultat.Text;
                tb_resultat.Text = "-" + tb_resultat.Text;

                Console.WriteLine(tb_historique.Text.Length);
                Console.WriteLine(tb_resultat.Text.Length);
            }

        }



        private void bt_egal_Click(object sender, EventArgs e)
        {
            if(operateur.Contains(tb_resultat.Text))
            {

            }
            else
            {
                calcul.Add(tb_resultat.Text);
            }


            calcultmp = calcul;


            try
            {
                tb_resultat.Text = Convert.ToString(FaireCalcul(calcul));
            }
             catch (ArithmeticException err)
            {
                MessageBox.Show(err.Message);
                bt_clearall.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                bt_clearall.PerformClick();
            }

            calcul = calcultmp;
            calcultmp.Clear();



        }


        private void bt_supprimer_Click(object sender, EventArgs e)
        { //Supprime juste la ligne
            if (tb_historique.Text.Length > 0)
            {
                tb_historique.Text = tb_historique.Text.Substring(0, tb_historique.Text.Length - tb_resultat.Text.Length);

                tb_resultat.Text = "0";
            }

        }

        private void bt_clearall_Click(object sender, EventArgs e)
        { //Supprime tout le calcul
            calcul.Clear();
            tb_resultat.Text = "0";
            tb_historique.Text = "";
        }

        private void Calculatrice_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    e.Handled = true;
                    bt_1.PerformClick();
                    break;
                case Keys.NumPad2:
                    e.Handled = true;
                    bt_2.PerformClick();
                    break;
                case Keys.NumPad3:
                    e.Handled = true;
                    bt_3.PerformClick();
                    break;
                case Keys.NumPad4:
                    e.Handled = true;
                    bt_4.PerformClick();
                    break;
                case Keys.NumPad5:
                    e.Handled = true;
                    bt_5.PerformClick();
                    break;
                case Keys.NumPad6:
                    e.Handled = true;
                    bt_6.PerformClick();
                    break;
                case Keys.NumPad7:
                    e.Handled = true;
                    bt_7.PerformClick();
                    break;
                case Keys.NumPad8:
                    e.Handled = true;
                    bt_8.PerformClick();
                    break;
                case Keys.NumPad9:
                    e.Handled = true;
                    bt_9.PerformClick();
                    break;
                case Keys.NumPad0:
                    e.Handled = true;
                    bt_0.PerformClick();
                    break;
                case Keys.Add:
                    e.Handled = true;
                    bt_addition.PerformClick();
                    break;
                case Keys.Subtract:
                    e.Handled = true;
                    bt_soustraction.PerformClick();
                    break;
                case Keys.Multiply:
                    e.Handled = true;
                    bt_multiplication.PerformClick();
                    break;
                case Keys.Divide:
                    e.Handled = true;
                    bt_division.PerformClick();
                    break;
                case Keys.Enter:
                    e.Handled = true;
                    bt_egal.PerformClick();
                    break;

            }
        }


    }
}



