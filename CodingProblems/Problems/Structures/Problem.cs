using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingProblems.Problems.Structures
{
    public abstract class Problem
    {
        public abstract void ShowSolution();
        public abstract string[] GetDescription();

        protected Form GetBasicForm()
        {
            Form f = new Form();
            f.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 14);
            f.StartPosition = FormStartPosition.CenterParent;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.Size = new System.Drawing.Size(500, 281);

            return f;
        }
    }
}
