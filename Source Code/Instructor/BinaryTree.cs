using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instructor
{
    class BinaryTree
    {

        /// <summary>
        /// Reference to the main form
        /// </summary>
        Main main;

        /// <summary>
        /// The root of the tree.
        /// </summary>
        public BinaryNode root = null;

        /// <summary>
        /// List of sorted values that the tree holds.
        /// </summary>
        public List<BinaryNode> sorted = new List<BinaryNode>();

        /// <summary>
        /// Constructor
        /// </summary>
        public BinaryTree(Main main)
        {
            //Set the root to null.
            this.root = null;
            this.main = main;
        }

        /// <summary>
        /// Add a question to the tree.
        /// </summary>
        /// <param name="question"></param>
        public void AddQuestion(Question question)
        {
            //Create a new node.
            BinaryNode node = new BinaryNode(this, question);

            //If there isnt a root node.
            if (this.root == null)
            {
                //Set the new node as the root node.
                this.root = node;
            }
            else
            {
                //Try to add the new node to the root.
                this.root.AddNode(node);
            }
        }

        /// <summary>
        /// Traverse through the tree.
        /// </summary>
        public void Traverse()
        {
            //Clear the list.
            sorted.Clear();

            //If there is a root node in the tree.
            if (this.root != null)
            {
                //Traverse the root.
                root.Traverse();
            }
        }

        /// <summary>
        /// Sets the index's of the nodes.
        /// </summary>
        public void SetIndex()
        {
            //For each node.
            for (int i = 0; i < sorted.Count; i++)
            {
                //Set the nodes index.
                sorted[i].index = i;
            }
        }

        /// <summary>
        /// Search through the tree.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public BinaryNode Search(Question question)
        {
            //Start the search at the root.
            BinaryNode found = root.Search(question);

            //Return what we found.
            return found;
        }

        /// <summary>
        /// Print the sorted list to the console.
        /// </summary>
        public void Print()
        {
            //Go through each node in the sorted array.
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write(sorted[i].question.answer + ",");
            }
        }

        public void Display()
        {
            //If the Binary Tree has a root node.
            if (this.root != null)
            {
                //Clear the Binary Tree View.
                main.BinaryTreeView.Nodes.Clear();

                //Create a new tree view node.
                TreeNode root = new TreeNode();

                //Make a reference to the roots question.
                Question question = this.root.question;

                //Set the new tree view nodes text.
                root.Text = question.a + " " + question.operatorSymbol + " " + question.b + " = " + question.answer;

                //Add the new tree view node to the TreeView.
                main.BinaryTreeView.Nodes.Add(root);

                //Display the Roots Children in the TreeView.
                this.root.Display(root);
            }
        }
    }
}
