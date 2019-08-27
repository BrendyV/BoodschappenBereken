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
using Boodschappen.Lib.Entities;
using Boodschappen.Lib.Services;


namespace BoodschappenBereken.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BeherenBoodschappenServices beherenBoodschappenServices;
        KenmerkenProduct geselecteerdProduct;
        BeherenBoodschappenServices productBeheer;

        public MainWindow()
        {
            InitializeComponent();
            beherenBoodschappenServices = new BeherenBoodschappenServices();
            productBeheer = new BeherenBoodschappenServices();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulCombo();
            VulLijstAan();
            InvullenBijLaden();
        }

        void InvullenBijLaden ()
        {
            txtProduct.Text = "melk";
            cmbAfdeling.SelectedIndex = 1;
            txtAantal.Text = "10";
            cmbStukOfKg.SelectedIndex = 1;
            txtPrijsStukOfKg.Text = "1";
            
        }

        void VulCombo()
        {
            cmbAfdeling.ItemsSource = Enum.GetValues(typeof(Afdelingen));
            cmbStukOfKg.ItemsSource = Enum.GetValues(typeof(StukOfKg));
        }

        KenmerkenProduct InputGevenGui ()
        {
            string productNaam = txtProduct.Text;
            Afdelingen afdeling = (Afdelingen)cmbAfdeling.SelectedItem;
            int aantal = int.Parse(txtAantal.Text.ToString());
            StukOfKg stukOfKg = (StukOfKg)cmbStukOfKg.SelectedItem;
            int prijs = int.Parse(txtAantal.Text.ToString());
            int totalePrijs = int.Parse(lblTotalePrijs.Content.ToString());

            KenmerkenProduct kenmerken = new KenmerkenProduct
                (productNaam, afdeling, aantal, stukOfKg, prijs, totalePrijs);

            return kenmerken;
        }

        void VulLijstAan ()
        {
            lstBoodschappenLijst.ItemsSource = BeherenBoodschappenServices.KenmerkenProducts; //Maken dat in de class static erbij staat. Anders wil hij het nemen
            lstBoodschappenLijst.Items.Refresh();
        }

        void MaakVeldenLeeg()
        {
            lstBoodschappenLijst.SelectedIndex = -1;
            txtProduct.Text = " ";
            cmbAfdeling.SelectedIndex = -1;
            txtAantal.Clear();
            cmbStukOfKg.SelectedIndex = -1;
            txtPrijsStukOfKg.Clear();
            lblTotalePrijs.Content = 0;
            VulLijstAan();
        }

        void ToonDetails ()
        {
            txtProduct.Text = geselecteerdProduct.ProductNaam;
            cmbAfdeling.SelectedItem = geselecteerdProduct.Afdeling;
            txtAantal.Text = geselecteerdProduct.Aantal.ToString();
            cmbStukOfKg.SelectedItem = geselecteerdProduct.StukOfGewicht;
            txtPrijsStukOfKg.Text = geselecteerdProduct.Prijs.ToString();
            lblTotalePrijs.Content = geselecteerdProduct.Totaal.ToString();
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            KenmerkenProduct kenmerken = InputGevenGui();
            beherenBoodschappenServices.SlaOp(geselecteerdProduct, kenmerken);
            MaakVeldenLeeg();
            
        }

        private void BtnNieuw_Click(object sender, RoutedEventArgs e)
        {
            MaakVeldenLeeg();
            txtProduct.Focus();
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            productBeheer.Verwijder(geselecteerdProduct);
            MaakVeldenLeeg();
        }

        private void LstBoodschappenLijst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstBoodschappenLijst.SelectedIndex >= 0)
            {
                geselecteerdProduct = (KenmerkenProduct)lstBoodschappenLijst.SelectedItem;
                ToonDetails();
            }
            else
            {
                geselecteerdProduct = null;
            }
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int aantal;
            int prijsPerStuk;
            int prijsTotaal;

            aantal = int.Parse(txtAantal.Text.ToString());
            prijsPerStuk = int.Parse(txtPrijsStukOfKg.Text);
            prijsTotaal = int.Parse(lblTotalePrijs.Content.ToString()); // wilt niet in de label komen

            prijsTotaal = aantal * prijsPerStuk;
        }
        
    }
}
