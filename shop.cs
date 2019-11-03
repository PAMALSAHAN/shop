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
        BindingSource itemBinding = new BindingSource();
        /// <summary>
        /// this will give error mesage we want to arr
       
        /// ange that 
        /// shop library function have to use for this
        /// </summary>
        public shop()
        {
            InitializeComponent();
            // this is the constructor of the shop all the thing should code bellow this
            SetupData();
            //filling data using this setupData();

        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        
        private void SetupData()
        {
            //vendor DemoVendor = new vendor();
            //DemoVendor.firstName = "Pamal";
            //DemoVendor.lastName = "Jayawickrama";
            //DemoVendor.commission = 0.5;

            //store.Vendors.Add(DemoVendor);

            //DemoVendor = new vendor();
            //DemoVendor.firstName = "Chamath";
            //DemoVendor.lastName = "Jayawickrama";
            //DemoVendor.commission = 0.5;

            //store.Vendors.Add(DemoVendor);  //we have a Vendors list in store 

            //we have to initiate this vendor so we have to make a constructor
            store.Vendors.Add(new vendor { firstName="pamal",lastName="sahan"});
            store.Vendors.Add(new vendor { firstName = "nuwan", lastName = "danushka" });
            store.Vendors.Add(new vendor { firstName = "asiri", lastName = "senith" });
            // commission is .5 common to all objects so we can make a constructor for vendor  

            store.Items.Add(new Item
                        {   title = "linera algebra",
                            description = "this is about liner algebra",
                            price = 150.23M,
                            owner = store.Vendors[0]
                        });
            // we should write M when we using the decimal 
            store.Items.Add(new Item
                            {  title = "linera algebra",
                               description = "this is about liner algebra",
                               price = 150.23M,
                               owner = store.Vendors[1]
                            });

            store.Items.Add(new Item
                                {
                                    title = "Harry Potter",
                                    description = "this is about misterious book",
                                    price = 150.23M,
                                    owner = store.Vendors[0]
                                });



            store.Name = "second are better";
        }



    }
}
