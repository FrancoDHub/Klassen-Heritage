using System;

namespace classeheritages.CHeritages
{

    /// <summary>
    /// classe abstraite
    /// </summary>
    public abstract class Diffusion
    {
        /// <summary>
        /// /titre de la diffusion
        /// </summary>
        protected string titre; // la particularite de protected c'est qu'il n'est pas visible a l'exterieur mais chez les classes filles { get; set; }
        /// <summary>
        /// annee
        /// </summary>
        protected int annee;

        /// <summary>
        /// Constructeur avec parametre
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="annee"></param>
        public Diffusion(string titre, int annee) // constructeur
        {
            this.titre = titre;
            this.annee = annee;
        }

        /// <summary>
        /// encapsulation
        /// </summary>
        public string Titre  // les propietes des champs
        {
            get { return titre; }
            set { titre = value; }
        }
        /// <summary>
        /// getter sur titre
        /// </summary>
        /// <returns>titre</returns>
        public string getTitre()  // les propietes des champs
        {
            return this.titre;
        }

        /// <summary>
        /// annee propriete
        /// </summary>
        public int Annee // Proprietes
        {
            get { return annee; }
            set { annee = value; }
        }
        /// <summary>
        /// getter sur annee
        /// </summary>
        /// <returns>annee</returns>
        public int getAnnee() // Proprietes
        {
           return this.annee;
        }

        /// <summary>
        /// methode getinfos
        /// </summary>
        /// <returns></returns>
        public abstract String getInfos();
    }
   
    /// <summary>
    /// class Film herite de diffusion
    /// </summary>
    public class Film : Diffusion

    {

      
        private int recette;
        /// <summary>
        /// encapsulation
        /// </summary>
        public int Recette // Proprietes
        {
            get { return recette; }
            set { recette = value; }
        }

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="annee"></param>
        /// <param name="recette"></param>
        public Film(string titre, int annee, int recette) : base(titre, annee)

        {
           this.recette = recette;
        }

        /// <summary>
        ///  methode de la classe mere
        /// </summary>
        /// <returns>les proprietes prives ou protectrices</returns>
        public override string getInfos()
        {
            return base.titre + " " + base.annee + " (recette = " + this.recette + ")";


        }
    }

    /// <summary>
    /// classe serie herite de Diffusion
    /// </summary>
    public class Serie : Diffusion
    {
        private int nBepisodes;
        /// <summary>
        /// definir les proprietes
        /// </summary>
        public int NBepisodes // Proprietes
        {
            get { return nBepisodes; }
            set { nBepisodes = value; }
        }
        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="annee"></param>
        /// <param name="nBepisodes"></param>
        public Serie(string titre, int annee, int nBepisodes) : base(titre, annee)
        {
            NBepisodes = nBepisodes;
        }
        /// <summary>
        /// methode redefini par rapport a la methode de la classe mere
        /// </summary>
        /// <returns></returns>
        public override string getInfos()
        {
            return base.annee + " " + base.titre + " (NBepisodes = " + this.NBepisodes + ")";
        }
       
        

    }
}
