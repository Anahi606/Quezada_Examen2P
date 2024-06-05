namespace AnahiQuezadaNotes.Views;

public partial class AQControlDeUsuario : ContentPage
{
	public AQControlDeUsuario()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        string input = inputEntry.Text;
        int conteoDigito = 0;   
        int conteoLetra = 0;
        int conteoVocal = 0;
        int conteoMinuscula = 0;
        int conteoMayuscula = 0;
        int conteoTotal = input.Length;

        foreach (char c in input)
        {
            if(char .IsDigit(c))
            {
                conteoDigito++;
            }
            else if (char .IsDigit(c))
            {
                conteoLetra++;
                if (c.ToString().ToLower() == c.ToString())
                {
                    conteoMinuscula++;
                }
                else 
                { 
                    conteoMayuscula++;
                }
                if ("aeiou".Contains(char.ToLower(c)))
                {
                    conteoVocal++;
                }
            }
        }
        resultadoLabel.Text = $"Letras: {conteoLetra}\nNumeros: {conteoDigito}\nMayusculas: {conteoMayuscula}\nMiniuscula: {conteoMinuscula}\nVocales: {conteoVocal}\nTotal: {conteoTotal}";
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {

    }
}