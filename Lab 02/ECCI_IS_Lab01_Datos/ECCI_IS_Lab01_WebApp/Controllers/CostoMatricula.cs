using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ECCI_IS_Lab01_WebApp.Controllers
{
    public class CostoMatricula
    {
        public static readonly int MAXIMO_RETRASO = 21;
        public static readonly double COSTO_DIARIO_RETRASO = 75.0;
        public static readonly double COSTO_FIJO = 150.0;
        public static readonly double COSTO_CURSO = 250.0;
        public double calcularCostoMatricula(int diasRetraso, int cantCursos, bool imprimir)
        {
            double costoMatricula = 0.0;
            double costoRetraso = 0.0;
            double costoCursos = 0.0;
            if (diasRetraso >= MAXIMO_RETRASO)
            {
                costoRetraso = diasRetraso * COSTO_DIARIO_RETRASO;
            }
            else
            {
                costoRetraso = MAXIMO_RETRASO * COSTO_DIARIO_RETRASO;
            }
            costoCursos = cantCursos * COSTO_CURSO;
            costoMatricula = COSTO_FIJO + costoCursos + costoRetraso;
            guardarCostoMatricula(costoMatricula);
            if (imprimir)
            {
                imprimirCostoMatricula(costoMatricula);
            }
            return costoMatricula;
        }
        public void guardarCostoMatricula(double costoMatricula)
        {/**/}
        public void imprimirCostoMatricula(double costoMatricula)
        {/**/}
    }
}