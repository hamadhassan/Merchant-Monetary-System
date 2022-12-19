using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython;

namespace Merchant_Monetary_System
{
    public partial class frmReports : Form
    { 
        public frmReports()
        {
            InitializeComponent();
        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //instance of python engine
            var engine = Python.CreateEngine();
            //reading code from file
            var source = engine.CreateScriptSourceFromFile("D:\\COMPUTER SCIENCE\\3rd Semester\\Data Structures and Algorithms-DSA\\cs261f22finalpid11\\Application\\PythonScript.py");
            var scope = engine.CreateScope();
            //executing script in scope
            source.Execute(scope);
            var classCalculator = scope.GetVariable("calculator");
            //initializing class
            var calculatorInstance = engine.Operations.CreateInstance(classCalculator);
            var result = calculatorInstance.add(5, 10);
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////instance of python engine
            //var engine = Python.CreateEngine();
            ////reading code from file
            //var source = engine.CreateScriptSourceFromFile("D:\\COMPUTER SCIENCE\\3rd Semester\\Data Structures and Algorithms-DSA\\cs261f22finalpid11\\Application\\Part1.py");
            //var scope = engine.CreateScope();
            ////executing script in scope
            //source.Execute(scope);
            //var classCalculator = scope.GetVariable("plot");
            ////initializing class
            //var calculatorInstance = engine.Operations.CreateInstance(classCalculator);
            //calculatorInstance.show();
            ////label1.Text = result.ToString();
            ///





        }
    }
}
