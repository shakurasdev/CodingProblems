using CodingProblems.Problems.Structures;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace CodingProblems.Problems
{
    public class Problem001 : Problem
    {
        /*
         * This problem was recently asked by Google.            
         * 
         * Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
         * 
         * For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
         * 
         * Bonus: Can you do this in one pass?
         */

        public override string[] GetDescription()
        {
            return new string[] 
            {
                "This problem was recently asked by Google.",
                "Given a list of numbers and a number k, return whether any two numbers from the list add up to k.",
                "For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.",
                "Bonus: Can you do this in one pass?"
            };
        }

        public override void ShowSolution()
        {
            Form f = GetBasicForm();

            RichTextBox textBox = new RichTextBox();
            f.Controls.Add(textBox);
            textBox.Size = textBox.Parent.DisplayRectangle.Size;
            textBox.Enabled = false;


            string title = "Test Run 1:" + "\n";
            string parameters = "list: [10, 15, 3, 7]" + "\n";
            parameters += "k: 17" + "\n";
            string result = "result: " + AnyTwoNumbersAddUp(new List<int>() { 10, 15, 3, 7 }, 17).ToString() + "\n";

            textBox.AppendText(title);
            textBox.AppendText(parameters);
            textBox.AppendText(result);

            textBox.AppendText("###########" + "\n");

            title = "Test Run 2:" + "\n";
            parameters = "list: [12, 25, 13, 7]" + "\n";
            parameters += "k: 18" + "\n";
            result = "result: " + AnyTwoNumbersAddUp(new List<int>() { 12, 25, 13, 7 }, 18).ToString() + "\n";

            textBox.AppendText(title);
            textBox.AppendText(parameters);
            textBox.AppendText(result);


            f.ShowDialog();
        }


        private bool AnyTwoNumbersAddUp(List<int> list, int k)
        {
            /*
             * remember the difference between each number and k (that has already been seen)
             * after the first saved number we can directly check if the number at the current index would add up to k with a saved number
             * 
             * should be O(N) since lookups of sets are O(1) each
             * definitely less than O(N^2) 
             */

            if (list.Count < 2) return false;

            HashSet<int> seenNumbers = new HashSet<int>();
            foreach (int number in list)
            {
                if (seenNumbers.Contains(k - number)) return true;

                seenNumbers.Add(number);
            }


            return false;
        }


    }
}
