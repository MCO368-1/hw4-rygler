using System;
using System.Windows.Forms;
using WindowsFormsTempConverter.Properties;

namespace WindowsFormsTempConverter
{
    public partial class Form1 : Form
    {
        private double _number;
        
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsProperInput => IsTempToProperInput && IsTempFromProperInput;
        private bool IsTempFromProperInput { get; set; }
        private bool IsTempToProperInput { get; set; }

        private Temperatures TempFrom { get; set; }
        private Temperatures TempTo { get; set; }

        private void tempFromBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tempFromBox.SelectedIndex == -1)
            {
                IsTempFromProperInput = false;
                DisableConvertButton();
                return;
            }

            IsTempFromProperInput = true;
            EnableConvertButton();
            TempFrom = (Temperatures) tempFromBox.SelectedIndex;
        }


        private void temptToBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (temptToBox.SelectedIndex == -1)
            {
                IsTempToProperInput = false;
                DisableConvertButton();
                return;
            }

            IsTempToProperInput = true;
            TempTo = (Temperatures) temptToBox.SelectedIndex;
            Console.WriteLine(TempTo);
        }

        private void EnableConvertButton()
        {
            if (IsProperInput)
                convertButton.Enabled = true;
        }

        private void DisableConvertButton()
        {
            convertButton.Enabled = false;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                _number = double.Parse(numberTextBox.Text);
                if (IsProperInput)
                    resultLabel.Text = $"{Utilities.ConvertTemperature(TempFrom, TempTo, _number)}";
                else
                    resultLabel.Text = "Please select two temperatures";
            }
            catch (Exception)
            {
                resultLabel.Text = Resources.Form1_numberTextBox_TextChanged_Not_Proper_Input__Please_enter_a_number;
            }
        }
    }
}