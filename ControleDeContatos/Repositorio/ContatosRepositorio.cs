using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public class ContatosRepositorio : IContatosRepositorio
    {
        private readonly ControleDeContatosContext _context;
        public ContatosRepositorio(ControleDeContatosContext context)
        {
            this._context = context;
        }

        public ContatoModel ListarPorId(int id)
        {
            return _context.ContatoModel.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _context.ContatoModel.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.ContatoModel.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _context.ContatoModel.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;
        } 

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização");
            _context.ContatoModel.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
