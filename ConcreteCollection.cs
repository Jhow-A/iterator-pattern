using System.Collections.Generic;

namespace IteratorPattern
{
    // Concrete Aggregate
    public class ConcreteCollection : IAbstractCollection
    {
        private readonly List<Cliente> listaClientes = new();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listaClientes.Count; }
        }

        public void AddCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public Cliente GetCliente(int posicao)
        {
            return listaClientes[posicao];
        }
    }
}
