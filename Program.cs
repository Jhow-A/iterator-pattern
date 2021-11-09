using System;

namespace IteratorPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            var colecao = new ConcreteCollection();

            colecao.AddCliente(new Cliente("Gabriela", 18));
            colecao.AddCliente(new Cliente("Jhonathan", 21));
            colecao.AddCliente(new Cliente("Pedro", 19));
            colecao.AddCliente(new Cliente("Larissa", 22));

            Iterator iterator = colecao.CreateIterator();

            for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
                Console.WriteLine($"ID: {cliente.Id} & Nome: {cliente.Nome}");

        }
    }
}
