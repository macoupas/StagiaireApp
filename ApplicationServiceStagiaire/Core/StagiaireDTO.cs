using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Core
{
    public class StagiaireDTO : INotifyPropertyChanged
    {
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private int _id;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private int? _codePostal;
        private string _ville;
        private int? _age;
        private string _sexe;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                NotifyPropertyChanged(nameof(Id));
            }
        }
        public string Nom
        {
            get => _nom;
            set
            {
                _nom = value;
                NotifyPropertyChanged(nameof(Nom));
            }
        }
        public string Adresse
        {
            get => _adresse;
            set
            {
                _adresse = value;
                NotifyPropertyChanged(nameof(Adresse));
            }
        }
        public int? CodePostal
        {
            get => _codePostal;
            set
            {
                _codePostal = value;
                NotifyPropertyChanged(nameof(CodePostal));
            }
        }
        public string Ville
        {
            get => _ville;
            set
            {
                _ville = value;
                NotifyPropertyChanged(nameof(Ville));
            }
        }
        public int? Age
        {
            get => _age;
            set
            {
                _age = value;
                NotifyPropertyChanged(nameof(Age));
            }
        }
        public string Sexe
        {
            get => _sexe;
            set
            {
                _sexe = value;
                NotifyPropertyChanged(nameof(Sexe));
            }
        }

        public string Prenom
        {
            get => _prenom;
            set
            {
                _prenom = value;
                NotifyPropertyChanged(nameof(Prenom));
            }
        }

        public StagiaireDTO()
        {
            this.Nom = string.Empty;
            this.Prenom = string.Empty;
            this.Adresse = string.Empty;
            this.CodePostal = null;
            this.Ville = string.Empty;
            this.Age = null;
            this.Sexe = "M";
        }

        public StagiaireDTO(string Nom, string Prenom, string Adresse, int? CodePostal, string Ville, int? Age, string Sexe)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.CodePostal = CodePostal;
            this.Ville = Ville;
            this.Age = Age;
            this.Sexe = Sexe;
        }

        public StagiaireDTO(int Id, string Nom, string Prenom, string Adresse, int? CodePostal, string Ville, int? Age, string Sexe)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.CodePostal = CodePostal;
            this.Ville = Ville;
            this.Age = Age;
            this.Sexe = Sexe;
        }
    }
}
