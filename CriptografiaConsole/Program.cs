using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CriptografiaConsole
{
    class Program
    {

        const string chave = "14441";

        static void Main(string[] args)
        {

            var mensagemJson = JsonConvert.SerializeObject(
                new Produto
                {
                    Id = 140,
                    Nome = " Meu primeiro Teste"
                });

            var valorCriptografado = CriptografiaMyDrugs.Seguranca.Criptografar(mensagemJson, chave);


            var valorDecriptografado = CriptografiaMyDrugs.Seguranca.DesCriptografar(valorCriptografado, chave);

            if (!string.IsNullOrWhiteSpace(valorDecriptografado))
            {
                var Objetoproduto = JsonConvert.DeserializeObject<Produto>(valorDecriptografado);
            }



            // var teste1 = CriptografiaValdir.Seguranca.Criptografar("Teste Criptografia", "@@teste44");

            var valor = "UUVCMFpYTjBaVFEwUFQwOVBUMVdSMVo2WkVkVloxRXpTbkJqU0ZKMldqTkthRnB0YkdnPQ==";

            // var respostaTeste = CriptografiaValdir.Seguranca.DesCriptografar("UUVCMFpYTjBaVFEwUFQwOVBUMVdSMVo2WkVkVloxRXpTbkJqU0ZKMldqTkthRnB0YkdnPQ==", "@@teste44");

        }
    }
}
