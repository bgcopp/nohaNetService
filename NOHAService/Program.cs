﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace NOHAService
{
  class Program
  {
    static void Main(string[] args)
    {
      HostFactory.Run(x => //1
      {
        x.Service<NohaSrv>(s => //2
        {
          s.ConstructUsing(name => new NohaSrv()); //3
          s.WhenStarted(tc => tc.Start()); //4
          s.WhenStopped(tc => tc.Stop()); //5
        });
        x.RunAsLocalSystem(); //6

        x.SetDescription("Servicio Noha Antipass"); //7
        x.SetDisplayName("NOHA.Antipass"); //8
        x.SetServiceName("NOHA.Antipass"); //9
      });
      Console.ReadLine();
    }
  }
}
