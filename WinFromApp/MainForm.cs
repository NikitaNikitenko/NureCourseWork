using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFromApp.Context;
using WinFromApp.Repositories;

namespace WinFromApp
{
    public partial class MainForm : Form
    {
        Users user;
        AdvertisementRepository advertisementRepository;
        CategoryRepository categoryRepository;
        public MainForm(Users user)
        {
            InitializeComponent();
            this.user = user;
            advertisementRepository = new AdvertisementRepository(new DBAdvertisementContext());
            dataGridView1.DataSource = advertisementRepository.GetAll()
                                                              .Select(x => new { Title = x.Title,
                                                                                 Category = x.Categories.CategoryName,
                                                                                 Price = x.Price,
                                                                                 PostData = x.PostDate,
                                                                                 User = x.Users.Username}).ToList();

            categoryRepository = new CategoryRepository(new DBAdvertisementContext());
            var categories = categoryRepository.GetAll();
            string[] mas = new string[categories.Count()];
            int i = 0;
            foreach (var category in categories)
            {
                mas[i++] = category.CategoryName;
            }
            comboBox1.Items.AddRange(mas);

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = comboBox1.SelectedItem.ToString();

            dataGridView1.DataSource = advertisementRepository.GetAll()
                                                              .Where(ad => ad.Categories.CategoryName == selectedCategory)
                                                              .Select(x => new {
                                                                  Title = x.Title,
                                                                  Category = x.Categories.CategoryName,
                                                                  Price = x.Price,
                                                                  PostData = x.PostDate,
                                                                  User = x.Users.Username
                                                              }).ToList();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = textBox1.Text;

            var advertisements = advertisementRepository.GetAll().ToList();


            dataGridView1.DataSource = advertisements.Where(ad => ad.Title.Contains(searchText))
                                                              .Select(x => new {
                                                                  Title = x.Title,
                                                                  Category = x.Categories.CategoryName,
                                                                  Price = x.Price,
                                                                  PostData = x.PostDate,
                                                                  User = x.Users.Username
                                                              }).ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = advertisementRepository.GetAll()
                                                              .Select(x => new {
                                                                  Title = x.Title,
                                                                  Category = x.Categories.CategoryName,
                                                                  Price = x.Price,
                                                                  PostData = x.PostDate,
                                                                  User = x.Users.Username
                                                              }).ToList();
        }
    }
}
