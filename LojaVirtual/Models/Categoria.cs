using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }

        /*Slug
         * Nome: Informática, telefone sem fio
         * Slug: informatica, telefone-sem-fio
         * www.lojavirtual.com.br/categoria/1 --- url normal
         * www.lojavirtual.com.br/categoria/informatica  --- url amigável e com slug
         */

        public int? CategoriaPaiId { get; set; }

        /*Auto-relascionamento
         * Id-Nome Pai=valor
         * 1-Informática P=null
         * 2-Mouse P=1
         * 3-Mouse sem fio P=2
         * 4-Mouse Gamer P=2
         */

        /*ORM- EntityFrameworkCore*/
         [ForeignKey("CategoriaPaiId")]
        public virtual Categoria CategoriaPai { get; set; }
    }
}
