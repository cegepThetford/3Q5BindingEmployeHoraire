using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingEmployeHoraire_Affaires
{
    public class EmployeHoraire
    {
        private string _nom;
        private decimal _tauxHoraire;
        private decimal _nbHeures;

        public EmployeHoraire(string nom, decimal taux)
        {
            _nom = nom;
            _tauxHoraire = taux;
            _nbHeures = 0.0m;
        }
        public void ajouterHeures(decimal nbH)
        {
            _nbHeures += nbH;
        }
        public string Nom { get { return _nom; } set { _nom = value; } }
        public decimal TauxHoraire { get { return _tauxHoraire; } set { _tauxHoraire = value; } }
        public decimal NbHeures { get { return _nbHeures; } set { _nbHeures = value; } }
        public decimal calculerSalaireBrut()
        {
            decimal salaire = _tauxHoraire * _nbHeures;
            if (_nbHeures > 75.0m)
                salaire += 0.5m * _tauxHoraire * (_nbHeures - 75.0m);
            return salaire;
        }
        public override int GetHashCode()
        {
            return _nom.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is EmployeHoraire))
                return false;
            EmployeHoraire empl = (EmployeHoraire)obj;
            return empl.Nom.Equals(_nom);
        }
    }
}
