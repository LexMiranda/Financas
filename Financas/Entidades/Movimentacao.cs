using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financas.Entidades
{
    public class Movimentacao
    {
        [Key]
        public int MoviemntacaoID { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Tipo Tipo { get; set; }
        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }


    }
}