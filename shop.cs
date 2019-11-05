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
        private List<Item> shoppingCartList = new List<Item>();  //dan apita karanna one shopping list eke tina items tikak shopping cart ekata daganna eka
        BindingSource itemBinding = new BindingSource();
        BindingSource shoppingBinding = new BindingSource(); // meka hadanne item list eke tina item cart ekata dagena ewa display karanna 
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

            //elagata karanne bind karana eka data.
            BindingSource db = new BindingSource();
            db.DataSource = store.Items;
            ItemList.DataSource = db;   //mehana itemlist kiyanne shop.cs eke design eke text box eke name

            ItemList.DisplayMember = "Display";
            ItemList.ValueMember = "Display";

            shoppingBinding.DataSource = shoppingCartList;
            shoppingListBox.DataSource = shoppingBinding;

            shoppingListBox.DisplayMember = "Display"; ///dan methana displaya wenna nam button ekata function ekak gahanna one click karama shopping list ekata watenna
            shoppingListBox.ValueMember = "Display";


        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SetupData()    
        {
            // me method eka use karala dummy data tikak hadaganna eka thamai karanna hadanne

            // me vidihata thamai java wala wada karanne  ewagema c# walata awenika vidihakuth thiyenawa

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
            //mekedi parameter dena widiha thamai liyala thiyenne.

            //list eka initiate karanna one.eka karala tinne
            store.Vendors.Add(new vendor { firstName = "pamal", lastName = "sahan" });
            store.Vendors.Add(new vendor { firstName = "nuwan", lastName = "danushka" });
            store.Vendors.Add(new vendor { firstName = "asiri", lastName = "senith" });
            // commission is .5 common to all objects so we can make a constructor for vendor  

            store.Items.Add(new Item
            {
                title = "linera algebra",
                description = "this is about liner algebra",
                price = 150.23M,
                owner = store.Vendors[0]
            });
            // we should write M when we using the decimal 
            store.Items.Add(new Item
            {
                title = "trignometry",
                description = "this is is about trignometry ",
                price = 150.23M, //methana M eka danne double kiyala compiler ekata pennanna naththam decimal kiyala thamai ganan ganne
                                 //mekedi mehema danne parameter nisa
                owner = store.Vendors[1],

            });

            store.Items.Add(new Item
            {
                title = "Harry Potter",
                description = "this is about misterious book",
                price = 150.23M,
                owner = store.Vendors[0]
            });

        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            //me function eka methanin delete karoth shop.cs[Design] kiyana eka error ekak pennanawa.eka nisa delete karana kota properties gihin delete karanna
            //mekedi karanna one highlight wela tina eka ganna one
                Item selectedItem = (Item)ItemList.SelectedItem; // mehanin api pass karanawa item object ekak widihata 
         //   MessageBox.Show(selectedItem.title+"\n$"+selectedItem.price ,"you are selected :");

            shoppingCartList.Add(selectedItem);// meka unama shoppincart list ekata add wenawa but arake pennanne na ekan henda binding eka reset karanna one.
            shoppingBinding.ResetBindings(true); //true wenne schema eka change unoth false nam value change unama witharai    
            //ekiyanne entire list ekama change wenawa nam eg item to vendor wage methanadi nam true false dekama wada 

            // click karama cart ekata watenna one
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Item deleteItem = (Item)shoppingListBox.SelectedItem;
            shoppingCartList.Remove(deleteItem);
            shoppingBinding.ResetBindings(true); //value eka vitharai change wenne
        }
    }
}
