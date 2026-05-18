public partial class MainPage : ContentPage
{
    int totalPassos = 0;
    int metaAtual = 100; // Meta inicial (ex: 100 passos)

    public MainPage()
    {
        InitializeComponent();
        // IniciarSensorDePassos(); // Comentei para teste, pode descomentar depois
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        totalPassos++;
        AtualizarInterface();
    }

    private void AtualizarInterface()
    {
        double distancia = totalPassos * 0.0008; // Cada passo = ~0.8 metros
        ProgressoBar.Progress = (double)totalPassos / metaAtual;
        ResultadoLabel.Text = $"{totalPassos} passos / {distancia:F2} km";

        // Atualiza a imagem do Shadow
        if (totalPassos >= metaAtual * 3)
            ShadowImage.Source = "shadow_super.png";
        else if (totalPassos >= metaAtual)
            ShadowImage.Source = "shadow_correndo.png";
        else
            ShadowImage.Source = "shadow.png"; // Imagem padrão
    }
}