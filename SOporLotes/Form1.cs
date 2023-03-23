// David Isaac De la Cruz Castillo          05/02/2022 SSPSO
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOporLotes
{
    public partial class Form1 : Form
    {
        //DataTable que contendra la informacion de los procesos a Añadir
        DataTable Dt_ProcessToAdd;
        //DataTable que contendra la informacion de los procesos a ejecutar
        DataTable Dt_ProcessInProgress;
        //DataTable que contendra la informacion de los procesos a ejecutar en la primera cola RR
        DataTable Dt_ProcessInProgressRR;
        //DataTable que contendra la informacion de los procesos a ejecutar en la segunda cola FCFS
        DataTable Dt_ProcessInProgressFCFS;
        //DataTable que contendra la informacion de los procesos ejecutados
        DataTable Dt_ProcessEnded;
        // Contador de segundos global actual y total
        (int actual, int Quantum, int total) timer = (0,0,0);
        //Index de proceso tomado por Hilo actualmente 3 hilos para este caso
        int[] indexs = { -1, -1, -1 };
        //Variable para guardar de forma global el quantum
        int QuantumValue = -1;
        
        public Form1()
        {
            InitializeComponent();
        }

        // Metodo de carga de formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            //Datatable para saber los procesos para Añadir
            Dt_ProcessToAdd = new DataTable();
            Dt_ProcessToAdd.Columns.Add("N#", typeof(int));
            Dt_ProcessToAdd.Columns.Add("Llegada", typeof(int));
            Dt_ProcessToAdd.Columns.Add("Nombre");
            Dt_ProcessToAdd.Columns.Add("Restante", typeof(int));
            Dt_ProcessToAdd.Columns.Add("Costo", typeof(int));
            Dt_ProcessToAdd.Columns.Add("Prioridad", typeof(int));


            //Datatable para saber los procesos en progreso
            Dt_ProcessInProgress = new DataTable();
            Dt_ProcessInProgress.Columns.Add("N#", typeof(int));
            Dt_ProcessInProgress.Columns.Add("Llegada", typeof(int));
            Dt_ProcessInProgress.Columns.Add("Nombre");
            Dt_ProcessInProgress.Columns.Add("Restante", typeof(int));
            Dt_ProcessInProgress.Columns.Add("Costo", typeof(int));
            Dt_ProcessInProgress.Columns.Add("Prioridad", typeof(int));

            //Datatable para saber los procesos terminados
            Dt_ProcessEnded = new DataTable();
            Dt_ProcessEnded.Columns.Add("N#", typeof(int));
            Dt_ProcessEnded.Columns.Add("Llegada", typeof(int));
            Dt_ProcessEnded.Columns.Add("Nombre");
            Dt_ProcessEnded.Columns.Add("Restante", typeof(int));
            Dt_ProcessEnded.Columns.Add("Costo", typeof(int));
            Dt_ProcessEnded.Columns.Add("Prioridad", typeof(int));

            //Datatable para saber los procesos en cola 1 RR
            Dt_ProcessInProgressRR = new DataTable();
            Dt_ProcessInProgressRR.Columns.Add("N#", typeof(int));
            Dt_ProcessInProgressRR.Columns.Add("Llegada", typeof(int));
            Dt_ProcessInProgressRR.Columns.Add("Nombre");
            Dt_ProcessInProgressRR.Columns.Add("Restante", typeof(int));
            Dt_ProcessInProgressRR.Columns.Add("Costo", typeof(int));
            Dt_ProcessInProgressRR.Columns.Add("Prioridad", typeof(int));


            //Datatable para saber los procesos en cola 2 FCFS
            Dt_ProcessInProgressFCFS = new DataTable();
            Dt_ProcessInProgressFCFS.Columns.Add("N#", typeof(int));
            Dt_ProcessInProgressFCFS.Columns.Add("Llegada", typeof(int));
            Dt_ProcessInProgressFCFS.Columns.Add("Nombre");
            Dt_ProcessInProgressFCFS.Columns.Add("Restante", typeof(int));
            Dt_ProcessInProgressFCFS.Columns.Add("Costo", typeof(int));
            Dt_ProcessInProgressFCFS.Columns.Add("Prioridad", typeof(int));
        }

        // Este metodo añade una fila a la lista de procesos en progreso
        private void btn_AddProcess_Click(object sender, EventArgs e)
        {
            //Agregamos la fila y bindeamos la gridview poniendo los procesos en Nuevo
            DataRow newRow = Dt_ProcessToAdd.NewRow();
            newRow["N#"] = Dt_ProcessToAdd.Rows.Count+1;
            newRow["Llegada"] = Int32.Parse(tb_Llegada.Text.Trim());
            newRow["Nombre"] = tb_ProcessName.Text.Trim();
            newRow["Costo"] = Int32.Parse(tb_ProcessTime.Text.Trim());
            newRow["Restante"] = Int32.Parse(tb_ProcessTime.Text.Trim());
            newRow["Prioridad"] = Int32.Parse(tb_Priority.Text.Trim());
            Dt_ProcessToAdd.Rows.Add(newRow);
            gv_Waiting.DataSource = Dt_ProcessToAdd;
        }

        private void btn_StartProcess_Click()
        {
            //Pasamos a listo todos los procesos
            Dt_ProcessToAdd.DefaultView.Sort ="Llegada";
            Dt_ProcessToAdd = Dt_ProcessToAdd.DefaultView.ToTable();
            gv_Waiting.DataSource = Dt_ProcessToAdd;

            int lastEntered = Convert.ToInt32(Dt_ProcessToAdd.Compute("MAX(Llegada)", ""));
            int secondsToWork = Convert.ToInt32(Dt_ProcessToAdd.Compute("Sum(Costo)", ""))+ lastEntered;
            // Activamos el timer para ejecturar la funcion ejecutar proceso cada segundo
            for (int i=0; i < secondsToWork; i++)
            {
                int numProcess = Dt_ProcessToAdd.Rows.Count;
                int numDeleted = 0;
                for (int j=0; j < numProcess; j++)
                {
                    DataRow row = Dt_ProcessToAdd.Rows[j- numDeleted];
                    if (row["Llegada"].ToString() == timer.total.ToString())
                    {
                        //Si se añade un nuevo proceso entra a la primera cola (RR)
                        Dt_ProcessInProgressRR.ImportRow(row);
                        Dt_ProcessToAdd.Rows[0].Delete();
                        numDeleted++;
                    }
                }

                // Se checa si la cola RR tiene elementos a ejecutar, se ejecutan, sino se ejecuta la cola FCFS
                if(Dt_ProcessInProgressRR.Rows.Count > 0)
                {
                    Dt_ProcessInProgress = Dt_ProcessInProgressRR;
                    QuantumValue = Int32.Parse(tb_Quantum.Text); ;
                }
                else
                {
                    Dt_ProcessInProgress = Dt_ProcessInProgressFCFS;
                    QuantumValue = -1;
                }


                //LLamamos a nuestros hilo de ejecucion para ejecutar tareas disponibles
                if(Dt_ProcessInProgress.Rows.Count > 0)
                {
                    executeProcess1();
                }
                else
                {
                    lbl_InProgressProcess.Text = "Sin Ocupar";
                }
                DataTable DT_CopyToShow = Dt_ProcessInProgress.Clone();
                DT_CopyToShow.Merge(Dt_ProcessInProgress);
                DT_CopyToShow.Merge(Dt_ProcessInProgressFCFS);
                DataView sinRepetir = new DataView(DT_CopyToShow);
                DT_CopyToShow = sinRepetir.ToTable(true);
                gv_Waiting.DataSource = DT_CopyToShow;
                gv_Waiting.Refresh();

                // Actualizamos el timer global
                lbl_TimeInProgress.Text = timer.total.ToString();
                gv_Finally.DataSource = Dt_ProcessEnded;
                timer.total++;
                // Actualizamos el timer global
                lbl_TimeInProgress.Text = timer.total.ToString();
                
                //Si ya no hay procesos a añadir ni a resolver se cierra el programa
                if(Dt_ProcessInProgressRR.Rows.Count==0 && Dt_ProcessInProgressFCFS.Rows.Count == 0 && Dt_ProcessToAdd.Rows.Count == 0)
                {
                    break;
                }
                this.Refresh();
            }

        }

        // Funcion para actualizar los timers y gridviews cada segundo en el primer hilo
        private void executeProcess1()
        {
            //Checamos que haya mas procesos por evaluar
            bool flag = true;
            for (int i = 0; i < Dt_ProcessInProgress.Rows.Count; i++)
            {
                if (indexs.Contains(i) == false)
                {
                    flag = false;
                }
            }
            if(flag && indexs[0] < 0)
               return;
            // Template Row
            DataRow row1 = Dt_ProcessInProgress.NewRow();

            // Actualizamos la etiqueta del proceso actual.
            int time = 0;

            if (indexs[0] <0)
            {
                
                for(int i=0; i < Dt_ProcessInProgress.Rows.Count; i++)
                {
                    if (indexs.Contains(i) == false)
                    {
                        row1 = Dt_ProcessInProgress.Rows[i];
                        indexs[0] = i;
                        break;
                    }
                }
            }
            else
            {
                row1 = Dt_ProcessInProgress.Rows[indexs[0]];
            }

            lbl_InProgressProcess.Text = row1["Nombre"].ToString();
            time = Int32.Parse(row1["Costo"].ToString());

            timer.actual = Int32.Parse(Dt_ProcessInProgress.Rows[indexs[0]]["Restante"].ToString());
            timer.actual--;

            timer.Quantum++;

            // Actualizamos nuestro proceso a  ejecutando
            Dt_ProcessInProgress.Rows[indexs[0]]["Restante"] = (timer.actual);


            int costo = Int32.Parse(Dt_ProcessInProgress.Rows[indexs[0]]["Costo"].ToString());
            // Actualizamos en procentaje la barra de progreso
            progressBar1.Value = (time-timer.actual) * 100 / time ;
            this.Refresh();


            //Checamos si ya se espero lo suficiente para dicho proceso
            if (timer.actual <= 0)
            {
                //Reiniciamos los timers y ponemos nuestro proceso en terminado
                timer.actual = 0;
                Dt_ProcessEnded.ImportRow(row1);
                indexs[1]--;
                indexs[2]--;
                Dt_ProcessInProgress.Rows[0].Delete();
                indexs[0] = -1;


                if(Dt_ProcessInProgress.Rows.Count > 0)
                {
                    //Reordenamos los procesos por prioridad para que se ejecute el de menor prioridad
                    DataView dt_V = Dt_ProcessInProgress.DefaultView;
                    dt_V.Sort = "Prioridad ASC";
                    Dt_ProcessInProgress = dt_V.ToTable();

                    //Si hay dos con misma prioridad se busca el que llego primero
                    int mminPrioridad = Convert.ToInt32(Dt_ProcessInProgress.Compute("MIN(Prioridad)", ""));
                    DataRow[] selecteds = Dt_ProcessInProgress.Select($"[Prioridad] = {mminPrioridad}");
                    if (selecteds.Length > 0)
                    {
                        dt_V = Dt_ProcessInProgress.DefaultView;
                        dt_V.Sort = "Llegada ASC";
                        Dt_ProcessInProgress = dt_V.ToTable();
                    }
                }
               
         
                return;
            }

            if (QuantumValue != -1)
            {
                if (timer.Quantum == QuantumValue)
                {
                    timer.Quantum = 0;
                    //Realizamos llamada a sistema lo que pone el proceso actual a la cola de la Cola de Listos
                    DataRow newRow = Dt_ProcessInProgress.Rows[indexs[0]];
                    Dt_ProcessInProgressFCFS.ImportRow(newRow);
                    Dt_ProcessInProgress.Rows[indexs[0]].Delete();
                    indexs[0] = -1;
                    //Actualizamos RR
                    Dt_ProcessInProgressRR = Dt_ProcessInProgress;
                }
            }
            else
            {
                //Actualizamos FCFS
                Dt_ProcessInProgressFCFS = Dt_ProcessInProgress;
            }
            Thread.Sleep(1000);
        }

        private void btn_RR_Click(object sender, EventArgs e)
        {
            //Colas Multiples
            btn_StartProcess_Click();
        }

        private void btn_FCFS_Click(object sender, EventArgs e)
        {
            //FCFC con prioridad
            btn_StartProcess_Click();
        }
    }
}
