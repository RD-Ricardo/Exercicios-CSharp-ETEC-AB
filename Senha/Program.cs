using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "1234abcd";
            string entraSenha;
            Console.WriteLine("---------");
            Console.WriteLine("--SENHA--");
            Console.WriteLine("---------\n");
            Console.Write("Olá, usuário. Por favor, digite sua senha:");
            entraSenha = Convert.ToString(Console.ReadLine());
            if(entraSenha == senha){
                Console.WriteLine("Acesso permitido");
            }
            else{
                Console.WriteLine("\nAcesso negado");
            }
        }

    }
}
