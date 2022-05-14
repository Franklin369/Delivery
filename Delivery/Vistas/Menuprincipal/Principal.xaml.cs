using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Delivery.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Delivery.Vistas.Menuprincipal
  {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Principal : ContentPage
    {
    public Principal()
      {
      InitializeComponent();
      BindingContext=new VMprincipal(Navigation);
      }
    }
  }