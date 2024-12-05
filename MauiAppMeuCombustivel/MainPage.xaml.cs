namespace MauiAppMeuCombustivel // Define o namespace da aplicação, que organiza as classes.
{
    public partial class MainPage : ContentPage // Define a classe MainPage, que herda de ContentPage, representando uma página de conteúdo.
    {
        public MainPage() // Construtor da classe MainPage.
        {
            InitializeComponent(); // Inicializa os componentes da interface (XAML).
        }

        private void Button_Clicked(object sender, EventArgs e) // Método chamado quando um botão é clicado.
        {
            try // Inicia um bloco que tentará executar o código que pode gerar exceções.
            {
                double etanol = Convert.ToDouble(txt_etanol.Text); // Converte o texto da entrada de etanol para um número double.
                double gasolina = Convert.ToDouble(txt_gasolina.Text); // Converte o texto da entrada de gasolina para um número double.

                string msg = ""; // Inicializa uma string para armazenar a mensagem de resultado.

                // Verifica se o preço do etanol é menor ou igual a 70% do preço da gasolina.
                if(etanol <= (gasolina * 0.7))
                {
                    msg = "O Etanol está compensando."; // Define a mensagem se o etanol for compensador.
                } 
                else
                {
                    msg = "A Gasolina está compensando."; // Define a mensagem se a gasolina for compensadora.
                }

                // Exibe um alerta com a mensagem calculada.
                DisplayAlert("Calculado", msg, "OK");
            } 
            catch (Exception ex) // Captura qualquer exceção que ocorra no bloco try.
            {
                // Exibe um alerta com a mensagem de erro.
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } // Fecha o método do botão
    } // Fecha a classe MainPage
} // Fecha o namespace