using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api_GerenciadoraDeTarefas.Context;
using Api_GerenciadoraDeTarefas.Models;

namespace Api_GerenciadoraDeTarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options):base (options){

        }
        public DbSet<Tarefa> Tarefas{get; set;}
    }
}