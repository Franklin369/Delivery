using System;

using Delivery.Vistas.Detalle;
using Delivery.Vistas.Menuprincipal;

using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Delivery
  {
  public partial class App : Application
    {
    public App()
      {
      InitializeComponent();

      MainPage=new SharedTransitionNavigationPage(new Principal());
      }

    protected override void OnStart()
      {
      }

    protected override void OnSleep()
      {
      }

    protected override void OnResume()
      {
      }
    }
  }
