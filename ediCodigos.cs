/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 19/05/2025
 * Time: 08:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace iiiuuyu
{
	class Program
	{
		public static void Main(string[] args)
		{  
			//Solicite ao usuário que digite dois números inteiros
			Console.WriteLine("Digite o primeiro número inteiro:");
			int numero1 = int.Parse(Console.ReadLine());
			
			
			
			Console.Write("Digite o segundo número inteiro: ");
			int numero2 = int.Parse(Console.ReadLine());
			
			//Calcula a diferença absoluta
			int diferenca = Math.Abs(numero1 - numero2);
			
			//Verifica se a diferença é menor ou igual a 10
			if (diferenca <= 10)
				
			{
				Console.WriteLine("A diferença entre os números é {0}, que é menor ou igual a 10", diferenca);
				
			}
			
			else
				
			{
				Console.WriteLine("A diferença entre os números é {0}, que é maior ou igual a 10", diferenca);
				
			}
			
			// Aguarde o usuario pressionar uma tecla antes de sair
			Console.WriteLine("Pressione qualquer tecla para sair...");
			
			Console.ReadLine();
		}
	}
}