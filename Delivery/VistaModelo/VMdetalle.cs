using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Delivery.Modelo;
using Delivery.VistaModelo;

using Xamarin.Forms;

namespace Delivery.VistaModelo
  {
  internal class VMdetalle:BaseViewModel
    {
    #region VARIABLES
    string _Texto;
    public Mplatos ParametrosRecibe { get; set; }
    #endregion
    #region CONSTRUCTOR
    public VMdetalle(INavigation navigation,Mplatos parametrosTrae)
      {
      Navigation=navigation;
      ParametrosRecibe=parametrosTrae;
      }
    #endregion
    #region OBJETOS
    public string Texto
      {
      get { return _Texto; }
      set { SetValue(ref _Texto,value); }
      }
    #endregion
    #region PROCESOS
    private async void Volver()
      {
      await Navigation.PopAsync();
      }
    public void ProcesoSimple()
      {

      }
    #endregion
    #region COMANDOS
    public ICommand Volvercommand => new Command(Volver);
    public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
    #endregion
    }
  }
