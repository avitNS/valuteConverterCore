using System;
using System.Windows;
using System.Xml;
using System.Text;

namespace converterCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        

        private void btConvert_Click(object sender, RoutedEventArgs e)
        {
            if(decimal.TryParse(tbIn.Text, out decimal result))
            {
                if(cmbValute.SelectedItem != null)
                {
                    if (cmbValute.SelectedItem != null)
                    {
                        //tbOut.Text = ((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText;
                        //tbOut.Text = ((XmlElement)cmbValute.SelectedItem).GetAttribute("ID");
                        switch (((XmlElement)cmbValute.SelectedItem).GetAttribute("ID"))
                        {
                            case "R01235":
                                decimal resUSD = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text =  resUSD.ToString();
                                break;
                            case "R01010":
                                decimal AUD = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = AUD.ToString();
                                break;
                            case "R01020A":
                                decimal AZN = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = AZN.ToString();
                                break;
                            case "R01035":
                                decimal GBP = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = GBP.ToString();
                                break;
                            case "R01060":
                                decimal AMD = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01090B":
                                decimal BYN = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = BYN.ToString();
                                break;
                            case "R01100":
                                decimal BGN = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = BGN.ToString();
                                break;
                            case "R01115":
                                decimal BRL = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = BRL.ToString();
                                break;
                            case "R01135":
                                decimal HUF = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01200":
                                decimal HKD = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01215":
                                decimal DKK = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = DKK.ToString();
                                break;
                            case "R01239":
                                decimal EUR = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = EUR.ToString();
                                break;
                            case "R01270":
                                decimal INR = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01335":
                                decimal KZT = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = KZT.ToString();
                                break;
                            case "R01350":
                                decimal CAD = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = CAD.ToString();
                                break;
                            case "R01370":
                                decimal KGS = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01375":
                                decimal CNY = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01500":
                                decimal MDL = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01535":
                                decimal NOK = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01565":
                                decimal PLN = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = PLN.ToString();
                                break;
                            case "R01585F":
                                decimal RON = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = RON.ToString();
                                break;
                            case "R01589":
                                decimal XDR = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = XDR.ToString();
                                break;
                            case "R01625":
                                decimal SGD = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = SGD.ToString();
                                break;
                            case "R01670":
                                decimal TJS = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01700J":
                                decimal TRY = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = TRY.ToString();
                                break;
                            case "R01710A":
                                decimal TMT = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = TMT.ToString();
                                break;
                            case "R01717":
                                decimal UZS = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01720":
                                decimal UAH = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01760":
                                decimal CZK = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = CZK.ToString();
                                break;
                            case "R01770":
                                decimal SEK = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01775":
                                decimal CHF = result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText);
                                tbOut.Text = CHF.ToString();
                                break;
                            case "R01810":
                                decimal ZAR = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01815":
                                decimal KRW = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText)) *
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                break;
                            case "R01820":
                                decimal JPY = (result / Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(4).InnerText))*
                                    Convert.ToDecimal(((XmlElement)cmbValute.SelectedItem).ChildNodes.Item(2).InnerText);
                                tbOut.Text = JPY.ToString();
                                break;


                        }
                    }
                }
            }
        }
    }
}
