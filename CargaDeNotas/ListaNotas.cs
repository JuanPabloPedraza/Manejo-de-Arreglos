using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDeNotas
{
    class ListaNotas
    {

        #region Propiedades

        /// <summary>
        /// Arreglos
        /// </summary>
        private string[] alumno = new string[1];
        private string[] materia = new string[1];
        private int[] nota = new int[1];

        /// <summary>
        /// Variables enteras
        /// </summary>
        private int numPosicion = 0;

        #endregion

        #region Metodos


        /// <summary>
        /// Guarda datos en los arreglos de la clase 
        /// y llama metodos para expandir los arreglos
        /// </summary>
        /// <param name="cAlumno">Ingresar nombre del alumno</param>
        /// <param name="cMateria">Ingresar la materia</param>
        /// <param name="cNota">Ingresar la nota</param>
        /// <returns>Devuelve un string con los parametros ingresados</returns>
        public String CargarDatos(string cAlumno, string cMateria, string cNota)
        {
            string Resultado = "";

            this.alumno = ExpandirMatrizString(alumno);
            this.materia = ExpandirSegMatrizString(materia);
            this.nota = ExpandirMatrizInt(nota);

            alumno[numPosicion] = cAlumno;
            materia[numPosicion] = cMateria;
            nota[numPosicion] = Convert.ToInt32(cNota);


            numPosicion++;

            Resultado = RegistroDeNotas();

            return Resultado;
        }

        /// <summary>
        /// Agrega elemento null cada vez que se carga un dato
        /// </summary>
        /// <param name="mEntrada">arreglo a expandir de tipo string</param>
        /// <returns>matriz ingresada con un valor null agregado</returns>
        private String[] ExpandirMatrizString(String[] mEntrada)
        {
            string[] mAux = new string[mEntrada.Length + 1];

            for (int i = 0; i < mAux.Length - 1; i++)
            {
                mAux[i] = alumno[i];
            }

            return mAux;

        }

        private String[] ExpandirSegMatrizString(String[] mEntrada)
        {
            string[] mAux = new string[mEntrada.Length + 1];

            for (int i = 0; i < mAux.Length - 1; i++)
            {
                mAux[i] = materia[i];
            }

            return mAux;

        }

        /// <summary>
        /// Agrega elemento null cada vez que se carga un dato
        /// </summary>
        /// <param name="mEntrada">arreglo de tipo int</param>
        /// <returns></returns>
        private int[] ExpandirMatrizInt(int[] mEntrada)
        {
            int[] mAux = new int[mEntrada.Length + 1];

            for (int i = 0; i < mAux.Length - 1; i++)
            {
                mAux[i] = nota[i];
            }

            return mAux;

        }

        /// <summary>
        /// Devuelve la lista de datos ingresados 
        /// </summary>
        /// <returns></returns>
        public string RegistroDeNotas()
        {
            string aux = "            Lista de notas\r\n";
            aux += "Alumno      Materia     Nota\r\n";

            for (int i = 0; i < alumno.Length - 1; i++)
            {
                if (alumno[i] == null)
                {
                    break;
                }
                for (int j = 0; j < materia.Length - 1; j++)
                {

                    for (int k = 0; k < nota.Length - 1; k++)
                    {

                        aux += this.alumno[i]
                            + "      -    "
                            + this.materia[j]
                            + "      -   "
                            + this.nota[k].ToString() + "\r\n";

                        i++;
                        j++;
                    }
                }
            }
            return aux;
        }

        /// <summary>
        /// Ordena los elementos por orden alfabetico
        /// </summary>
        public void OrdenarLista()
        {
            for (int i = 0; i < alumno.Length - 2; i++)
            {
                for (int j = 0; j < alumno.Length - 2; j++)
                {
                    if ((alumno[j].CompareTo(alumno[j + 1])) > 0)
                    {
                        string auxA = "";
                        string auxB = "";
                        int auxC = 0;

                        auxA = alumno[j];
                        alumno[j] = alumno[j + 1];
                        alumno[j + 1] = auxA;

                        auxB = materia[j];
                        materia[j] = materia[j + 1];
                        materia[j + 1] = auxB;

                        auxC = nota[j];
                        nota[j] = nota[j + 1];
                        nota[j + 1] = auxC;


                    }

                }
            }
        }
        #endregion
    }
}
