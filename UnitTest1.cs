using Microsoft.VisualStudio.TestTools.UnitTesting;

using Examen_No4;
namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarLongitudPromedioTramoDeterioroEsCien()
        {
            string[] tramosPrueba =
            {
                "Agrietamientos",
                "Hundimientos",
                "Ondulaciones"
            };
            Calle[] longitudPrueba =
            {
                new Calle() { TipoDeterioro="Agrietamientos",TramoAfectado = 100,Longitud = 100},
                new Calle() { TipoDeterioro= "Ondulaciones", TramoAfectado =  250,Longitud = 250},
                new Calle() { TipoDeterioro = "Hundimientos", TramoAfectado = 150, Longitud = 300},
                new Calle() { TipoDeterioro = "Hundimientos", TramoAfectado = 350, Longitud = 500 }
            };
            double[] TotalTipoDeterioroPorPrueba = Program.ObtieneLongitudPromedioTramosPorDeterioro( longitudPrueba, tramosPrueba);
           double longitudObtenida = TotalTipoDeterioroPorPrueba[0];
            int longitudEsperada = 100;
           
            Assert.AreEqual(longitudEsperada, longitudObtenida);
        }
        [TestMethod]
        public void ValidarAgrietamientosesDos()
        {
            string[] deteriorosPrueba =
         {
                "Agrietamientos",
                "Hundimientos",
                "Ondulaciones"
            };
            Calle[] TotalAfectacionesPrueba =
            {
                 new Calle() { TipoDeterioro = "Ondulaciones"},
                new Calle() { TipoDeterioro= "Ondulaciones", },
                new Calle() { TipoDeterioro = "Agrietamientos", },
                new Calle() { TipoDeterioro = "Agrietamientos", },
                 new Calle() { TipoDeterioro = "Hundimientos", }
            };
            int[] totalDeterioroPrueba = Program.TotalizaAfectacionesPorDeterioro(TotalAfectacionesPrueba, deteriorosPrueba);
            int totalEsperado = 2;
            int totalReal = totalDeterioroPrueba[0];

            Assert.AreEqual(totalEsperado, totalReal);
        }
    }
}
