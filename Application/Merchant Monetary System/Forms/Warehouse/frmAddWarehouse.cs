﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Merchant_Monetary_System
{
    public partial class frmAddWarehouse : Form
    {
        Warehouse previouObj;
        public frmAddWarehouse()
        {
            InitializeComponent();
        }
        public frmAddWarehouse(Warehouse previouObj)
        {
            InitializeComponent();
            this.previouObj = previouObj;
        }
        bool isName=true;
        bool isCapacity=true;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isName == false && isCapacity == false)
            {
                string name=txtbxName.Text;
                float totalSpace=float.Parse(txtbxCapacityInVolume.Text);
                string area=cmbxArea.Text;
                string city=cmbxCity.Text;
                string state=cmbxState.Text;
                Location location=new Location(area, city, state);
                Warehouse warehouse = new Warehouse(name, totalSpace, location);
                if (previouObj != null)
                {//update the record
                    if (WarehouseDL.updateRecord(warehouse))
                    {
                        WarehouseDL.storeAllRecordIntoFile(FilePath.Warehouse);

                        lblRecordSignal.Text = "Account successfully updated";

                    }
                    else
                    {
                        lblRecordSignal.Text = "There is an error while updating the data";
                    }

                }
                else
                {
                    WarehouseDL.WarehousesList.Add(warehouse);
                    WarehouseDL.storeRecordIntoFile(warehouse, FilePath.Warehouse);
                    frmSignUp frmSignUp = new frmSignUp(true);
                    frmSignUp.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("All field must be filled correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearAll()
        {
            txtbxCapacityInVolume.Clear();
            txtbxName.Clear();
            cmbxArea.SelectedIndex = 0;
            cmbxCity.SelectedItem = 0;
            cmbxState.SelectedIndex = 0;
        }
        public bool isValidString(string input)
        {
            bool isValid = true;
            isValid = Regex.IsMatch(input, @"^[a-zA-Z]+$");
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                    isValid = false;
            }
            return isValid;
        }
        private void txtbxName_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxName.Text == string.Empty)
            {// check is empty
                lblNameSignal.Text = "Enter the name";
                isName = true;
            }
            else if (isValidString(txtbxName.Text)==false)
            {//Check isnumberic
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else if (txtbxName.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblNameSignal.Text = "Allowed characters: a-z, A-Z";
                isName = true;
            }
            else
            {//ready for storage or action
                lblNameSignal.Text = " ";
                isName = false;
            }
        }

        private void txtbxCapacityInVolume_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (txtbxCapacityInVolume.Text == string.Empty)
            {// check is empty
                lblCapacityInVolumeSignal.Text = "Enter the capacity of warehouse";
                isCapacity = true;
            }
            else if (!int.TryParse(txtbxCapacityInVolume.Text, out i))
            {//Check isalphabetic
                lblCapacityInVolumeSignal.Text = "Allowed characters: 0-9";
                isCapacity = true;
            }
            else if (txtbxCapacityInVolume.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {//check isSpecialCharactor
                lblCapacityInVolumeSignal.Text = "Allowed characters: 0-9";
                isCapacity = true;
            }
            else
            {//ready for storage
                lblCapacityInVolumeSignal.Text = " ";
                isCapacity = false;
            }
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            if (previouObj != null)
            {
                txtbxName.Text = previouObj.Name;
                txtbxCapacityInVolume.Text =previouObj.TotalSpace.ToString();
                cmbxArea.Text = previouObj.Location.Area;
                cmbxCity.Text = previouObj.Location.City;
                cmbxState.Text = previouObj.Location.State;


                lblAddWarehouse.Text = "Update Warehouse Record";
                lblAddWarehouse.Left -= 130;
                btnNext.Text = "Update";
            }
            cmbxArea.SelectedIndex = 0;
            cmbxCity.SelectedIndex = 0;
            cmbxState.SelectedIndex = 0;

        }

        private void gbx_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAddWarehouse_Click(object sender, EventArgs e)
        {
        }
    }
}
