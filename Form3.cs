using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static kyrsovaiDatabase.Form1;

namespace kyrsovaiDatabase
{
    public partial class Form3 : Form
    {

        private readonly DataTransferObject data;
        private readonly Form1 form1;

        public DataGridView PlaneDataGrid
        {
            get; set;
        }


        public Form3(DataTransferObject data,Form1 form1)
        {
            InitializeComponent();
            this.data = data;
            this.form1 = form1;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string newData = textBoxFreeSeat.Text;

            // Дописать проверку валидности данных, если необходимо

            // Получаем путь к файлу с данными


            string filePath = "C:\\Users\\parfe\\OneDrive\\Desktop\\cursach.json";
            string jsonContent = File.ReadAllText(filePath);
            JObject jsObject = JObject.Parse(jsonContent);
            if (jsObject[data.PlaneID] != null) // Check if the PlaneID exists in the JSON data
            {
                jsObject[data.PlaneID]["countFreeSeats"] = newData;

                // Write the updated JSON content back to the file
                File.WriteAllText(filePath, jsObject.ToString());

                // Reload the data in the DataGridView of Form1
                form1.ParseData();

                // Close the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("PlaneID not found in the JSON data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
    
       