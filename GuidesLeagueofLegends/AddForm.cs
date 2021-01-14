using GuidesLeagueofLegends.BE;
using GuidesLeagueofLegends.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidesLeagueofLegends
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private EditService _editService;
        private EditService EditService
        {
            get
            {
                if (_editService == null)
                {
                    _editService = new EditService();
                }
                return _editService;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persons persons = new Persons();

            persons.NameHero = tbName.Text;
            persons.Description = tbDesc.Text;

            EditService.AddPesrons(persons);
        }
    }
}
