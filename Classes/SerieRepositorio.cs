using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        //Variavel lista que vai conter todas as series
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();   //Executa o metodo excluir que muda a flag para true
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);   //Adicionar o objeto entidade
        }

        public List<Serie> Lista()
        {
            return listaSerie;      //Retorna a lista
        }

        public int ProximoId()
        {
            return listaSerie.Count;    //Ao add 1 dado na lista o count vai para o proximo indice
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}