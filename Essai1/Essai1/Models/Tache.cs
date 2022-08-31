using Essai1.ViewModels;
using System;
 using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Essai1.Models
{
    public enum Priorite
    {
        FAIBLE,
        MOYENNE,
        ELEVEE
    }
    public class Tache : BaseViewModel
    {
        private static int count = 0;
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public Priorite priorite { get; set; }
        public DateTime DateDeDebut { get; set; }
        public DateTime DateDeFin { get; set; }
        private bool isEmergency;
        public bool IsEmergency
        {
            get => isEmergency;
            set
            {
                SetValue(ref isEmergency, value);
                OnPropertyChanged(nameof(BgColor));
            }
        }
        public bool IsCompleted { get; set; }

        public Color BgColor
        {
            get 
            {
                if (IsEmergency)
                {
                    return Color.FromHex("#FF0000");
                }
                else
                {
                    return Color.FromHex("#FFF");
                }
            }
        }
        public string PrioriteString
        {
            get
            {
                string prio = "";
                switch ((int)priorite)
                {
                    case 0:
                        prio = "Faible";
                        break;
                    case 1:
                        prio = "Moyenne";
                        break;
                    case 2:
                        prio = "Difficile";
                        break;
                }
                return prio;
            }    
        }
        public string Date
        {
            get
            {
                return $"{DateDeDebut.ToString("dd-MM-yyy")} | {DateDeFin.ToString("dd-MM-yyy")}";
            }
        }


        public Tache(string titre, string description, 
            Priorite _priorite = Priorite.FAIBLE)
        {
            Id = count;
            count++;
            Titre = titre;
            Description = description;
            priorite = _priorite;
            DateDeDebut = DateTime.Now;
            DateDeFin = DateTime.Now;
            IsEmergency = false;
            IsCompleted = false;
        }
        public Tache(string titre, string description, DateTime dateDeDebut, DateTime dateDeFin,
            Priorite _priorite = Priorite.FAIBLE)
        {
            Id = count;
            count++;
            Titre = titre;
            Description = description;
            priorite = _priorite;
            DateDeDebut = dateDeDebut;
            DateDeFin = dateDeFin;
            IsEmergency = false;
            IsCompleted = false;
        }
    }
}
