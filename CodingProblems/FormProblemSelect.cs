using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingProblems.Problems;
using CodingProblems.Problems.Structures;

namespace CodingProblems
{
    public partial class FormProblemSelect : Form
    {
        private Problem ActiveProblem;

        public FormProblemSelect()
        {
            InitializeComponent();

            foreach (string name in Enum.GetNames(typeof(EProblems)))
            {
                listBoxProblems.Items.Add(name);
            }
        }

        private void listBoxProblems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveProblem = GetProblem((EProblems)listBoxProblems.SelectedIndex);

            if(ActiveProblem is object)
            {
                textBoxDescription.ResetText();
                foreach (string s in ActiveProblem.GetDescription())
                {
                    textBoxDescription.AppendText(s + "\n\n");
                }
            }
        }

        private void buttonLaunchProblem_Click(object sender, EventArgs e)
        {
            if(ActiveProblem is object)
            {
                ActiveProblem.ShowSolution();
            }
        }

        private Problem GetProblem(EProblems index)
        {
            switch(index)
            {
                case EProblems.Problem001: return new Problem001();
                case EProblems.Problem002: return null;
                default: return null;
            }
        }
    }
}
