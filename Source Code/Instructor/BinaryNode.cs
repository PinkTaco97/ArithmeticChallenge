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
    /// <summary>
    /// The Binary node class.
    /// </summary>
    class BinaryNode
    {
        //The Question the node holds.
        public Question question;

        //The left node.
        public BinaryNode left = null;

        //The right node.
        public BinaryNode right = null;

        //The binary tree the node belongs to.
        public BinaryTree binaryTree = null;

        //The index in the sorted list.
        public int index;

        /// <summary>
        /// The Constructor.
        /// </summary>
        /// <param name="binaryTree"></param>
        /// <param name="question"></param>
        public BinaryNode(BinaryTree binaryTree, Question question)
        {
            //Set the nodes values.
            this.binaryTree = binaryTree;
            this.question = question;
        }

        /// <summary>
        /// Try to add a node to the current node.
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(BinaryNode node)
        {
            //If the new node's question's answer is less than the current nodes questions answer.
            if(node.question.answer < this.question.answer)
            {
                //If the current node dosnt have a left node.
                if (this.left == null)
                {
                    //Set the child to the new node.
                    this.left = node;
                }
                else
                {
                    //Try to add the new node to the child.
                    this.left.AddNode(node);
                }
            }
            //If the new node's question's answer is more than the current nodes questions answer.
            else if (node.question.answer > this.question.answer)
            {
                //If the current node dosnt have a right node.
                if (this.right == null)
                {
                    //Set the child to the new node.
                    this.right = node;
                }
                else
                {
                    //Try to add the new node to the child.
                    this.right.AddNode(node);
                }
            }
        }

        /// <summary>
        /// Traverse throughout the Tree.
        /// </summary>
        public void Traverse()
        {
            //If the current node has a left child.
            if (this.left != null)
            {
                //Traverse the left node.
                this.left.Traverse();
            }

            //Add the current node to the sorted list.
            binaryTree.sorted.Add(this);

            //If the current node has a right child.
            if (this.right != null)
            {
                //Traverse the right node.
                this.right.Traverse();
            }

            //Reached the end of the tree.
            binaryTree.SetIndex();
        }

        /// <summary>
        /// Searches the current node.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public BinaryNode Search(Question question)
        {
            //If the current node's value == the value we are searching for.
            if (this.question.answer == question.answer)
            {
                //Return the current node.
                return this;
            }
            //If the value is less than the current node's value.
            else if (question.answer < this.question.answer && this.left != null)
            {
                //Search the current node's left child.
                return this.left.Search(question);
            }
            //If the value is more than the current node's value.
            else if (question.answer > this.question.answer && this.right != null)
            {
                //Search the current node's right child.
                return this.right.Search(question);
            }
            return null;
        }

        //Displays the nodes in the TreeView
        public void Display(TreeNode parent)
        {
            //If this node has a left child.
            if (this.left != null)
            {
                //Create a new tree view node.
                TreeNode left = new TreeNode();

                //Make a reference to the roots question.
                Question question = this.left.question;

                //Set the new tree view nodes text.
                left.Text = "(Left) " + question.a + " " + question.operatorSymbol + " " + question.b + " = " + question.x;

                //Add the new tree view node to its parent.
                parent.Nodes.Add(left);

                //Display the Left Child's children on the TreeView
                this.left.Display(left);

                //If this node has a right child.
                if (this.right != null)
                {
                    //Create a new tree view node.
                    TreeNode right = new TreeNode();

                    //Make a reference to the roots question.
                    Question questionn = this.right.question;

                    //Set the new tree view nodes text.
                    right.Text = "(Right) " + questionn.a + " " + questionn.operatorSymbol + " " + questionn.b + " = " + questionn.x;

                    //Add the new tree view node to its parent.
                    parent.Nodes.Add(right);

                    //Display the Right Child's children on the TreeView
                    this.right.Display(right);
                }
            }
            else if (this.right != null)
            {
                //Create a new tree view node.
                TreeNode right = new TreeNode();

                //Make a reference to the roots question.
                Question question = this.right.question;

                //Set the new tree view nodes text.
                right.Text = "(Right) " + question.a + " " + question.operatorSymbol + " " + question.b + " = " + question.x;

                //Add the new tree view node to its parent.
                parent.Nodes.Add(right);

                //Display the Right Child's children on the TreeView
                this.right.Display(right);
            }
        }
    }
}
