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

                MessageBox.Show("Dvojkov� soustava je: " + dvoj);
                textBox2.Text = dvoj;
            }
            else
            {
                MessageBox.Show("Vstupn� hodnota nen� platn� ��slo.");
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

            MessageBox.Show("V�sledek je: " + vysledek);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hexString = textBox3.Text.ToString();
            long vysledek = 0;
            long vaha = 1;

            for (int i = hexString.Length - 1; i >= 0; i--)
            {
                // Cyklus proch�z� hexadecim�ln� vstup od konce.

                char znak = hexString[i];
                long hodnota = 0;

                if (znak >= '0' && znak <= '9')
                {
                    // Pokud je znak ��slice 0-9, p�evedeme ho na odpov�daj�c� ��selnou hodnotu.

                    hodnota = znak - '0';
                }
                else if (znak >= 'A' && znak <= 'F')
                {
                    // Pokud je znak p�smeno A-F, p�evedeme ho na odpov�daj�c� ��selnou hodnotu.

                    hodnota = 10 + (znak - 'A');
                }
                else if (znak >= 'a' && znak <= 'f')
                {
                    // Podobn�, pokud je znak p�smeno a-f (mal� p�smena), p�evedeme ho na ��selnou hodnotu.

                    hodnota = 10 + (znak - 'a');
                }

                vysledek += hodnota * vaha;
                // P�id�me hodnotu znaku, v�ha se postupn� zvy�uje pro ka�d� znak.
                vaha *= 16;
                // V�ha se n�sob� 16 pro ka�d� dal�� znak, co� odpov�d� pozici v hexadecim�ln�m ��sle.
            }

            MessageBox.Show("V�sledek je: " + vysledek);
            textBox4.Text = vysledek.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cislo = textBox4.Text.ToString();
            long input = long.Parse(cislo);
            string neco = "";

            while (input > 0)
            {
                // Cyklus pro p�evod ��sla na hexadecim�ln� �et�zec.

                long zbytek = input % 16;
                char znak;

                if (zbytek < 10)
                {
                    // Pokud zbytek je men�� ne� 10, p�evedeme ho na odpov�daj�c� ��slici.

                    znak = (char)('0' + zbytek);
                }
                else
                {
                    // Pokud zbytek je 10 nebo v�t��, p�evedeme ho na odpov�daj�c� p�smeno A-F.

                    znak = (char)('A' + (zbytek - 10));
                }

                neco = znak + neco;
                // P�id�me znak k v�sledn�mu �et�zci, ale na za��tek, abychom vytvo�ili spr�vn� zp�te�n� �et�zec.
                input /= 16;
                // D�l�me ��slo 16, abychom postupn� p�ev�d�li zbytek na jednotliv� znaky hexadecim�ln�ho �et�zce.
            }

            MessageBox.Show("V�sledek je: " + neco);
        }
    }
}