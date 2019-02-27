/*Jesse Stanley
 * 2/26/2019
 * Components for McTavish's computer
 */
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

namespace _184784_ComputerParts
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

        private void btnCpu_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "Intel I7 - 9700k for 418.99 \n https://www.amazon.com/Intel-i7-9700K-Desktop-Processor-Unlocked/dp/B07HHN6KBZ/ref=dp_ob_title";

        }

        private void MotherBoardBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "MSI H110M gaming intel Skylake USB 3.1 Micro ATX Motherboard 98.09 \n https://www.amazon.ca/H110M-GAMING-Intel-Skylake-Motherboard/dp/B01B4U47E4/ref=sr_1_3?keywords=z170+motherboard&qid=1551281415&s=gateway&sr=8-3&tag=144hmoni0d-20 ";
        }

        private void CaseBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "Corsair Carbide Series 100R Mid Tower Case CC-9011075-WW for 64.99 \n https://www.amazon.ca/Corsair-Carbide-100R-Tower-CC-9011075-WW/dp/B00RORBQNW/ref=lp_1233053011_1_10?s=pc&ie=UTF8&qid=1551281776&sr=1-10";
        }

        private void MemoryBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "Crucial 32GB Kit (16GBx2) DDR4-2133 MT/S (PC4-2133) CL15 dual ranked x4based ECC Registered Server Memory CT2K16G4RFD4213 for 368.94 \n https://www.amazon.com/Crucial-DDR4-2133-PC4-2133-Registered-CT2K16G4RFD4213/dp/B00KUSMULY";
        }

        private void PowerSupplyBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "EVGA 750 N1, 750W, 2 Year Warranty, Power Supply 100-N1-0750-L1 prices vary depending on the amount of wats you want but the 750w is 79.92 \n https://www.amazon.ca/gp/product/B01LZ3WDQG/ref=s9_acsd_top_hd_bw_b1LeDmt_c_x_w?pf_rd_m=A3DWYIK6Y9EEQB&pf_rd_s=merchandised-search-3&pf_rd_r=F1J5YX0NENWCFQXRTH6D&pf_rd_t=101&pf_rd_p=309dd57e-73fa-574c-b8fa-0577dacbce9e&pf_rd_i=1236022011";
        }

        private void OpticalDriveBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "ASUS Black 12X BD-ROM 16X DVD-ROM 48X CD-ROM SATA Internal Blu-ray Drive Model BC-12B1ST for 79.75 \n https://www.newegg.ca/Product/Product.aspx?Item=9SIA7RD2WW2430";
        }

        private void GraphicsCard_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "MSI Radeon RX 570 DirectX 12 RX 570 ARMOR 8G OC 8GB 256-Bit GDDR5 PCI Express x16 HDCP Ready CrossFireX Support ATX Video Card for 199.99 \n https://www.newegg.ca/Product/Product.aspx?Item=N82E16814137256";
        }

        private void GraphicsCardBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "MSI Radeon RX 570 DirectX 12 RX 570 ARMOR 8G OC 8GB 256-Bit GDDR5 PCI Express x16 HDCP Ready CrossFireX Support ATX Video Card for 199.99 \n https://www.newegg.ca/Product/Product.aspx?Item=N82E16814137256";
        }

        private void StorageBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "Samsung 970 EVO 1TB - NVMe PCIe M.2 2280 SSD (MZ-V7E1T0BW) for 247.99 \n https://www.amazon.com/Samsung-970-EVO-1TB-MZ-V7E1T0BW/dp/B07BN217QG/ref=zg_bs_1292116011_18?_encoding=UTF8&refRID=EHYJH62JQSPACG0YTNSG&th=1";
        }

        private void RationaleBtn_Click(object sender, RoutedEventArgs e)
        {
            txtcompontent.Text = "I picked each of the computer parts to be able to fit into the case and to be up to spec with what you wanted to be able to run on the computer. I believe that what I chose complements the Computer and you have some wiggle room with the prices to get more storage and or a better graphics card.";
        }
    }
}
