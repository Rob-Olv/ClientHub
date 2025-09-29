using ClientHub.App.Forms;
using ClientHub.Application;
using ClientHub.Infrastructure;
using System;
using WinApp = System.Windows.Forms;

namespace ClientHub.App
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WinApp.Application.EnableVisualStyles();
            WinApp.Application.SetCompatibleTextRenderingDefault(false);

            var dbContext = new AppDbContext();

            var clienteRepository = new ClienteRepository(dbContext);
            var cidadeRepository = new CidadeRepository(dbContext);
            var estadoRepository = new EstadoRepository(dbContext);

            var clienteService = new ClienteService(clienteRepository);
            var cidadeService = new CidadeService(cidadeRepository);
            var estadoService = new EstadoService(estadoRepository);
            var relatorioService = new RelatorioService(clienteRepository);

            var homeForm = new Home(clienteService, cidadeService, estadoService, relatorioService);

            WinApp.Application.Run(homeForm);
        }
    }
}
