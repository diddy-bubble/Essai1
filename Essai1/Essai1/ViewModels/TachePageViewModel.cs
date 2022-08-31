using Essai1.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Essai1.ViewModels
{
    public partial class TachePageViewModel : BaseViewModel
    {
        // Fields

        int id;
        string titre;
        string description;
        Priorite priorite;
        DateTime dateDeDebut;
        DateTime dateDeFin;
        bool isEmergency;
        bool isCompleted;


        // Command
        public ICommand CreateCommand { get; private set; }


        // Properties

        public string Titre
        {
            get => titre;
            set
            {
                SetValue(ref titre, value);
            } 
        }
        public int Id 
        {
            get => id;
            set
            {
                SetValue(ref id, value);
            } 
        }
        public string Description
        {
            get => description;
            set
            {
                SetValue(ref description, value);
            } 
        }
        public Priorite Priorite
        {
            get => priorite;
            set
            {
                SetValue(ref priorite, value);
            } 
        }
        public DateTime DateDeDebut
        {
            get => dateDeDebut;
            set
            {
                SetValue(ref dateDeDebut, value);
            } 
        }
        public DateTime DateDeFin
        {
            get => dateDeFin;
            set
            {
                SetValue(ref dateDeFin, value);
            } 
        }
        public bool IsEmergency
        {
            get => isEmergency;
            set
            {
                SetValue(ref isEmergency, value);
            } 
        }
        public bool IsCompleted
        {
            get => isCompleted;
            set
            {
                SetValue(ref isCompleted, value);
            } 
        }


        // Constructor
        public TachePageViewModel()
        {
            CreateCommand = new Command(Create);
        }

        void Create()
        {
            bool isValid;
            isValid = (!String.IsNullOrWhiteSpace(Titre)) &&
                (!String.IsNullOrWhiteSpace(Description));

            if (isValid)
            {
                Tache tache = new Tache(Titre, Description, DateDeDebut, DateDeFin, Priorite);
            }
        }
    }
}
