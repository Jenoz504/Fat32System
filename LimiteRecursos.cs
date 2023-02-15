using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fat32System
{
    class LimiteRecursos
    {
        //contaremos los datos en bytes, 1024^3 es 1gb(predeterminado)
        private long limiteRam = 1024 * 1024 * 1024;
        //limite de tiempo cpu(milisegundos) 10 segundos
        private long limiteTiempoCPU = 10*1000;

        ///Constructor para inicializar con los limites predeterminados
        public LimiteRecursos()
        {
            verificarRecursos();
        }   

        ///Constructor sobrecargado para reasignar recursos
        public LimiteRecursos(long limiteTiempoCPU, long limiteRam)
        {
            LimiteTiempoCPU = limiteTiempoCPU;
            LimiteRam = limiteRam*limiteRam*limiteRam;
        }

        /// <summary>
        /// Proceso para verificar que los recursos no exedan los limites
        /// </summary>
        private void verificarRecursos()
        {
            //Proceso que se ejecuta con visual studio, que simula ser el proceso de maquina virtual
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe";

            //Ciclo que esta en constante verificacion para que el software no se pase de listo
            while (!proceso.HasExited)
            {
                long memoriaUsada = proceso.WorkingSet64;
                if (memoriaUsada > limiteRam)
                {
                    proceso.Kill();
                    System.Windows.Forms.MessageBox.Show("El programa se pasó de listo queriendo usar mas RAM, pantallazo azul mi rey!!!");
                    break;
                }

                if (proceso.TotalProcessorTime.TotalMilliseconds > limiteTiempoCPU)
                {
                    proceso.Kill();
                    System.Windows.Forms.MessageBox.Show("El programa se pasó de listo queriendo usar mas CPU, pantallazo azul mi rey!!!");
                    break;
                }

                //pausa de 1 segundo para no consumir tanta memoria
                Thread.Sleep(1000);
            }

        }

        //Getters y setters
        public long LimiteTiempoCPU { get => limiteTiempoCPU; set => limiteTiempoCPU = value; }
        public long LimiteRam { get => limiteRam; set => limiteRam = value; }
    }
}
