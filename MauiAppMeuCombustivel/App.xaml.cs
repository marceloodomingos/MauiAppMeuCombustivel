namespace MauiAppMeuCombustivel // Define o namespace da aplicação, organizando as classes.
{
    public partial class App : Application // Define a classe App, que herda de Application, representando a aplicação em si.
    {
        public App() // Construtor da classe App.
        {
            InitializeComponent(); // Inicializa os componentes da aplicação definidos no XAML.

            MainPage = new AppShell(); // Define a página principal da aplicação como uma nova instância de AppShell.
        }
    } // Fecha a classe App
} // Fecha o namespace