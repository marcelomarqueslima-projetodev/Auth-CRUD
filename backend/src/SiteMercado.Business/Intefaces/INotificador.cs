using System.Collections.Generic;
using SiteMercado.Business.Notificacoes;

namespace SiteMercado.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}