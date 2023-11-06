namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cislo = textBox1.Text;
            cislo = cislo.Replace(" ", "");

            if (long.TryParse(cislo, out long cislo2))
            {
                string dvoj = "";

                while (cislo2 > 0)
                {
                    dvoj = (cislo2 % 2) + dvoj;
                    cislo2 = cislo2 / 2;
                }

                MessageBox.Show("Dvojková soustava je: " + dvoj);
                textBox2.Text = dvoj;
            }
            else
            {
                MessageBox.Show("Vstupní hodnota není platné èíslo.");
            }
        }

        private long CustomPower(int zaklad, int exponent)
        {
            long result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= zaklad;
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string binaryInput = textBox2.Text;
            long vysledek = 0;
            int pozice = 0;

            for (int i = binaryInput.Length - 1; i >= 0; i--)
            {

                if (binaryInput[i] == '1')
                {

                    vysledek += CustomPower(2, pozice);
                }
                pozice++;
            }

            MessageBox.Show("Výsledek je: " + vysledek);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hexString = textBox3.Text.ToString();
            long vysledek = 0;
            long vaha = 1;

            for (int i = hexString.Length - 1; i >= 0; i--)
            {
                // Cyklus prochází hexadecimální vstup od konce.

                char znak = hexString[i];
                long hodnota = 0;

                if (znak >= '0' && znak <= '9')
                {
                    // Pokud je znak èíslice 0-9, pøevedeme ho na odpovídající èíselnou hodnotu.

                    hodnota = znak - '0';
                }
                else if (znak >= 'A' && znak <= 'F')
                {
                    // Pokud je znak písmeno A-F, pøevedeme ho na odpovídající èíselnou hodnotu.

                    hodnota = 10 + (znak - 'A');
                }
                else if (znak >= 'a' && znak <= 'f')
                {
                    // Podobnì, pokud je znak písmeno a-f (malá písmena), pøevedeme ho na èíselnou hodnotu.

                    hodnota = 10 + (znak - 'a');
                }

                vysledek += hodnota * vaha;
                // Pøidáme hodnotu znaku, váha se postupnì zvyšuje pro každý znak.
                vaha *= 16;
                // Váha se násobí 16 pro každý další znak, což odpovídá pozici v hexadecimálním èísle.
            }

            MessageBox.Show("Výsledek je: " + vysledek);
            textBox4.Text = vysledek.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cislo = textBox4.Text.ToString();
            long input = long.Parse(cislo);
            string neco = "";

            while (input > 0)
            {
                // Cyklus pro pøevod èísla na hexadecimální øetìzec.

                long zbytek = input % 16;
                char znak;

                if (zbytek < 10)
                {
                    // Pokud zbytek je menší než 10, pøevedeme ho na odpovídající èíslici.

                    znak = (char)('0' + zbytek);
                }
                else
                {
                    // Pokud zbytek je 10 nebo vìtší, pøevedeme ho na odpovídající písmeno A-F.

                    znak = (char)('A' + (zbytek - 10));
                }

                neco = znak + neco;
                // Pøidáme znak k výslednému øetìzci, ale na zaèátek, abychom vytvoøili správnì zpáteèní øetìzec.
                input /= 16;
                // Dìlíme èíslo 16, abychom postupnì pøevádìli zbytek na jednotlivé znaky hexadecimálního øetìzce.
            }

            MessageBox.Show("Výsledek je: " + neco);
        }
    }
}