using GuidesLeagueofLegends.BE;
using GuidesLeagueofLegends.BL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuidesLeagueofLegends
{
    public partial class MainForm : Form
    {

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

        public MainForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbList.DataSource = EditService.GetPersons();
            cbList.ValueMember = "ID";
            cbList.DisplayMember = "NameHero";
        }
    }
}
