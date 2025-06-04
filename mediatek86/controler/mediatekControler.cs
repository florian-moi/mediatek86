using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.Model;
using mediatek86.dal;

namespace mediatek86.controler
{
    public class mediatekControler
    {
        private readonly personnelAccess personnelAccess;
        private readonly responsableAccess responsableAcess;
        private readonly serviceAccess serviceAccess;
        private readonly motifAccess motifAccess;
        private readonly absenceAccess absenceAccess;

        public mediatekControler()
        {
            personnelAccess = new personnelAccess();
            responsableAcess = new responsableAccess();
            serviceAccess = new serviceAccess();
            motifAccess = new motifAccess();
            absenceAccess = new absenceAccess();

        }

        public List<personnel> GetPersonnels()
        {
            return personnelAccess.Getpersonnel();
        }

        public List<service> GetServices()
        {
            return serviceAccess.Getservice();
        }

        public List<motif> GetMotifs()
        {
            return motifAccess.GetMotifs();
        }

        public void AddPersonnel(personnel personnel)
        {
            personnelAccess.Addpersonnel(personnel);
        }

        public void DelPersonnel(personnel personnel)
        {
            personnelAccess.Delpersonnel(personnel);
        }

        public void Updatepersonnel(personnel personnel)
        {
            personnelAccess.Updatepersonnel(personnel);
        }

        public bool ControleConnection(responsable responsable)
        {
            return responsableAcess.ControleConnection(responsable);
        }

        public List<absence> GetAbsence(personnel personnel)
        {
            return absenceAccess.GetAbsence(personnel);
        }

        public void DelAbsence(absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        public void AddAbsence(absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        public void UpdateAbsence(absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }
    }
}
