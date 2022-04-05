namespace FormularioEncontrarNumero
{
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text != "")
            {
                lstLista.Items.Add(txtnumero.Text);//incorporar lo que digitemos en txtnumero
                txtnumero.Clear();
                txtnumero.Focus();
            }
        }
        //metodo que devuelve el mayor numero dentro de la lista
        int MayorValor()
        {
            int aux;
            int tamanio = lstLista.Items.Count;
            int[] valores = new int[tamanio];
            for (int i = 0; i < tamanio; i++)
            {
                valores[i] = int.Parse(lstLista.Items[i].Text);
            }
            for (int x = 0; x < lstLista.Items.Count; x++)
            {

                for (int j = 0; j < lstLista.Items.Count - 1; j++)
                {

                    if (valores[j] > valores[j + 1])
                    {
                        aux = valores[j];
                        valores[j] = valores[j + 1];
                        valores[j + 1] = aux;
                    }
                }
            }
            return valores[valores.Length - 1];
        }
        //metodo que devuelve el numero menor que se encuentra en el los datos de la lista
        int MenorValor()
        {
            int aux;
            int tamanio = lstLista.Items.Count;
            int[] valores = new int[tamanio];
            for (int i = 0; i < tamanio; i++)
            {
                valores[i] = int.Parse(lstLista.Items[i].Text);
            }
            for (int x = 0; x < lstLista.Items.Count; x++)
            {

                for (int j = 0; j < lstLista.Items.Count - 1; j++)
                {

                    if (valores[j] > valores[j + 1])
                    {
                        aux = valores[j];
                        valores[j] = valores[j + 1];
                        valores[j + 1] = aux;
                    }
                }
            }
            return valores[0];
        }
        //metodo evento que calcula el mayor de los pares negativos
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000;
            for(int i = 0; i < lstLista.Items.Count; i++)
            {
                int numero = int.Parse(lstLista.Items[i].Text);
                if (numero < 0 && numero%2==0)
                {
                    if (numero >= mayorneg)
                    {
                        mayorneg = numero;
                    }
                }
                txtresultado.Text = mayorneg.ToString();
            }
        }

        private void btnMayorNumero_Click(object sender, EventArgs e)
        {
            int mayorNumero;
            mayorNumero = MayorValor();
            txtMayorNumero.Text = mayorNumero.ToString();
        }

        private void btnMenorNumero_Click(object sender, EventArgs e)
        {
            int menorNumero;
            menorNumero = MenorValor();
            txtMenorNumero.Text=menorNumero.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}