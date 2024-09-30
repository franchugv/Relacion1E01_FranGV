using Relacion1E01_FranGV.Clases;

namespace Relacion1E01_FranGV;

public partial class Ejercicio01 : ContentPage
{
	public Ejercicio01()
	{
		InitializeComponent();
	}


    private void ClickAcceder(object sender, EventArgs e)
    {
        // Recursos
        bool esValido = true;
        string mensajeError = "";
        Button boton = (Button)sender;

        // Reset Label
        LabelInfoUser.Text = "";
        LabelInfoUser.TextColor = Colors.White;


        // Proceso
        try
        {
            switch (boton.Text)
            {
                case "Acceder":
                    FuncionAcceder();
                    break;
            }
        }
        catch (Exception error)
        {
            esValido = false;
            mensajeError = error.Message;
        }
        finally
        {
            if(!esValido) MostrarError(mensajeError);
        }




    }
    
    private void FuncionAcceder()
    {
        // Instanciar Clase Persona
        Persona NuevaPersona = new Persona(entryNombre.Text, entryApellidos.Text, Metodos.ConvertirInt(entryEdad.Text));


        if (NuevaPersona.Edad >= 18)
        {
            string textoMayorEdad = $"{NuevaPersona.Apellidos}, {NuevaPersona.Nombre}:\n" +
            $"Tiene acceso al sistema";
            
            MostrarMensaje(textoMayorEdad);
            LabelInfoUser.Text = textoMayorEdad;
            LabelInfoUser.TextColor = Colors.Green;
        }
        else
        {
            string textoMenorEdad = $"{NuevaPersona.Apellidos}, {NuevaPersona.Nombre}:\n" +
            $"No tiene acceso al sistema";
           
            MostrarMensaje(textoMenorEdad);
            LabelInfoUser.Text = textoMenorEdad;
            LabelInfoUser.TextColor = Colors.Red;

        }
    }

    // UI
    public void MostrarError(string error)
	{
        DisplayAlert("Error", $"Error: {error}", "Ok");
	}

    public void MostrarMensaje(string cadena)
    {
        DisplayAlert("Mensaje", cadena, "Ok");
    }
}