using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        //ArrayList listOfBuildings = new ArrayList();
        List<Building> listOfBuildings = new List<Building>();
        DataTable autoTable = new DataTable();

        DataColumn colBuildType = new DataColumn("Тип постройки");
        DataColumn colFloorCount = new DataColumn("Кол-во этажей");
        DataColumn colFloorArea = new DataColumn("Площадь этажа");
        DataColumn colPeopleCount = new DataColumn("Кол-во жильцов");
        DataColumn colGardenArea = new DataColumn("Площадь участка");
        DataColumn colAreaPerMan = new DataColumn("Площадь на человека");
        DataColumn colFullArea = new DataColumn("Общая площадь");


        public Form1()
        {
            InitializeComponent();

            autoTable.Columns.Add(colBuildType);
            autoTable.Columns.Add(colFloorCount);
            autoTable.Columns.Add(colFloorArea);
            autoTable.Columns.Add(colPeopleCount);
            autoTable.Columns.Add(colGardenArea);
            autoTable.Columns.Add(colAreaPerMan);
            autoTable.Columns.Add(colFullArea);

            dgView.DataSource = autoTable;

        }

        private void cbTypeOfBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeOfBuilding.Text == "Сад")
            {
                lPeopleCount.Enabled = true;
                tbPeopleCount.Enabled = true;
                lGardenArea.Enabled = true;
                tbGardenArea.Enabled = true;
            }
            else if (cbTypeOfBuilding.Text == "Гараж")
            {
                tbPeopleCount.Text = "";
                tbGardenArea.Text = "";
                lPeopleCount.Enabled = false;
                tbPeopleCount.Enabled = false;
                lGardenArea.Enabled = false;
                tbGardenArea.Enabled = false;
            }
            else
            {
                lPeopleCount.Enabled = true;
                tbPeopleCount.Enabled = true;
                tbGardenArea.Text = "";
                lGardenArea.Enabled = false;
                tbGardenArea.Enabled = false;
            }
        }

        private void DrawTable()
        {
            foreach (Building el in listOfBuildings)
            {
                switch (el.type) {
                    case "Сад":
                        Garden item1 = el as Garden;
                        DataRow row1 = autoTable.NewRow();
                        row1[colBuildType] = item1.type;
                        row1[colFloorCount] = item1.FloorCount;
                        row1[colFloorArea] = item1.FloorArea;
                        row1[colPeopleCount] = item1.PeopleCount;
                        row1[colAreaPerMan] = item1.AreaPerMan();
                        row1[colGardenArea] = item1.GardenArea;
                        row1[colFullArea] = item1.FullArea;

                        autoTable.Rows.Add(row1);
                        break;
                    case "Гараж":
                        Garage item2 = el as Garage;
                        DataRow row2 = autoTable.NewRow();
                        row2[colBuildType] = item2.type;
                        row2[colFloorCount] = item2.FloorCount;
                        row2[colFloorArea] = item2.FloorArea;
                        row2[colPeopleCount] = item2.PeopleCount;
                        row2[colAreaPerMan] = item2.AreaPerMan();
                        row2[colGardenArea] = 0;
                        row2[colFullArea] = item2.FullArea;
                        autoTable.Rows.Add(row2);
                        break;
                    case "Коттедж":
                        Cottage item3 = el as Cottage;
                        DataRow row3 = autoTable.NewRow();
                        row3[colBuildType] = item3.type;
                        row3[colFloorCount] = item3.FloorCount;
                        row3[colFloorArea] = item3.FloorArea;
                        row3[colPeopleCount] = item3.PeopleCount;
                        row3[colAreaPerMan] = item3.AreaPerMan();
                        row3[colGardenArea] = 0;
                        row3[colFullArea] = item3.FullArea;
                        autoTable.Rows.Add(row3);
                        break;
                } 
            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
                {
                    switch (cbTypeOfBuilding.Text)
                    {
                        case "Сад":
                            Garden item1 = new Garden(
                                Convert.ToInt16(tbFloorCount.Text),
                                Convert.ToInt16(tbFloorArea.Text),
                                Convert.ToInt16(tbPeopleCount.Text),
                                Convert.ToInt16(tbGardenArea.Text));
                            listOfBuildings.Add(item1);
                            DataRow row1 = autoTable.NewRow();
                            row1[colBuildType] = cbTypeOfBuilding.Text;
                            row1[colFloorCount] = item1.FloorCount;
                            row1[colFloorArea] = item1.FloorArea;
                            row1[colPeopleCount] = item1.PeopleCount;
                            row1[colGardenArea] = item1.GardenArea;
                            row1[colAreaPerMan] = item1.AreaPerMan();
                            row1[colFullArea] = item1.FullArea;
                            autoTable.Rows.Add(row1);
                            break;
                        case "Гараж":
                            Garage item2 = new Garage(
                                Convert.ToInt16(tbFloorCount.Text),
                                Convert.ToInt16(tbFloorArea.Text));
                            listOfBuildings.Add(item2);
                            DataRow row2 = autoTable.NewRow();
                            row2[colBuildType] = cbTypeOfBuilding.Text;
                            row2[colFloorCount] = item2.FloorCount;
                            row2[colFloorArea] = item2.FloorArea;
                            row2[colPeopleCount] = item2.PeopleCount;
                            row2[colGardenArea] = 0;
                            row2[colAreaPerMan] = item2.AreaPerMan();
                            row2[colFullArea] = item2.FullArea;
                            autoTable.Rows.Add(row2);
                            break;
                        case "Коттедж":
                            Cottage item3 = new Cottage(
                                Convert.ToInt16(tbFloorCount.Text),
                                Convert.ToInt16(tbFloorArea.Text),
                                Convert.ToInt16(tbPeopleCount.Text));
                            listOfBuildings.Add(item3);
                            DataRow row3 = autoTable.NewRow();
                            row3[colBuildType] = cbTypeOfBuilding.Text;
                            row3[colFloorCount] = item3.FloorCount;
                            row3[colFloorArea] = item3.FloorArea;
                            row3[colPeopleCount] = item3.PeopleCount;
                            row3[colGardenArea] = 0;
                            row3[colAreaPerMan] = item3.AreaPerMan();
                            row3[colFullArea] = item3.FullArea;
                            autoTable.Rows.Add(row3);
                            break;
                        default:
                            MessageBox.Show("Выберите тип постройки!");
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Введены не корректные данные \nили не все поля заполнены!");
                }
            
            
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            autoTable.Rows.Clear();
            switch (cbSort.Text)
            {
                case "По возрастанию":
                    listOfBuildings.Sort(new SortUp());
                    break;
                case "По убыванию":
                    listOfBuildings.Sort(new SortDown());
                    break;
                default:
                    break;
            }
            DrawTable();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
        }
    }
}
