using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System.Diagnostics;
using Infragistics.Win.UltraWinGrid;



//https://docs.microsoft.com/es-es/dotnet/framework/winforms/controls/controls-to-use-on-windows-forms

//https://www.c-sharpcorner.com/article/crud-operation-using-entity-framework-in-windows-form-application/
//https://docs.oracle.com/cd/E17952_01/connector-net-en/connector-net-tutorials-entity-framework-winform-data-source.html
//https://www.codeproject.com/Articles/221931/Entity-Framework-in-WinForms
//ULTRAGIRD
//https://www.infragistics.com/products/windows-forms/grids-and-lists/grid
//http://help.infragistics.com/Help/Doc/WinForms/2012.1/CLR2.0/HTML/Infragistics2.Win.UltraWinGrid.v12.1~Infragistics.Win.UltraWinGrid.UltraGrid.html
//https://stackoverflow.com/questions/13947502/using-custom-ultragrid-in-winform
//http://www.keithholloway.net/blog/infragistics-winform-ultragrid-quick-reference-guide/
//DATASET
//https://docs.microsoft.com/es-es/dotnet/framework/data/adonet/dataset-datatable-dataview/
//https://docs.microsoft.com/es-es/dotnet/framework/data/adonet/creating-a-dataview-object-linq-to-dataset
//https://www.dotnetperls.com/dataset
//https://docs.microsoft.com/es-es/dotnet/framework/data/adonet/data-binding-and-linq-to-dataset

#region itemsWF

/*
 * TB: tbNombre,tbRaza
    NU: nuIdMascotas,nuAmo
    CB: CBTipoAnimal
    DTF: DTPFechaNacimiento

    BT: btSelect, btInsert,btUpdate,btDelete,btPruebas
 * 
 * 
 * *Get*

    |string username = txtusername.Text;
    string password = txtpassword.Text;|

    *Set*

    |txtusername.Text = "my_username";
    txtpassword.Text = "12345";|

    numericUpDown1.Value.ToString()
    numericUpDown1.Value = 55; 
    numericUpDown1.UpButton();

 */

#endregion
namespace AFEFWFV05221018
{
    public partial class Form1 : Form
    {

        #region variablesGlobales
            VeterianEntities db = new VeterianEntities();
            private object setPetVist;
            List<PET> listaMascotas;
            PET[] arrayPets;
            ExtracionDatos ed = new ExtracionDatos();
            DateTime? myDate;
            logs logs = new logs();
            CheqeoDatos chequeoDatos = new CheqeoDatos();
            delegate void extraNom1(string s);

        string str;

        public object ultraTextEditor1 { get; private set; }


        #endregion




        #region form1


        public Form1()
        {
            #region enchegar
            db = new VeterianEntities();
            Debug.AutoFlush = true;
            InitializeComponent();
            CBTipoAnimal.Items.Add("default");
            setCBTipoAnimal();
            DTPtimeToday();
            CBTipoAnimal.SelectedIndex = CBTipoAnimal.FindStringExact("default");
            logs.crearLog("inicio correcto");
            //UltraGrid1 ug = new

            #endregion

            #region chequeoDB
            using (VeterianEntities db2 = new VeterianEntities())
            {
                var queryVet1 = (from p in db2.PET where p.PetName == "kira" select new { PetType = p.PetType }).FirstOrDefault();
                Console.WriteLine("PreChequeoQueryVet1 = {0}", queryVet1.PetType);
                MessageBox.Show("PreChequeoQueryVet1 = " + queryVet1.PetType);
                Debug.WriteLine("PreChequeoDebug--queryVet1 = " + queryVet1.PetType);
                Trace.WriteLine("PreChequeoTrace--queryVet1 = " + queryVet1.PetType);
            }

            #endregion

        }

        #endregion
    

           


        #region labely varios
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ultraScaleLegend2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

       


        #endregion

        #region btPruebas

        private void btPruebas_Click(object sender, EventArgs e)
        {
            //obetenrmos valores de SQL 
            ed.getSQLDatePET(ref db, ref listaMascotas, ref arrayPets);

            //obtenemos valorCeldaRef
            string valor = tbNombre.Text.ToLower().Trim();
            Debug.WriteLine("valor: " + valor);
            if (valor.Equals("kira")) Debug.WriteLine("valorKira: " + valor);

            //trabajamos con  valorCeldaREF
            Debug.Write("BottonPruebasArrray: ");
            foreach (PET item in arrayPets)
            {
                if ((item.PetName.ToString().Trim()).Equals(valor))
                {
                    Debug.Write(" " + item.PetBreed.ToString().Trim());
                    tbRaza.Text = item.PetBreed.ToString().Trim();

                }
            }
            Debug.WriteLine("");
        }


