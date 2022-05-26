using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Delivery.Datos;
using Delivery.Modelo;
using Delivery.VistaModelo;
using Delivery.Vistas.Detalle;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Plugin.SharedTransitions;
namespace Delivery.VistaModelo
  {
  public class VMprincipal : BaseViewModel
    {
    #region VARIABLES
    ObservableCollection<Mplatos> _listaplatos;
    ObservableCollection<Mcategorias> _listacategorias;
    #endregion
    #region CONSTRUCTOR
    public VMprincipal(INavigation navigation)
      {
      Navigation=navigation;
      Listarplatos();
      Listarcategorias();
      }
    #endregion
    #region OBJETOS
    public ObservableCollection<Mcategorias> Listacategorias
      {
      get { return _listacategorias; }
      set { SetValue(ref _listacategorias,value); }
      }
    public ObservableCollection<Mplatos> Listaplatos
      {
      get { return _listaplatos; }
      set { SetValue(ref _listaplatos,value); }
      }
    #endregion
    #region PROCESOS
    public void Listarcategorias()
      {
      var funcion = new Dcategorias();
      Listacategorias=funcion.Mostrarcategorias();
      }
    public void Seleccionar(Mcategorias parametros)
      {
      var index = Listacategorias
        .ToList()
        .FindIndex(p => p.categoria==parametros.categoria);
      if (index>-1)
        {
        Deseleccionar();
        Listacategorias[index].Select=true;
        Listacategorias[index].Color1="#8664FF";
        Listacategorias[index].Color2="#BBA8FF";
        Listacategorias[index].Textcolor="#ffffff";
        }
      }
    private void Deseleccionar()
      {
      Listacategorias.ForEach((item) =>
      {
        item.Select=false;
        item.Color1="#ffffff";
        item.Color2="#ffffff";
        item.Textcolor="#2F394B";
      });
      }
    public void Listarplatos()
      {
      var funcion = new Dplatos();
      Listaplatos=funcion.Listarplatos();
      }
    private async void SeleccionarPlato(Mplatos parametros)
      {
      
      var page = (App.Current.MainPage as SharedTransitionNavigationPage).CurrentPage;
      SharedTransitionNavigationPage.SetTransitionDuration(page,1000);
      SharedTransitionNavigationPage.SetBackgroundAnimation(page,BackgroundAnimation.SlideFromLeft);
      SharedTransitionNavigationPage.SetTransitionSelectedGroup(page,parametros.Id);
      await Navigation.PushAsync(new Detalleproduct(parametros));
      }

    #endregion
    #region COMANDOS

    public ICommand Seleccionarcommand => new Command<Mcategorias>(Seleccionar);
    public ICommand SeleccionarplatoCommand => new Command<Mplatos>(SeleccionarPlato);
    #endregion
    }
  }
