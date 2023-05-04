using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPalhaço
{
    public class Palhaço
    {
        private string nome="";
        private double altura=0;
        private string endereço="";
        private string telefone = "";
        private string email = "";
        private string cpf = "";
        private string rg = "";

        public string Nome { get => nome; set => nome = value; }
        public double Altura { get => altura; set => altura = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }


        public void FalarSobreVc()
        {
            String str;
            str="Nome:"+Nome +"\nAltura:"+Altura+"\n"+"Endereço:"+Endereço+"\nTelefone:"+telefone+"\n"+"E-mail:"+email+"\nCPF:"+cpf+"\nIdentidade:"+rg;
            MessageBox.Show(str, "Dados do palhaço");
        }
    }
    
}
