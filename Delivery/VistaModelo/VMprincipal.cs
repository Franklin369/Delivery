using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Delivery.Datos;
using Delivery.Modelo;
using Delivery.VistaModelo;

using Xamarin.Forms;

namespace Delivery.VistaModelo
  {
  public class VMprincipal : BaseViewModel
    {
    #region VARIABLES
    ObservableCollection<Mplatos> _listaplatos;
    #endregion
    #region CONSTRUCTOR
    public VMprincipal(INavigation navigation)
      {
      Navigation=navigation;
      Listarplatos();
      }
    #endregion
    #region OBJETOS
    public ObservableCollection<Mplatos> Listaplatos
      {
      get { return _listaplatos; }
      set { SetValue(ref _listaplatos,value); }
      }
    #endregion
    #region PROCESOS
    public void Listarplatos()
      {
      var funcion = new Dplatos();
      Listaplatos=funcion.Listarplatos();
      }
    public void ProcesoSimple()
      {

      }
    #endregion
    #region COMANDOS
   
    public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
    #endregion
    }
  }