        #endregion

        #region btPRBNumerica


        private void btPRBNumeric_Click(object sender, EventArgs e)
        {
            //obetenrmos valores de SQL 
            ed.getSQLDatePET(ref db, ref listaMascotas, ref arrayPets);

            #region ObtencionMAXNUFromDDBB

            //valor maximo registros
            decimal numeroMascotas = arrayPets.Length;
            Debug.WriteLine("numeroMascotas: " + numeroMascotas);
            nuIdMascotas.Maximum = numeroMascotas;
            int max = (int)numeroMascotas;

            #endregion


            int valor = Convert.ToInt16(nuIdMascotas.Value);

            Debug.WriteLine("valor: " + valor);
            Debug.Write("BottonPruebasArrray: ");
            foreach (PET item in arrayPets)
            {
                if (valor == item.PetID)
                {
                    Debug.Write(" " + item.PetBreed.ToString().Trim());
                    tbRaza.Text = item.PetBreed.ToString().Trim();
                    tbNombre.Text = item.PetName.ToString().Trim();
                }
            }

            Debug.WriteLine("");
        }

        #endregion



        #region btClear

        private void btClear_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "foo";
            tbRaza.Text = "bar";
            nuAmo.Value = 99;
            nuIdMascotas.Value = 15;
            CBTipoAnimal.SelectedIndex = CBTipoAnimal.FindStringExact("default");
            DTPtimeToday();

            //Combox1.SelectedIndex = Combox1.FindStringExact("test1")
            //comboBox2.SelectedValue.ToString();
            //SelectedItem("default");

        }

        #endregion

        #region bt2form
                 private void btForm2_Click(object sender, EventArgs e)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
        #endregion
        



        #region numericos

        #region nuPetId

        private void nuIdMascotas_ValueChanged(object sender, EventArgs e)
        {
            //obetenrmos valores de SQL 
            ed.getSQLDatePET(ref db, ref listaMascotas, ref arrayPets);

            #region ObtencionMAXNUFromDDBB

            //valor maximo registros
            decimal numeroMascotas = arrayPets.Length;
            Debug.WriteLine("numeroMascotas: " + numeroMascotas);
            nuIdMascotas.Maximum = numeroMascotas;
            int max = (int)numeroMascotas;

            #endregion


            int valor = Convert.ToInt16(nuIdMascotas.Value);

            Debug.WriteLine("valor: " + valor);
            Debug.Write("BottonPruebasArrray: ");
            foreach (PET item in arrayPets)
            {
                if (valor == item.PetID)
                {
                    Debug.Write(" " + item.PetBreed.ToString().Trim());
                    tbRaza.Text = item.PetBreed.ToString().Trim();
                    tbNombre.Text = item.PetName.ToString().Trim();
                    CBTipoAnimal.SelectedIndex = CBTipoAnimal.FindStringExact(item.PetType.ToString().Trim());
                    //myDate = item.PetDOB;
                    DTPFechaNacimiento.CustomFormat = "dd-MM-yyy";
                    DTPFechaNacimiento.Format = DateTimePickerFormat.Custom;
                    DTPFechaNacimiento.Value = item.PetDOB.Value;
                    #region pruebaFallidaautomatizacioncarga
                            /*
                            extraNom1 en= delegate (string j)
                            {
                                j = item.PetName.ToString().Trim();
                            };
                            */
                            #endregion
                            /*
                            extraNom1 en= delegate (string j)
                            {
                                j = item.PetName.ToString().Trim();
                            };
                    */

                }
            }

            Debug.WriteLine("");
        }

        #endregion




        #endregion

        #region combobox

        private void CBTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region setCBTipoAnimal

        public void setCBTipoAnimal()
        {
            ed.getSQLDatePET(ref db, ref listaMascotas, ref arrayPets);


            var tipoMascotasNR = (from p in db.PET select p.PetType).Distinct().ToList();

            foreach (var item in tipoMascotasNR)
            {
                Debug.WriteLine(item.Trim());
                CBTipoAnimal.Items.Add(item.Trim());

            }

        }

