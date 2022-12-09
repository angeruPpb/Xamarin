using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace confe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Curriculum : ContentPage
	{
		public Curriculum (string name, string ocupation, string birthday, string email, 
						string phone, string nacionalidad, string level, string perfil)
		{
			InitializeComponent ();
            F_nombre.Text = name;
            F_ocupacion.Text = ocupation;
            F_edad.Text = "|| " + birthday + " || " + name;
			F_email.Text = "E-mail: " + email;
			F_telefono.Text = "Telefono: " + phone;
			F_pais.Text = "Nacionalidad: " + nacionalidad;
			F_level.Text = "Ingles: " + level;
			F_perfil.Text = perfil;
        }

        private void btnregresar_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}