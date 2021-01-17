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
            cbList.DataSource = EditService.GetPersons();
            cbList.ValueMember = "ID";
            cbList.DisplayMember = "NameHero";

            //lbGuides.DataSource = EditService.GetGuides();
            //lbGuides.ValueMember = "HeroID";
            //lbGuides.DisplayMember = "Name";
        }
        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int heroID = (int)cbList.SelectedValue;
            List<Guides> guides = new List<Guides>();
            guides = EditService.GetGuides(heroID);
            lbGuides.DataSource = guides;
            lbGuides.ValueMember = "HeroID";
            lbGuides.DisplayMember = "Name";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void cbList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
        private void tsGuide_Click(object sender, EventArgs e)
        {
            AddGuideForm addGuideForm = new AddGuideForm();
            addGuideForm.ShowDialog();
        }

        private void tsHero_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

     
    }
}
