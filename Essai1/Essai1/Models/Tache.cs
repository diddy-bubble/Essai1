 using System;
 using System.Collections.Generic;
 using System.Text;

namespace Essai1.Models
{
    public enum Priorite
    {
        FAIBLE,
        MOYENNE,
        ELEVEE
    }
    public class Tache
    {
        private static int count = 0;
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public Priorite priorite { get; set; }
        public DateTime DateDeDebut { get; set; }
        public DateTime DateDeFin { get; set; }
        public bool IsCompleted { get; set; }
        public string Date
        {
            get
            {
                return $"{DateDeDebut.ToString("dd-MM-yyy")} | {DateDeFin.ToString("dd-MM-yyy")}";
            }
        }
        public Tache()
        {
            Id = count;
            count++;
        }
    }
}
