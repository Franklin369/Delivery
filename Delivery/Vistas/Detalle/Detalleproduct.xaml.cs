using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Delivery.Modelo;
using Delivery.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Delivery.Vistas.Detalle
  {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Detalleproduct : ContentPage
    {
    public Detalleproduct(Mplatos parametros)
      {
      InitializeComponent();
      BindingContext=new VMdetalle(Navigation,parametros);
      }
    }
  }