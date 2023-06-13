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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbNick.Text) || String.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    MessageBox.Show("Fields with '*' must be filled!");
                    return;
                }

                UserRepository userRepository = new UserRepository(new DBAdvertisementContext());
                var checkNick = userRepository.GetAll().FirstOrDefault(x => x.Username == tbNick.Text.Trim());
                if (checkNick != null)
                {
                    MessageBox.Show("Account with this nickname already exists");
                    return;
                }

                Users tmp = new Users()
                {
                    Username = tbNick.Text,
                    Password = tbPassword.Text
                };

                userRepository.CreateOrUpdate(tmp);
                userRepository.Save();

                MessageBox.Show($"Employee account successfully created!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
