using System.Security.Cryptography;
using System.Text;
using System;

namespace Biblioteca.Models
{
    public static class Criptografo  // Criptografa a senha, para nao mostrar na tela
    {
        public static string TextoCriptografado(string textoClaro)
        {
            MD5 MD5Hasher = MD5.Create(); // o MD5 que transforma o texto em criptografia, ou numa Hash

            byte[] By = Encoding.Default.GetBytes(textoClaro);
            byte[] bytesCriptografado = MD5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();

            foreach(byte b in bytesCriptografado)
            {
                string DebugB = b.ToString("x2");
                SB.Append(DebugB);
            }

            return SB.ToString();
        }
    }
}