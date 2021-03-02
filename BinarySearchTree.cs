using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProj
{
    public class BinarySearchTree
    {
        public Node rootNode, lesserNode, greaterNode;
        public BinarySearchTree()
        {

        }
        public void Add(Node nodeToAdd)
        {
            if (rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = rootNode;
                while (true)
                {
                    if (nodeToAdd.data < currentNode.data)
                    {
                        if (currentNode.lesserNode == null)
                        {
                            currentNode.lesserNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.lesserNode;
                        }
                    }
                    else
                    {
                        if (currentNode.greaterNode == null)
                        {
                            currentNode.greaterNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.greaterNode;
                        }
                    }
                }
            }
        }
        public Node Search(Node nodeToFind)
        {
            
        }
    }
}
