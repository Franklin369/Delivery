using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Modelo
  {
  public class Mplatos
    {
 public Mplatos()
      {
      Id=Guid.NewGuid().ToString();
      }
    public string descripcion { get; set; }
    public string precio { get; set; }
    public string icono { get; set; }
    public string Id { get; set; }
    }
  }
