using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator refrigerator;

        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        
        private void SaveButton(object sender, EventArgs e)
        {
            refrigerator = new Refrigerator(Convert.ToDouble(maxWeightTakeTextBox.Text));
            maxWeightTakeTextBox.Clear();

        }

        private void EnterButton(object sender, EventArgs e)
        {
           
            refrigerator.NoItem = Convert.ToInt32(itemTextBox.Text);
            refrigerator.UnitWeight = Convert.ToDouble(weightTextBox.Text);

            
            refrigerator.Add(refrigerator.NoItem, refrigerator.UnitWeight);

            currentWeightTextBox.Text = Convert.ToString(refrigerator.GetCurrentWeight());

            remainingWeightTextBox.Text = Convert.ToString(refrigerator.GetRemainingWeight());

            itemTextBox.Clear();
            weightTextBox.Clear();
        }
        
    }
}
