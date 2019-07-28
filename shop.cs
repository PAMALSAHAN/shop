using shopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class shop : Form
    {
        private store store = new store(); 
        /// <summary>
        /// this will give error mesage we want to arrange that 
        /// shop library function have to use for this
        /// </summary>
        public shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        
        private void SetupData()
        {
            vendor DemoVendor = new vendor();
            DemoVendor.firstName = "Pamal";
            DemoVendor.lastName = "Jayawickrama";
            DemoVendor.commission = 0.5;

            store.Vendors.Add(DemoVendor);

            DemoVendor = new vendor();
            DemoVendor.firstName = "Chamath";
            DemoVendor.lastName = "Jayawickrama";
            DemoVendor.commission = 0.5;

            store.Vendors.Add(DemoVendor);  //we have a Vendors list in store 
           




        }


    }
}