        #endregion


        #region dataPicker
        /*
         * 

            TimePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            

            dateTimePicker1.Value = new DateTime(2001, 10, 20);  

             this.DTPFechaNacimiento.Value = Convert.ToDateTime(System.DateTime.Today.ToShortDateString());

            DateTime? myDate = form.dteStartDate;
            string sqlFormattedDate = myDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Of course this doesn't handle the case that there is no value. Perhaps something like this:

            string sqlFormattedDate = myDate.HasValue 
             ? myDate.Value.ToString("yyyy-MM-dd HH:mm:ss")
    : "<not available>";

  var tipo = queryVet2.PetDOB.GetType();
               

                DateTime? myDate = queryVet2.PetDOB;
                string sqlFormattedDate = myDate.Value.ToString("dd-MM-yyyy");

         * 
         *  //obetenrmos valores de SQL 
                ed.getSQLDatePET(ref db, ref listaMascotas, ref arrayPets);
         * 
         */


        public void DTPtimeToday()
        {
            DTPFechaNacimiento.CustomFormat = "dd-MM-yyy";
            DTPFechaNacimiento.Format = DateTimePickerFormat.Custom;
            DTPFechaNacimiento.Value = DateTime.Today;
        }


        #endregion

        #region extracionDatosWF1toWF2

        public string extraTbNombre()
        {
            return this.tbNombre.Text.Trim();
        }


        public string extraTbUltraGrid()
        {
            //return this.tbNombre.Text.Trim();
            return null;
        }


        #endregion

        #region ultragridZone

        private void ultraGrid1_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {





        }
        #endregion

        #region Botones
        #region chequeo


        #region IrUG

        private void btFormUG1_Click(object sender, EventArgs e)
        {
            FormUG1 ug1 = new FormUG1();
            ug1.Show();

        }

        #endregion



        private void BTUltragrid_Click(object sender, EventArgs e)
        {
            this.ultraGrid1.DataBind();
            this.ultraGrid1.SetDataBinding(this.veterianDataSet2, "LovePets");

            //https://www.infragistics.com/community/forums/f/ultimate-ui-for-windows-forms/37977/linq-to-sql-in-ultrawingrid

            // To sort multi-column using SortedColumns property
            // This enables multi-column sorting
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            var listaPets1 = (from p in db.PET select p).ToList();
            this.ultraGrid1.DataSource = listaPets1;
            this.ultraGrid1.Refresh();



        }



        //bottonGetUltragrid
        private void button1_Click(object sender, EventArgs e)
            {
                this.ultraGrid1.Rows[1].Selected = true;
            }





        #endregion

        #endregion

        private void DTPFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }


    #region extracion datos

    class ExtracionDatos
    {

        public void getSQLDatePET(ref VeterianEntities db, ref List<PET> listaMascotas, ref PET[] arrayPets)
        {
            listaMascotas = (from p in db.PET select p).ToList();

            Debug.Write("Listpet: ");
            foreach (var item in listaMascotas)
            {
                //Console.WriteLine(item.PetID + "  " + item.PetName);
                //Console.WriteLine(item.PetID + "  " + item.PetName);
                Debug.Write(item.PetID.ToString().Trim() + "--" + item.PetName.ToString().Trim() + "  ");

            }
            Debug.WriteLine("");

            arrayPets = listaMascotas.ToArray();
            Debug.Write("Array: ");
            foreach (var item in arrayPets)
            {
                Debug.Write(item.PetID.ToString().Trim() + "--" + item.PetName.ToString().Trim() + "   ");
            }
            Debug.WriteLine("");
        }



    }


    #endregion










    #region Classes

    partial class pet
    {
        public int PetID { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string PetBreed { get; set; }
        public DateTime PetDOB { get; set; }
        public int OwnerID { get; set; }

    }

    partial class pet_owner
    {
        public int OwnerID { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }

    }

    partial class veterian
    {
        public int VetID { get; set; }
        public string VetLastName { get; set; }
        public string VetFirstName { get; set; }
        public string VetPhone { get; set; }
        public string VetEmail { get; set; }

    }

    partial class ultraGrid1
    {
        public int PetID { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string PetBreed { get; set; }
        public DateTime PetDOB { get; set; }
        public int OwnerID { get; set; }

    }


    #endregion


}
