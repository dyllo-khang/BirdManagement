using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Farm_Shop
{
    public partial class Main_Form : Form
    {
        public int id;
        public Main_Form(int id)
        {
            InitializeComponent();
            this.id = id;
        }
    }
}
