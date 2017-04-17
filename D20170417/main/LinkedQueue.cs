using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20170417.main
{
    /// <summary>
    /// The queue data type, has a head and a tail named front and rear
    /// </summary>
    internal class LinkedQueue
    {
        private Node front;
        private Node rear;

        /// <summary>
        /// init with no parameters
        /// </summary>
        internal LinkedQueue()
        {
            this.front = new Node("");
            this.rear = this.front;
        }

        /// <summary>
        /// List all the nodes in the queue object
        /// </summary>
        /// <returns>a list contains all nodes</returns>
        public List<Node> ListAll()
        {
            if (this.front == this.rear)
            {
                return null;
            }

            List<Node> result = new List<Node>();
            Node current = this.front.Next;
            while (current != this.rear)
            {
                result.Add(current);
                current = current.Next;
            }

            return result;
        }

        /// <summary>
        /// insert a node into a queue
        /// </summary>
        /// <param name="node">the node to be inserted</param>
        public void InQueue(Node node)
        {
            if(this.front == this.rear)
            {
                this.front.Next = node;
                this.rear = new Node("");
                node.Next = this.rear;
            }
            else
            {
                Node beforeRear = this.front.Next;
                while(beforeRear.Next != this.rear)
                {
                    beforeRear = beforeRear.Next;
                }
                node.Next = this.rear;
                beforeRear.Next = node;
            }
        }

        /// <summary>
        /// get the first node in the queue and remove it
        /// </summary>
        /// <returns>the first node</returns>
        public Node OutQueue()
        {
            if(this.front == this.rear)
            {
                return null;
            }
            else
            {
                Node result = this.front.Next;
                this.front.Next = result.Next;

                return result;
            }
        }

        /// <summary>
        /// count the number of members in the queue
        /// </summary>
        /// <returns>the number of members</returns>
        public int Count()
        {
            if (this.front == this.rear)
            {
                return 0;
            }

            int count = 0;
            Node current = this.front.Next;
            while (current != this.rear)
            {
                count++;
                current = current.Next;
            }

            return count;
        }


    }
}
