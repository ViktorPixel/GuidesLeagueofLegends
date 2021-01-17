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
    public partial class AddGuideForm : Form
    {
        public AddGuideForm()
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
        //private void tbDecription_TextChanged(object sender, EventArgs e)
        //{
        //}


        private void AddGuideForm_Load(object sender, EventArgs e)
        {
            cbListHero.DataSource = EditService.GetPersons();
            cbListHero.ValueMember = "ID";
            cbListHero.DisplayMember = "NameHero";
        }                                                                           
                                                                                    
        private void btSave_Click(object sender, EventArgs e)                       
        {                                                                           
            Guides guides = new Guides();                                           
                                                                                    
            guides.HeroID = (int)cbListHero.SelectedValue;
            guides.Name = tbNameGuide.Text;
            guides.Description = tbDecription.Text;

            EditService.AddGuides(guides);
        }
    }
}
