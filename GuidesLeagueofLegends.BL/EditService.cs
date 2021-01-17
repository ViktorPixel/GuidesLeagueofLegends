using GuidesLeagueofLegends.BE;
using GuidesLeagueofLegends.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidesLeagueofLegends.BL
{
    public class EditService
    {
        private EditDALC _editDALC;

        private EditDALC EditDALC
        {
            get
            {
                if (_editDALC == null)
                {
                    _editDALC = new EditDALC();
                }
                return _editDALC;
            }
        }
        public void AddPesrons(Persons persons)
        {
            EditDALC.AddPerson(persons);          
        }

        public void AddGuides(Guides guides)
        {
            EditDALC.AddGuides(guides);
        }

        public List<Persons> GetPersons()
        {
            return EditDALC.GetPersons();
        }

        public List<Guides> GetGuides()
        {
            return EditDALC.GetGuides();
        }

        public List<Guides> GetGuides(int heroID)
        {
            return EditDALC.GetGuides(heroID);
        }
    }
}
