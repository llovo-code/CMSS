using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Domain
{
    public class ConsolaModel
    {

        ConsolasDao cdao = new ConsolasDao();

        List<ConsolasDao> listConsole = new List<ConsolasDao>();

        public void populate()
        {
            listConsole.Add(new ConsolasDao() { IdConsola = 1, MarcaConsola = "PlayStation 4", ModeloConsola = "PS4 Slim" });
            listConsole.Add(new ConsolasDao() { IdConsola = 2, MarcaConsola = "PlayStation 4", ModeloConsola = "PS4 Pro" });
            listConsole.Add(new ConsolasDao() { IdConsola = 3, MarcaConsola = "PlayStation 4", ModeloConsola = "PS4 Original" });
            listConsole.Add(new ConsolasDao() { IdConsola = 4, MarcaConsola = "PlayStation 4", ModeloConsola = "PS4 Slim" });
        }

    }
}
