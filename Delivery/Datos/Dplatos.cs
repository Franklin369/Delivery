using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Delivery.Modelo;

namespace Delivery.Datos
  {
  public class Dplatos
    {
    public  ObservableCollection<Mplatos> Listarplatos()
      {
      return new ObservableCollection<Mplatos>()
        {
        new Mplatos()
          {
          descripcion="plato 1",
          precio="$14.45",
          icono="https://i.ibb.co/0cpFpv4/IMG01.png",
         
          },
         new Mplatos()
          {
          descripcion="plato 2",
          precio="$54.45",
          icono="https://i.ibb.co/ZBnj944/IMG02.png",
          
          },
          new Mplatos()
          {
          descripcion="plato 3",
          precio="$23.45",
          icono="https://i.ibb.co/H4J330b/IMG04.png"
          
          }
        };
      }
    }
  }
