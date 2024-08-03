using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Devoir2
{
    public partial class formTree : Form
    {
        private BinarySearchTree tree;

        public formTree()
        {
            InitializeComponent();
            tree = new BinarySearchTree();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string[] numbers = input.Split(',');

            if (numbers.Length != 7)
            {
                lblError.Text = "Please enter 7 comma-separated integers.";
                return;
            }

            tree.Clear();
            foreach (string num in numbers)
            {
                if (int.TryParse(num, out int value))
                {
                    tree.Insert(value);
                }
                else
                {
                    lblError.Text = "Invalid input. Please enter integers only.";
                    return;
                }
            }
            lblError.Text = "";

            DrawTree();
        }

        private void DrawTree()
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            if (tree.Root != null)
            {
                DrawNode(g, tree.Root, pictureBox.Width / 2, 50, pictureBox.Width / 4);
            }

            pictureBox.Image = bitmap;
        }

        private void DrawNode(Graphics g, TreeNode node, int x, int y, int offsetX)
        {
            Font font = new Font(FontFamily.GenericSansSerif, 10);
            Brush brush = Brushes.Black;

            g.FillEllipse(Brushes.White, x - 20, y - 20, 40, 40);
            g.DrawEllipse(Pens.Black, x - 20, y - 20, 40, 40);
            g.DrawString(node.Value.ToString(), font, brush, x - 10, y - 10);

            if (node.Left != null)
            {
                int newX = x - offsetX;
                int newY = y + 60;
                g.DrawLine(Pens.Black, x, y, newX, newY);
                DrawNode(g, node.Left, newX, newY, offsetX / 2);
            }

            if (node.Right != null)
            {
                int newX = x + offsetX;
                int newY = y + 60;
                g.DrawLine(Pens.Black, x, y, newX, newY);
                DrawNode(g, node.Right, newX, newY, offsetX / 2);
            }

        }



    }

}
