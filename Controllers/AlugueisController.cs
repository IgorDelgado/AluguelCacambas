using Aluguel.Models;
using Aluguel.Models.Consulta;
using Aluguel.Models.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Controllers
{
    public class AlugueisController : Controller
    {
        private readonly Contexto  contexto;

        public AlugueisController(Contexto context)
        {
            contexto = context;
            
        }

        public IActionResult AgruparAlugueis()
        {
            IEnumerable<AlugaGrup> lstAlugueisAluga =
                from item in contexto.Alugueis
                
                .ToList()

                group item by new { item.NomeColaborador, item.Codigo, item.ID }
                into grupo
                orderby grupo.Key.NomeColaborador, grupo.Key.Codigo, grupo.Key.ID
                select new AlugaGrup
                {
                    NomeColaborador = grupo.Key.NomeColaborador,
                    CodigoCacamba = grupo.Key.Codigo,
                    


                };

                        return View(lstAlugueisAluga);
        }
















        public IActionResult ListarItensAluga()
        {

            IEnumerable<Itens> lstItens = from item in contexto.Alugueis

                                           
                                          .OrderBy(Data => Data.Data_aluguel)
                                          .ThenBy(nome => nome.NomeCliente)
                                          .ThenBy(id => id.ID)
                                          .ToList()
                                         
                                          select new Itens
                                          {
                                              ID = item.ID,
                                              NomeCliente = item.NomeCliente,
                                              Data_aluguel = item.Data_aluguel,
                                              Endereco = item.Endereco,
                                              Bairro = item.Bairro,
                                              Tamanho = item.Tamanho,
                                               Codigo = item.Codigo,
                                              Observacao = item.Observacao,
                                              NomeColaborador = item.NomeColaborador,
                                              Data_devolucao = item.Data_devolucao,
                                              Valor = item.Valor,
                                          };                                         
                                          
                                  return View(lstItens); 


        }


    }
}
