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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            try
            {
                UserRepository userRepository = new UserRepository(new DBAdvertisementContext());
                var users = userRepository.GetAll().FirstOrDefault(x => x.Username == tbLogin.Text.Trim());
                if (users == null) { MessageBox.Show("Nick does not exist"); return; }

                if (users.Password == tbPassword.Text)
                {
                    new MainForm(users).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RegForm().ShowDialog();
        }
    }
}
