using System;
using System.Collections.Generic;
using System.Text;

using Delivery.VistaModelo;

namespace Delivery.Modelo
  {
  public class Mcategorias : BaseViewModel
    {
    public string categoria { get; set; }
    public string icono { get; set; }
    //objetos
    string _color1;
    string _color2;
    string _textcolor;
    bool _select;
    public bool Select
      {
      get { return _select; }
      set { SetValue(ref _select,value); }
      }
    public string Color1
      {
      get { return _color1; }
      set { SetValue(ref _color1,value); }
      }
    public string Color2
      {
      get { return _color2; }
      set { SetValue(ref _color2,value); }
      }
    public string Textcolor
      {
      get { return _textcolor; }
      set { SetValue(ref _textcolor,value); }
      }
    }
  }
