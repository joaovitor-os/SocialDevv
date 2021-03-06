using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class UsuarioController
    {
        // Inserindo usuário no banco de dados
        public static void CadastrarUsuario(
            string nomeUsuario,
            string loginUsuario,
            string senhaUsuario,
            string emailUsuario,
            string descricaoUsuario,
            string cidadeUsuario
            )
        {
            new Usuario(
                nomeUsuario,
                loginUsuario,
                senhaUsuario,
                emailUsuario,
                descricaoUsuario,
                cidadeUsuario);
        }

        // Acessando usuário no BD pelo ID
        public static Usuario GetUsuario(int idUsuario)
        {
            return Usuario.GetUsuario(idUsuario);
        }

        // Acessando todos usuários
        public static List<Usuario> GetUsuarios()
        {
            return Usuario.GetUsuarios();
        }

        // Acessando o método de alteração
        public static void AlterarUsuario(
            int idUsuario,
            string nomeUsuario,
            string loginUsuario,
            string senhaUsuario,
            string emailUsuario,
            string descricaoUsuario,
            string cidadeUsuario
            )
        {
            Usuario.AlterarUsuario(
            idUsuario,
            nomeUsuario,
            loginUsuario,
            senhaUsuario,
            emailUsuario,
            descricaoUsuario,
            cidadeUsuario
            );
        }

        // Acessando o método de deleção
        public static void DeletarUsuario(int idUsuario)
        {
            Usuario.DeletarUsuario(idUsuario);
        }

        public static bool CampoCadastroUsuario(
            string nomeUsuario,
            string loginUsuario,
            string senhaUsuario,
            string emailUsuario,
            string descricaoUsuario,
            string cidadeUsuario)
        {
            if ((nomeUsuario == string.Empty)
                || (loginUsuario == string.Empty)
                || (senhaUsuario == string.Empty)
                || (emailUsuario == string.Empty)
                || (descricaoUsuario == string.Empty)
                || (cidadeUsuario == string.Empty))
            {
                return false;
            }
            return true;
        }

        public static bool CampoLogin(string LoginUsuario, string SenhaUsuario)
        {
            if (LoginUsuario == "" || SenhaUsuario == "")
            {
                return false;
            }
            return true;
        }
    }
}
