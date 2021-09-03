using System;

// Namespace é um pacote que abriga um conjunto de classes e soluções
namespace BasicApp
{
    public class Pilha
    {
        Position primeiro;

        // Método, que tem como parâmetro um obejeto:
        public void Empilha(object item) {
            primeiro = new Position(primeiro, item);
        }

        // Remove um item da Pilha 
        public object Desempilha() {
            if (primeiro == null) {
                throw new InvalidOperationException();
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        // Toda vez que um item é adicionado, ele entra em primeiro lugar empurrando os items adjacentes:
        class Position {

            // Referencia objeto proximo:
            public Position proximo;
            public object item;

            public Position(Position proximo, object item) {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}