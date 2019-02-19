using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFEFWFV05221018
{
    public partial class FormUG1 : Form
    {
        #region variablesGlobales
        logs lg = new logs();
        VeterianEntities db1 = new VeterianEntities();
        ultraGrid1 ug1 = new ultraGrid1();
        PET petNewbie = new PET()
        {
            PetName = "Golum",
            PetType = "dog",
            PetBreed = "chihuaha",
            PetDOB = DateTime.Now,
            OwnerID = 1
        };
        string[] arrayInsertPet;
        int dueño, duenyo,numeroColumnas, idDueño;
        List<string> listaTipoAnimales,listInsertPet,listaDueños;
        string petName, petType, petBreed, setLBSeleciondo;
        DateTime DOB;
        List<PET> listaPets1;


        #endregion

        #region Inicilizador

        public FormUG1()
        {

            //http://geekswithblogs.net/malisancube/archive/2009/04/21/using-lambda-or-linq-for-pivot-tables.aspx
            //https://social.msdn.microsoft.com/Forums/en-US/e3512ff5-cae6-4ba9-95a9-d187797b8b75/linq-query-for-pivot-table?forum=csharplanguage
            InitializeComponent();
            cargarCBTipoAnimal();
            DTPtimeToday();
            cargarDueño();
            
            //http://www.entityframeworktutorial.net/entityframework4.3/raw-sql-query-in-entity-framework.aspx

        }




        private void FormUG1_Load(object sender, EventArgs e)
        {

        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            this.ultraGrid1.DataBind();
            this.ultraGrid1.SetDataBinding(this.veterianDataSet2, "LovePets");
           


            //https://www.infragistics.com/community/forums/f/ultimate-ui-for-windows-forms/37977/linq-to-sql-in-ultrawingrid

            // To sort multi-column using SortedColumns property
            // This enables multi-column sorting
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
             listaPets1 = (from p in db.PET select p).ToList();
            this.ultraGrid1.DataSource = listaPets1;
            this.ultraGrid1.DisplayLayout.Bands[0].Columns["PetID"].Header.VisiblePosition = 1;


            //https://www.infragistics.com/help/winforms/wingrid-adding-new-rows-to-wingrid

            #region filter
            //****TOP filter******
            //http://help.infragistics.com/Help/Doc/WinForms/2012.1/CLR2.0/HTML/WinGrid_Use_the_Filter_Row_Feature.html
            //este solo  aparace los filtrados
            this.ultraGrid1.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True;
            //e.Layout.Override.RowFilterMode = RowFilterMode.SiblingRowsOnly;
            //aqui aparece todas  AppearancesOnly;solo aparece selecionadas .Default; .HideFilteredOutRows;
            e.Layout.Override.RowFilterAction = RowFilterAction.Default;
            e.Layout.Override.FilteredInRowAppearance.BackColor = Color.Blue;
            e.Layout.Override.FilteredOutCellAppearance.ForeColor = SystemColors.ControlDarkDark;
            //****BottomFilter****
            #endregion

            #region createButtonAddRow

            e.Layout.AddNewBox.Hidden = false;

            #endregion

            this.ultraGrid1.Refresh();
            //elimino ua por error mio, no cal
            numeroColumnas = this.ultraGrid1.DisplayLayout.Bands[0].Columns.Count - 1;
            lg.crearLog("columnas.  " + numeroColumnas);
        }
        #region InsertaRegistro

        private void ultraGrid1_AfterRowInsert(object sender, RowEventArgs e)
        {

            e.Row.Cells["PetID"].Value = e.Row.Index + 1;
            e.Row.Cells["[PetName"].Value = "kiriki";
            e.Row.Cells["PetDOB"].Value = DateTime.Now;
            e.Row.Cells["OwnerID"].Value = 5;

        }

        #endregion

        #endregion

        #region Botones

        private void btInsertarPet_Click(object sender, EventArgs e)
        {
            #region descartados

            /*
                //insertPet();
                insertPet2("carpetoVetonico", "alien", "Xenomorfo", 1);
                //insertPet3(string petName, string petType, string petBreed, int duenyo)
                //insertPet3(petName,petType,petBreed,duenyo);
                //string petName, petType, petBreed; int duenyo;
                */

            #endregion




            petName = tbNombre.Text.Trim().ToLower();
            petType = cbTipoAnimal.SelectedValue.ToString();
            petBreed = tbRaza.Text.Trim().ToLower();
            duenyo = intFindIdOwner();
            DOB = dtFechaNacimiento.Value;

            lg.crearLog("Antes de insertar: "+petName +", "+petType+ ", "+ duenyo+ ", "+DOB);

            //insertPet4(petName, petType, petBreed, duenyo, DOB);
            insertPet5(petName, petType, petBreed, duenyo, DOB);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            /*
             * db.Configuration.AutoDetectChangesEnabled = false;

                #region ModificarRow
                      
            var queries2 = (from v in db.VETERIAN
                            where v.VetID == 9
                            select v).SingleOrDefault();
            queries2.VetPhone = "24t688xxx";
            db.Entry(queries2).State = EntityState.Modified;
            db.SaveChanges();
            
                    #endregion
             * 
             */


        }

        private void ultraGrid1_ClickCell(object sender, ClickCellEventArgs e)
        {
            //listaPets1


            //object obj1 = this.ultraGrid1.ActiveRow.GetCellValue(1);    //GetCellText();
            string indexColumna =Convert.ToString(e.Cell.Column.Index);
            int indexColumnaInt = e.Cell.Column.Index;
            int indexRow = e.Cell.Row.Index;
            UltraGridRow row = this.ultraGrid1.Rows[1];
            UltraGridColumn column = this.ultraGrid1.DisplayLayout.Bands[0].Columns[1];
            Infragistics.Win.UltraWinGrid.UltraGridColumn ugc = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PetID");
        #region getSetQue funcionan

        //Obtiene valor de la celda selecionada convertiendolo  en String   
        //object obj4 = ultraGrid1.Rows[indexRow].Cells[indexColumnaInt].Text;
        //Obtiene valor de la celda selecionada en su tipoValor (cuidado fecha)
        //object obj5 = ultraGrid1.Rows[indexRow].Cells[indexColumnaInt].Value;//.ToString();  //repasar
        http://help.infragistics.com/Help/Doc/WinForms/2012.1/CLR2.0/html/Infragistics2.Win.UltraWinGrid.v12.1~Infragistics.Win.UltraWinGrid.UltraGridRow~GetCellValue(UltraGridColumn).html
            #endregion
            object obj1 = ultraGrid1.Rows[indexRow].Cells[indexColumnaInt].Text;

            object obj2 = ultraGrid1.Selected.Cells.GetItem(indexColumnaInt);

            
           







            listaPets1 = (from p in db.PET select p).ToList();
            PET[] arrayPet = listaPets1.ToArray();

            //recoger todo el valor  de fila
            //PET pet = arrayPet[indexColumnaInt];
           

            //int indexFila  =
            string msg = String.Format("Clicked on the cell at row index {0} and column index {1} obj1: {2} , obj1: {3}", 
                e.Cell.Row.Index,e.Cell.Column.Index,obj1,obj2 );

            lbDueño.Text = msg;

            //MessageBox.Show(msg);
        }



        private void ultraGrid1_MouseClick(object sender, MouseEventArgs e)
        {
           

            
        }

        #endregion

        #region InsertarDatos

        //PetID],[PetName],[PetType],[PetBreed],[PetDOB],[OwnerID]
        /* petNewbie = new PET()
        {
            PetName = "Golum",
            PetType = "dog",
            PetBreed = "chihuaha",
            PetDOB = DateTime.Now,
            OwnerID = 5
        };*/

        public void insertPet()
        {

            var count = (from o in db1.PET

                         select o).Count();
            Debug.WriteLine("insertPet.  " + count);
            PET petNewbie2 = new PET()
            {
                PetID = count,
                PetName = "Dr Gang ",
                PetType = "cat",
                PetBreed = "persa",
                PetDOB = DateTime.Now,
                OwnerID = 1
            };

            AuxDBInsert();
            auxUGTaskInsert();
            #region dbTask+UGtask

            /*
       db1.Configuration.AutoDetectChangesEnabled = false;
       db1.Entry(petNewbie2).State = System.Data.Entity.EntityState.Added;
       db1.SaveChanges();

       this.ultraGrid1.DataBind();
       this.ultraGrid1.SetDataBinding(this.veterianDataSet2, "LovePets");
       this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
       var listaPets1 = (from p in db.PET select p).ToList();
       this.ultraGrid1.DataSource = listaPets1;
       this.ultraGrid1.DisplayLayout.Bands[0].Columns["PetID"].Header.VisiblePosition = 1;
       this.ultraGrid1.Refresh();*/

            #endregion

        }


        public void insertPet2(string petName, string petType, string petBreed, int duenyo)
        {

            var count = (from o in db1.PET
                         select o).Count();
            Debug.WriteLine("insertPet.  " + count);
            auxListInsert(petName, petType, petBreed, duenyo);

            var chequeoDueño = (from d in db1.PET_OWNER select d.OwnerID).ToList();
            int maxDueño = chequeoDueño.Count();
            lg.crearLog("maxDueño: " + maxDueño);




            lg.crearLog("arrayInsertPet[1]: " + arrayInsertPet[1]);
            lg.crearLog("arrayInsertPet[2]: " + arrayInsertPet[2]);
            lg.crearLog("arrayInsertPet[3]: " + arrayInsertPet[3]);
            lg.crearLog("dueño: " + dueño);


            petNewbie = new PET()
            {
                PetID = count,
                PetName = arrayInsertPet[1].Trim().ToLower(),  //petName.Trim().ToLower(),
                PetType = arrayInsertPet[2].Trim().ToLower(),//petType.Trim().ToLower(),
                PetBreed = arrayInsertPet[3].Trim().ToLower(),//petBreed.Trim().ToLower(),
                PetDOB = DateTime.Now,
                OwnerID = dueño
            };

            AuxDBInsert();
            auxUGTaskInsert();
        }

        public void insertPet3(string petName, string petType, string petBreed, int duenyo)
        {

            var count = (from o in db1.PET
                         select o).Count();
            Debug.WriteLine("insertPet.  " + count);
            auxListInsert(petName, petType, petBreed, duenyo);

            var chequeoDueño = (from d in db1.PET_OWNER select d.OwnerID).ToList();
            int maxDueño = chequeoDueño.Count();
            lg.crearLog("maxDueño: " + maxDueño);

            lg.crearLog("arrayInsertPet[1]: " + arrayInsertPet[1]);
            lg.crearLog("arrayInsertPet[2]: " + arrayInsertPet[2]);
            lg.crearLog("arrayInsertPet[3]: " + arrayInsertPet[3]);
            lg.crearLog("dueño: " + dueño);


            petNewbie = new PET()
            {
                PetID = count,
                PetName = arrayInsertPet[1].Trim().ToLower(),  
                PetType = arrayInsertPet[2].Trim().ToLower(),
                PetBreed = arrayInsertPet[3].Trim().ToLower(),
                PetDOB = DateTime.Now,
                OwnerID = dueño
            };

            setLBSeleciondo = String.Format("lbSelecionado: {0}, {1}, {2}", arrayInsertPet[1].Trim().ToLower(), arrayInsertPet[2].Trim().ToLower(), arrayInsertPet[3].Trim().ToLower());
            lbSelecionado.Text = setLBSeleciondo;

            AuxDBInsert();
            auxUGTaskInsert();
        }


        public void insertPet4(string petName, string petType, string petBreed, int duenyo,DateTime DOB)
        {

            var count = (from o in db1.PET
                         select o).Count();
            Debug.WriteLine("insertPet.  " + count);
            auxListInsert(petName, petType, petBreed, duenyo);

            var chequeoDueño = (from d in db1.PET_OWNER select d.OwnerID).ToList();
            int maxDueño = chequeoDueño.Count();
            lg.crearLog("maxDueño: " + maxDueño);

            lg.crearLog("arrayInsertPet[1]: " + arrayInsertPet[1]);
            lg.crearLog("arrayInsertPet[2]: " + arrayInsertPet[2]);
            lg.crearLog("arrayInsertPet[3]: " + arrayInsertPet[3]);
            lg.crearLog("dueño: " + dueño);


            petNewbie = new PET()
            {
                PetID = count,
                PetName = arrayInsertPet[1].Trim().ToLower(),
                PetType = arrayInsertPet[2].Trim().ToLower(),
                PetBreed = arrayInsertPet[3].Trim().ToLower(),
                PetDOB = DOB,
                OwnerID = dueño
            };

            setLBSeleciondo = String.Format("lbSelecionado: {0}, {1}, {2}, {3}", arrayInsertPet[1].Trim().ToLower(), arrayInsertPet[2].Trim().ToLower(), arrayInsertPet[3].Trim().ToLower(),
                                            DOB.ToString("dd/MM/yy"));
            lbSelecionado.Text = setLBSeleciondo;

            AuxDBInsert();
            auxUGTaskInsert();
        }


        public void insertPet5(string petName, string petType, string petBreed, int duenyo, DateTime DOB)
        {

            var count = (from o in db1.PET
                         select o).Count();
            Debug.WriteLine("insertPet.  " + count);
            auxListInsert(petName, petType, petBreed, duenyo);

            var chequeoDueño = (from d in db1.PET_OWNER select d.OwnerID).ToList();
            int maxDueño = chequeoDueño.Count();
            lg.crearLog("maxDueño: " + maxDueño);

            lg.crearLog("arrayInsertPet[1]: " + arrayInsertPet[1]);
            lg.crearLog("arrayInsertPet[2]: " + arrayInsertPet[2]);
            lg.crearLog("arrayInsertPet[3]: " + arrayInsertPet[3]);
            lg.crearLog("dueño: " + dueño);


            petNewbie = new PET()
            {
                PetID = count,
                PetName = arrayInsertPet[1].Trim().ToLower(),
                PetType = arrayInsertPet[2].Trim().ToLower(),
                PetBreed = arrayInsertPet[3].Trim().ToLower(),
                PetDOB = DOB,
                OwnerID = dueño
            };

            setLBSeleciondo = String.Format("lbSelecionado: {0}, {1}, {2}, {3}, {4}", arrayInsertPet[1].Trim().ToLower(), arrayInsertPet[2].Trim().ToLower(), arrayInsertPet[3].Trim().ToLower(),
                                            DOB.ToString("dd/MM/yy"),idDueño);
            lbSelecionado.Text = setLBSeleciondo;

            AuxDBInsert();
            auxUGTaskInsert();
        }

        #endregion

        #region auxFuncionesDB

        public void AuxDBInsert()
        {
            db1.Configuration.AutoDetectChangesEnabled = false;
            db1.Entry(petNewbie).State = System.Data.Entity.EntityState.Added;
            db1.SaveChanges();
        }

        public void auxUGTaskInsert()
        {
            this.ultraGrid1.DataBind();
            this.ultraGrid1.SetDataBinding(this.veterianDataSet2, "LovePets");
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            var listaPets1 = (from p in db.PET select p).ToList();
            this.ultraGrid1.DataSource = listaPets1;
            this.ultraGrid1.DisplayLayout.Bands[0].Columns["PetID"].Header.VisiblePosition = 1;
            this.ultraGrid1.Refresh();
        }

        public void auxListInsert(string petName, string petType, string petBreed, int duenyo)
        {
            //src.Select(s => s ?? "NULL").ToList();
            auxCargarListaArrayNulos();
            arrayInsertPet = listInsertPet.ToArray();
            arrayInsertPet[1] = petName;
            arrayInsertPet[2] = petType;
            arrayInsertPet[3] = petBreed;
            dueño = duenyo;
        }

        public void auxCargarListaArrayNulos()
        {

            //int numeroColumnas = (from a in db1.PET select a).Count();

            arrayInsertPet = new string[numeroColumnas];
            listInsertPet = new List<string>(arrayInsertPet.Length);
            int i = 0, index = arrayInsertPet.Length;
            Console.WriteLine("length: {0}", index);
            while (i < index)
            {
                listInsertPet.Add(null);
                //Console.WriteLine("add {0}: {1}",i);
                ++i;
            }

            i = 0;

        }

        
      

        public int intFindIdOwner()
        {

            string nombreCompletoDueño = cbDueño.Text.Trim().ToLower();
            string[] nombreApellido = nombreCompletoDueño.Split(' ');
            string nombre = nombreApellido[0];
            string apellido = nombreApellido[1];

            var x = (from a in db1.PET_OWNER
                     where a.OwnerFirstName.Trim().ToLower() == nombre && a.OwnerLastName.Trim().ToLower() == apellido
                     select a.OwnerID).SingleOrDefault();
            lbDueño.Text = x.ToString();

            return x;
        }


        #endregion

        #region cargarElementos
        //https://stackoverflow.com/questions/600869/how-to-bind-a-list-to-a-combobox-winforms

            public void cargarCBTipoAnimal()
            {
                listaTipoAnimales = new List<string> { "default", "perro", "gato", "peces", "roedores", "pajaros", "alien" };

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = listaTipoAnimales;
                cbTipoAnimal.DataSource = bindingSource.DataSource;    

        }


        public void DTPtimeToday()
        {
            dtFechaNacimiento.CustomFormat = "dd-MM-yyy";
            dtFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtFechaNacimiento.Value = DateTime.Today;
        }

        public void cargarDueño()
        {

            //https://stackoverflow.com/questions/12501183/data-binding-linq-query-to-datagridview-in-entity-framework-5-0
            //listaTipoAnimales = new List<string> { "default", "perro", "gato", "peces", "roedores", "pajaros", "alien" };
            //List<string> listaDueños;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = (from d in db1.PET_OWNER
                                       select (d.OwnerFirstName.Trim() +" "+d.OwnerLastName.Trim()) ).ToList();
            cbDueño.DataSource = bindingSource.DataSource;

        }

        #endregion

        #region extracion datos

        class ExtracionDatos3
        {

            public void getSQLDatePET2(ref VeterianEntities db, ref List<PET> listaMascotas, ref PET[] arrayPets)
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

            }
        }


        #endregion

        #region Classes
        /*
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
         */

        #endregion

        #region varios

                private void label3_Click(object sender, EventArgs e)
                {

                }

                private void textBox1_TextChanged(object sender, EventArgs e)
                {

                }

                private void label4_Click(object sender, EventArgs e)
                {

                }



        #endregion


    }

}