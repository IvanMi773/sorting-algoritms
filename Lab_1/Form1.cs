using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using Lab_1.sorting;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private List<Sportman> sportmans = new List<Sportman>();
        BubbleSort bubbleSort = new BubbleSort();
        ShakerSort shakerSort = new ShakerSort();
        SelectionSort selectionSort = new SelectionSort();
        InsertSort insertSort = new InsertSort();
        StandartShellSort shelltSort = new StandartShellSort();
        KnuthShellSort knuthShellSort = new KnuthShellSort();
        QuickSort quickSort = new QuickSort();
        PiramidalSort piramidalSort = new PiramidalSort();
        BinarySearch binarySearch = new BinarySearch();
        RadixSort radixSort = new RadixSort();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("1", "Id");
            dataGridView1.Columns.Add("2", "Прізвище");
            dataGridView1.Columns.Add("3", "Рік народження");
            dataGridView1.Columns.Add("4", "Вид спорту");
            comboBox1.Items.Add("Сортування бульбашкою");
            comboBox1.Items.Add("Шейкер сортування");
            comboBox1.Items.Add("Сортування вибіркою");
            comboBox1.Items.Add("Сортування вставками");
            comboBox1.Items.Add("Стандартне сортування Шелла");
            comboBox1.Items.Add("Сортування Шелла з формулою Кнута");
            comboBox1.Items.Add("Швидке сортування");
            comboBox1.Items.Add("Пірамідальне сортування");
            comboBox1.Items.Add("Порозрядне сортування");
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength.Equals(0) || textBox3.TextLength.Equals(0) || textBox1.TextLength.Equals(0)) {
                MessageBox.Show("Заповніть всі поля");
            } else {
                sportmans.Add(new Sportman(textBox2.Text, Convert.ToInt32(textBox3.Text), textBox1.Text));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                updateList();
            }
        }

        private void sortByNameBTN_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    bubbleSort.sortByString(sportmans);
                    break;
                case 1:
                    shakerSort.sortByString(sportmans);
                    break;
                case 2:
                    selectionSort.sortByString(sportmans);
                    break;
                case 3:
                    insertSort.sortByString(sportmans);
                    break;
                case 4:
                    shelltSort.sortByString(sportmans);
                    break;
                case 5:
                    knuthShellSort.sortByString(sportmans);
                    break;
                case 6:
                    quickSort.sortByString(sportmans);
                    break;
                case 7:
                    piramidalSort.sortByString(sportmans);
                    break;
                case 8:
                    radixSort.sortByString(sportmans);
                    break;
            }

            updateList();
        }

        private void sortByYearBTN_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    bubbleSort.sortByNumber(sportmans);
                    break;
                case 1:
                    shakerSort.sortByNumber(sportmans);
                    break;
                case 2:
                    selectionSort.sortByNumber(sportmans);
                    break;
                case 3:
                    insertSort.sortByNumber(sportmans);
                    break;
                case 4:
                    shelltSort.sortByNumber(sportmans);
                    break;
                case 5:
                    knuthShellSort.sortByNumber(sportmans);
                    break;
                case 6:
                    quickSort.sortByNumber(sportmans);
                    break;
                case 7:
                    piramidalSort.sortByNumber(sportmans);
                    break;
                case 8:
                    radixSort.sortByNumber(sportmans);
                    break;
            }

            updateList();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream("sportmens.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, sportmans);
            }

            MessageBox.Show("Дані записані в файл");
        }

        private void loadBTN_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream("sportmens.dat", FileMode.OpenOrCreate))
            {
                sportmans = (List<Sportman>)bf.Deserialize(fs);
                updateList();
            }

            MessageBox.Show("Дані зчитані з файлу");
        }

        private void nameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void populationTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void updateList()
        {
            dataGridView1.Rows.Clear();
            int id = 1;
            foreach (Sportman state in sportmans)
            {
                dataGridView1.Rows.Add(id, state.firstName, state.yearOfBorn.ToString(), state.kindOfSport);
                id++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int searchedYear = Convert.ToInt32(textBox4.Text);
            int[] years = new int[sportmans.Count];
            int i = 0;

            foreach (Sportman s in sportmans)
            {
                years[i] = s.yearOfBorn;
                i++;
            }

            var r = binarySearch.Search(years, searchedYear, 0, i);
            string result = "Результати пошуку: ";

            if (r.Count > 0)
            {
                foreach (int res in r)
                {
                    int index = res;
                    index++;
                    result += index + " ";
                }
            } else
            {
                result = "Не знайдено жодного елементу";
            }

            MessageBox.Show(result);
        }
    }
}
