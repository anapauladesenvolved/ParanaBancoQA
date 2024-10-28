using TesteAutomatizado.PageObject_Botoes;
using TesteAutomatizado.PageObject_Grid;
using TesteAutomatizado.PageObject_Navegadores;

namespace TesteAutomatizado
{
    public class ExecutarTestes : NavegaNoBrowser
    {
        private readonly MetodoClicarNosBotoes _botoes;
        private readonly MetodosNavegarNaGrid _grid;

        public ExecutarTestes() : base()
        {
            _grid = new MetodosNavegarNaGrid(_webDriver);
            _botoes = new MetodoClicarNosBotoes(_webDriver);
        }

        [Fact]
        public void ExecutarTestesJuntos()
        {

            _botoes.ClicarNosBotoes();
            _grid.NavegarNaGrid();

            _webDriver.Quit();

        }

    }
}