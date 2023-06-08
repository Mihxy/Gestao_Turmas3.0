﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Turmas
{
    public class C_Alunos
    {
        public string? Nome { get; set; }
        public string? Género { get; set; }
        public string? Email { get; set; }
        public string? Contacto { get; set; }
        public int Número_Aluno { get; set; }
        public string? Turma { get; set; }
        public int Idade { get; set; }
        private DateTime? Data;
        public DateTime? Data_Nascimento
        {
            get
            {
                return Data;
            }
            set
            {
                Data = value;
                if (Data != null)
                {
                    TimeSpan tempoaux = DateTime.Now - Data.Value.Date;
                    DateTime tempoaux2 = new DateTime(tempoaux.Ticks);
                    int tempoaux3 = tempoaux2.Year;
                    Idade = tempoaux3 - 1;
                }

            }
        }
    }
}
