using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using classeheritages.CHeritages;

namespace classeheritages
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public List<Diffusion> lesdiffusions = new List<Diffusion>();

        public MainWindow()
        {

            InitializeComponent();
            ReAjout();
            LstDiffusion.ItemsSource = lesdiffusions;

        }

        private void MisajourLst()
        {
            LstDiffusion.Items.Clear(); // viser la liste
            foreach (Diffusion uneDiffusion in lesdiffusions)
            {
                LstDiffusion.Items.Add(uneDiffusion.getInfos());
            }

        }

        private void ReAjout()
        {
            if (rdbFilm.IsChecked == true)
            {

                lblRecette.Visibility = Visibility.Visible;
                txtRecette.Visibility = Visibility.Visible;
                lblNBepisodes.Visibility = (Visibility)2;
                txtNbepisodes.Visibility = (Visibility)2;
            }
            else
                 if (rdbSerie.IsChecked == true)
            {
                lblRecette.Visibility = (Visibility)2;
                txtRecette.Visibility = (Visibility)2;
                lblNBepisodes.Visibility = Visibility.Visible;
                txtNbepisodes.Visibility = Visibility.Visible;
            }
        }

        private void rdbFilm_Checked(object sender, RoutedEventArgs e)
        {
           
            ReAjout();
        }

        private void rdbSerie_Checked(object sender, RoutedEventArgs e)
        {

            
            ReAjout();
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {

            Diffusion uneDiffusion ;  // lôbjet est donc reste ainsi parce que c'est une classe abstraite

            // ici je suis enttrain de remplir ma liste lesdiffusions

            if (rdbFilm.IsChecked == true)
            {
                uneDiffusion = new Film(txtTitre.Text, int.Parse(txtAnnee.Text), int.Parse(txtRecette.Text));
            }
            else
            {
                uneDiffusion = new Serie(txtTitre.Text, int.Parse(txtAnnee.Text), int.Parse(txtNbepisodes.Text));
            }

            lesdiffusions.Add(uneDiffusion);

        }
    }
}
