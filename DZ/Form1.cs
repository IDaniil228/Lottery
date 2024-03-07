using DZ.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DZ
{
    public partial class MainForm : Form
    {
        string openFile;
        List<Entity> entities;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, который подгружает информацию из файлов xml и json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "xml files (*.xml)|*.xml|json files (*.json)|*.json";
            if (open.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            openFile = open.FileName;
            string jsonFileText = File.ReadAllText(openFile);
            FileStream opFile = new FileStream(openFile, FileMode.Open);
            try
            {
                if (Path.GetExtension(openFile) == ".xml")
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Entity>), new[] { typeof(Organ), typeof(Prize), typeof(Shop) });
                    entities = xml.Deserialize(opFile) as List<Entity>;
                }
                else if (Path.GetExtension(openFile) == ".json")
                {
                    entities = JsonSerializer.Deserialize<List<Entity>>(jsonFileText);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Файл успешно загружен", "Загрузка файла", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Метод, который обрабатывает кнопку "Показать" и выводит информацию в ListOfEntity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShow_Click(object sender, EventArgs e)
        {

            if (openFile == null)
            {
                return;
            }
            for (int i = 0; i < entities.Count; i++)
            {
                TreeNode TN = new TreeNode(entities[i].title);
                for (int j = 0; j < entities[i].List.Count; j++)
                {
                    if (entities[i].List[j] is Organ)
                    {
                        Organ temp = entities[i].List[j] as Organ;
                        TN.Nodes.Add(temp.name);
                    }
                    if (entities[i].List[j] is Prize)
                    {
                        Prize temp = entities[i].List[j] as Prize;
                        TN.Nodes.Add(temp.mainPrice);
                    }
                    if (entities[i].List[j] is Shop)
                    {
                        Shop temp = entities[i].List[j] as Shop;
                        TN.Nodes.Add(temp.name);
                    }
                }
                ListOfEntity.Nodes.Add(TN);
            }
        }
        /// <summary>
        /// Метод, который выводит информацию в таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListOfEntity_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string title = ListOfEntity.SelectedNode.Text;
            bool flag = false;
            for (int i = 0; i < entities.Count; i++)
            {
                for (int j = 0; j < entities[i].List.Count; j++)
                {
                    if (entities[i].List[j] is Organ)
                    {
                        Organ temp = entities[i].List[j] as Organ;
                        if (temp.name == title)
                        {
                            flag = true;
                            info_1.Text = temp.name;
                            info_2.Text = temp.price;
                            info_3.Text = temp.maxPrize;
                            info_4.Text = temp.numOfTickets;
                            info_5.Text = "Номер организации - " + temp.number.ToString();
                            break;
                        }

                    }
                    if (entities[i].List[j] is Prize)
                    {
                        Prize temp = entities[i].List[j] as Prize;
                        if (temp.mainPrice == title)
                        {
                            flag = true;
                            info_1.Text = temp.mainPrice;
                            info_2.Text = temp.priceOfTicket;
                            info_3.Text = "Шанс на выиграшь = " + temp.chance.ToString();
                            info_4.Text = "Тираж билета - " + temp.circulation.ToString();
                            info_5.Text = "Номер билета - " + temp.number.ToString();
                        }
                    }
                    if (entities[i].List[j] is Shop)
                    {
                        Shop temp = entities[i].List[j] as Shop;
                        if (temp.name == title)
                        {
                            info_1.Text = temp.name;
                            info_2.Text = "Адрес - " + temp.address;
                            info_3.Text = "Время работы - " + temp.timeOfWork;
                            info_4.Text = "Кол-во билетов - " + temp.numbOfTicket.ToString();
                            info_5.Text = "Цена за билеты - " + temp.priceOfTicket.ToString();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Метод, который обрабатывает кнопку "Выход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
