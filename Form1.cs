using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using static kyrsovaiDatabase.CheckUser;

namespace kyrsovaiDatabase
{
    public partial class Form1 : Form
    {
        private CheckUser checkUserForm;

       
        public Form1()
        {
            InitializeComponent();
            // Инициализируем экземпляр класса ChekUser
            checkUserForm = new CheckUser();
            // Подписываемся на событие PasswordChecked через экземпляр класса ChekUser
            
            
            checkUserForm.PasswordChecked += HandlePasswordCheckResult;
            PasswordCheck();
            //ParseData(); // Уберите вызов здесь, так как он будет выполнен после корректной проверки пароля
        }

        public class DataTransferObject
        {
            public string PlaneID { get; set;}
        }


        private void HandlePasswordCheckResult(object sender, bool result)
        {
            // Обработка результата проверки пароля
            if (result==true)
            {
                // Пароль верный, продолжаем выполнение программы
                ParseData();
            }
            else
            {
                // Пароль неверный, предпринимаем необходимые действия
                MessageBox.Show("Неверный пароль!");
                //this.Close();
                // Дополнительные действия в случае неверного пароля
            }
        }

        private void PasswordCheck()
        {
           // CheckUser pass = new CheckUser();
            checkUserForm.ShowDialog();
            //return true;
        }

        public void ParseData()
        {   
            PlaneDataGrid.Rows.Clear();
            string filePath = "C:\\Users\\parfe\\OneDrive\\Desktop\\cursach.json";

            // Чтение строк из файла
            string lines = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(lines);
            // Обработка каждой строки
            foreach (var line in data)
            {
                
                // Извлечение данных
                string id = line.Key;
                string destination = line.Value["Kyda"];
                string departure = line.Value["timeTyda"];
                string arrival = line.Value["timeSyda"];
                string count = line.Value["countFreeSeats"];

                // Добавление данных в таблицу
                PlaneDataGrid.Rows.Add(id, destination, departure, arrival, count);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string filepath = "C:\\Users\\parfe\\Desktop\\cursach.json";
            Form2 form2 = new Form2();
            form2.PlaneDataGrid = PlaneDataGrid;
            form2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string filePath = "C:\\Users\\parfe\\OneDrive\\Desktop\\cursach.json";
            string jsonContent = File.ReadAllText(filePath);
            JObject jsObject = JObject.Parse(jsonContent);

            if (jsObject[textPlaneIdDel.Text] != null )
            {
                jsObject.Remove(textPlaneIdDel.Text);

                string updateJS= jsObject.ToString();

                File.WriteAllText(filePath, updateJS);
            }
            ParseData();
        }
        int RemoveLineWithElement(string filePath, string fordel)
        {
            string[] lines = File.ReadAllLines(filePath);
            int index = Array.FindIndex(lines, line => line.Contains(fordel));
            var newLines = new System.Collections.Generic.List<string>();
            foreach (string line in lines)
            {
                if (!line.Contains(fordel))
                {
                    newLines.Add(line);
                }
            }


            File.WriteAllLines(filePath, newLines);
            return index;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string ToFind = comboBox1.SelectedItem.ToString();
            string filePath = "C:\\Users\\parfe\\OneDrive\\Desktop\\cursach.json";

            // Чтение строк из файла
            string lines = File.ReadAllText(filePath);

            CityFound.Rows.Clear();//очитска таблицы 

            //string liness = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(lines);
            // Обработка каждой строки
            foreach (var line in data)
            {
              


                string id = line.Key;
                string destination = line.Value["Kyda"];
             
                string count = line.Value["countFreeSeats"];


                if (destination == ToFind)
                {
                    // Добавление данных в таблицу
                    CityFound.Rows.Add(id, count);
                }



            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            // Получаем номер рейса, для которого нужно изменить количество свободных мест
            string flightNumberToUpdate = textPlaneIdDel.Text;

            DataTransferObject data =new DataTransferObject();
            data.PlaneID = flightNumberToUpdate.ToString();
            // Всплывающее окно
            Form3 form3 = new Form3(data,this);
            form3.ShowDialog();

            // Получаем новое количество свободных мест
            //int newAvailableSeatsCount;

            // Путь к файлу с данными
            string filePath = "C:\\Users\\parfe\\OneDrive\\Desktop\\cursach.json";

            // Считываем данные из файла
            string[] lines = File.ReadAllLines(filePath);

            // Создаем новый список для обновленных строк
            List<string> updatedLines = new List<string>();


            // Обновляем данные в таблице
            ParseData();

            MessageBox.Show("Количество свободных мест успешно изменено.");



        }
    }
}


