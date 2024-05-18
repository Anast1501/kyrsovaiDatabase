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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kyrsovaiDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public DataGridView PlaneDataGrid
        {
            get; set;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxaddID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            
            string[] Data = { textBoxaddID.Text, textBoxADDdestination.Text, textBoxADDdeparture.Text, textBoxADDarrival.Text, textBoxADDcount.Text };//дописать проверку условий валидности данных
            PlaneDataGrid.Rows.Add(Data);
            WriteDataToJson(Data);
            this.Close();
        }

        private void WriteDataToJson(string[] data)
        {
            string filepath = "C:\\Users\\parfe\\OneDrive\\Desktop\\cursach.json";
            string jsonRecord = $"\"{data[0]}\": {{\n" +
                                $" \"Kyda\": \"{data[1]}\",\n" +
                                $" \"timeTyda\": \"{data[2]}\",\n" +
                                $" \"timeSyda\": \"{data[3]}\",\n" +
                                $" \"countFreeSeats\": \"{data[4]}\"\n" +
                                $" }}";
            string NewJson =File.ReadAllText(filepath);
            NewJson = NewJson.TrimEnd('}', '\r', '\n');

            if (!string.IsNullOrEmpty(NewJson) )
            {
                NewJson += "},";
            }

            string json = NewJson + "\n " + jsonRecord + "\n}";

            File.WriteAllText(filepath, json);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxADDcount_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
