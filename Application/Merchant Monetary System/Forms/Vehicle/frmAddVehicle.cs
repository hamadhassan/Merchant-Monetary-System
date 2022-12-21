using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Merchant_Monetary_System.BL;
using Merchant_Monetary_System.DL;

namespace Merchant_Monetary_System.Forms.Vehicle
{
    public partial class frmAddVehicle : Form
    {
        bool isWeight = true;
        bool isVolume = true;
        bool isReg = true;
        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtVolume.Text == string.Empty)
            {// check is empty
                lblVolumeSignal.Text = "Enter the Volume";
                isVolume = true;
            }
            else if (txtVolume.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblVolumeSignal.Text = "Allowed characters: 0-9";
                isVolume = true;
            }
            else
            {//ready for storage
                lblVolumeSignal.Text = " ";
                isVolume = false;
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtWeight.Text == string.Empty)
            {// check is empty
                lblWeightSignal.Text = "Enter the Weight";
                isWeight = true;
            }
            else if (txtWeight.Text.Any(ch => !char.IsDigit(ch)))
            {//check isSpecialCharactor
                lblWeightSignal.Text = "Allowed characters: 0-9";
                isWeight = true;
            }
            else
            {//ready for storage
                lblWeightSignal.Text = " ";
                isWeight = false;
            }
        }

        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtRegistrationNo.Text == string.Empty)
            {// check is empty
                lblRegNOSignal.Text = "Enter the Registration No.";
                isReg = true;
            }
            else if (txtRegistrationNo.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblRegNOSignal.Text = "Allowed characters: a-z, A-Z, 0-9";
                isReg = true;
            }
            else if (txtRegistrationNo.Text.Length <= 2)
            {//length greater than 3
                lblRegNOSignal.Text = "Reg No. must 3 characters long";
                isReg = true;
            }
            else if(VehicleDL.AlreadyExist(txtRegistrationNo.Text))
            {
                lblRegNOSignal.Text = "Reg No. Already Exist";
                isReg = true;
            }
            else
            {//ready for storage or action
                lblRegNOSignal.Text = " ";
                isReg = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVolume.Clear();
            txtWeight.Clear();
            txtRegistrationNo.Clear();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if(!isWeight && !isVolume && !isReg && cmbxType.Text != "")
            {
                string type = cmbxType.Text;
                double volume = Double.Parse(txtVolume.Text);
                double weight = Double.Parse(txtWeight.Text);
                string registrationNo = txtRegistrationNo.Text;
                BL.Vehicle vehicle = new BL.Vehicle(type, volume, weight, registrationNo);
                VehicleDL.addIntoList(vehicle);
                VehicleDL.StoreVehicleDataIntoFiles(FilePath.Vehcile);
                MessageBox.Show("Vehicle Added Successfully", "Adding Vehicle...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill All the fields correctly", "Adding Vehicle...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {
            cmbxType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
