using System;
using System.Collections.Generic;

Console.WriteLine("-----Gerenciador de Tarefas-----");

List<string> tarefas = new List<string>();
int resposta;

do
{

Console.WriteLine("Selecione a opção desejada");
Console.WriteLine();

Console.WriteLine("1- Adicionar uma tarefa");
Console.WriteLine("2- Listar atividades registradas");
Console.WriteLine("3- Remover uma atividade");
Console.WriteLine("0- Encerrar");
Console.WriteLine();
Console.WriteLine("Opção: ");
resposta = int.Parse(Console.ReadLine());

switch (resposta)
{
    case 1:
        Console.WriteLine("A opção selecionada foi adicionar uma atividade");
        Console.WriteLine("Por favor, digite a atividade que queira inserir: ");
        string NovaAtividade = Console.ReadLine();
        tarefas.Add(NovaAtividade);
        Console.WriteLine("\nPressione qualquer tecla para continuar o programa...");
        Console.ReadKey();
        Console.WriteLine();
        break;
    case 2:
        Console.WriteLine("A opção selecionada foi listar atividades");
        Console.WriteLine("Essas foram todas as atividades listadas: ");
        /*
        percorrendo os elementos da lista tarefas com foreach:
        foreach (string i in tarefas)
        */
        for (int i = 0; i < tarefas.Count; i++)
        {
        Console.WriteLine($"{i} - {tarefas[i]}");
        }
        Console.WriteLine("\nPressione qualquer tecla para continuar o programa...");
        Console.ReadKey();
        break;
    case 3:
        Console.WriteLine("A opção selecionada foi remover uma atividade");
        Console.WriteLine();
        Console.WriteLine("Digite a posição(o número que vem antes do nome da atividade) da atividade que deseja remover: ");
        int indiceAtividade = int.Parse(Console.ReadLine());
        if(indiceAtividade >= 0 && indiceAtividade < tarefas.Count)
        {
            tarefas.RemoveAt(indiceAtividade);
            Console.WriteLine("Atividade excluída com sucesso");
        }
        else
        {                    
            Console.WriteLine("A atividade não foi encontrada");
        }
        Console.WriteLine("\nPressione qualquer tecla para continuar o programa...");
        Console.ReadKey();
        break;
    case 0:
        Console.WriteLine("Ecerrando");
        break;
    default:
        Console.WriteLine("A opção selecionada não existe");
        Console.WriteLine();
        break;
}
} while(resposta != 0);
/*
Criar um sistema de gerenciamento de tarefas
onde os seus requisitos são:
-adicionar uma nova tarefa
-listar todas as tarefas registradas
-remover uma tarefa
sair
*/