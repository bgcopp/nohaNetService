using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NOHAService.Utils;

namespace NOHAService
{
  public class NohaSrv
  {
    private Timer Tnoha;
    private bool _serviceActive;

    public NohaSrv()
    {
      _serviceActive = false;
        Tnoha = new Timer(1000);
        Tnoha.Elapsed += Tnoha_Elapsed;
    }

    void Tnoha_Elapsed(object sender, ElapsedEventArgs e)
    {
      Tnoha.Enabled = false;
      try
      {
        //actualiza los registros de la tabla con antiguedad mayor a config
        var cad = "UPDATE TTarjeta set activa = 1 where numtarjeta in (SELECT NoTarjeta from TMarcacionTmp where estado = 10 and fechaMarcacion < DATEADD(MINUTE, -" + ConfigurationManager.AppSettings["MaxAge"] + ", GETDATE()))";
        var cad1 = "update TMarcacionTmp set estado = 20 WHERE fechaMarcacion < DATEADD(MINUTE, -" + ConfigurationManager.AppSettings["MaxAge"] + ", GETDATE())";
        SqlTools.SQLExecute(cad);
        SqlTools.SQLExecute(cad1);
        Console.Write("Operacion realizada " + DateTime.Now);
      }
      catch (Exception)
      {
          
        
      }
      if (_serviceActive)
      {
        Tnoha.Enabled = true;
      }
      
    }
    public void Start()
    {
      _serviceActive = true;
      Tnoha.Enabled = true;
    }

    public void Stop()
    {
      _serviceActive = false;
      Tnoha.Enabled = false;
    }

  }
}
