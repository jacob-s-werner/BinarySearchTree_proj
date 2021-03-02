using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProj
{
    public class Node
    {
        public int data;
        public Node lesserNode;
        public Node greaterNode;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
