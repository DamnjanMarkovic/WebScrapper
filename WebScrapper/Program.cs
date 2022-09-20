using ClassLibrary;
using ClassLibrary.MainSingletones;
using ClassLibrary.Models;
using HtmlAgilityPack;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;

namespace WebScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Makita XML
            //MakitaSingletone.Instance.Makita();

            //Create GamaAlati XML
            GamaAlatiSingletone.Instance.GamaAlati();

            Console.ReadLine();
        }

    }
}
