using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_test
{
    public class Node
    {
        public object element;
        public Node flink, blink;
        public Node()
        {
            element = null;
            flink = blink = null;
        }
        public Node(object element)
        {
            this.element = element;
            flink = blink = null;
        }
    }
    public class DoublyLinkedList
    {
        public Node header;

        public DoublyLinkedList()
        {
            header = new Node("Header");
        }

        public Node GetFirst()
        {
            return header.flink;
        }
        public Node FindPrev(object ele)
        {
            Node current = header;
            while (current.flink.element != ele)
                current = current.flink;
            return current;
        }
        public void Swap(object eleA, object eleB)
        {
            Node prevA = FindPrev(eleA);
            Node prevB = FindPrev(eleB);
            Remove(eleB);
            Insert(eleA, prevB.element);
            Insert(eleB, prevA.element);
            Remove(eleA);
        }
        private Node Find(object element)
        {
            Node current = header;
            while (current != null && current.element != element)
            {
                current = current.flink;
            }
            return current;
        }

        public void Insert(object newElement, object afterElement)
        {
            Node current = Find(afterElement);
            if (current == null) return;

            Node newNode = new Node(newElement);
            newNode.flink = current.flink;
            newNode.blink = current;
            current.flink = newNode;
            if (newNode.flink != null)
            {
                newNode.flink.blink = newNode;
            }
        }

        public void Remove(object element)
        {
            Node current = Find(element);
            if (current == null || current == header)
                return;
            if (current.flink != null)
            {
                current.flink.blink = current.blink;
            }
            if (current.blink != null)
            {
                current.blink.flink = current.flink;
            }
        }
        public void Clear()
        {
            Node current = GetFirst();
            while (current != null)
            {
                Node nextNode = current.flink; // Lưu tham chiếu tới nút tiếp theo
                current.flink = null;          // Xóa liên kết tới nút tiếp theo
                current.blink = null;          // Xóa liên kết tới nút trước đó
                current = nextNode;            // Di chuyển tới nút tiếp theo
            }
            header.flink = null;
        }
        public void Shuffle()
        {
            List<Node> nodes = new List<Node>();
            Node current = GetFirst();
            while (current != null)
            {
                nodes.Add(current);
                current = current.flink;
            }

            // Shuffle the list using Fisher-Yates algorithm
            Random random = new Random();
            for (int i = nodes.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (nodes[i], nodes[j]) = (nodes[j], nodes[i]);
            }

            // Rebuild the linked list with the shuffled nodes
            if (nodes.Count > 0)
            {
                // Update the header's `flink` to point to the first node in the shuffled list
                header.flink = nodes[0];
                nodes[0].blink = header;

                // Link shuffled nodes together
                for (int i = 0; i < nodes.Count - 1; i++)
                {
                    nodes[i].flink = nodes[i + 1];
                    nodes[i + 1].blink = nodes[i];
                }

                // Terminate the last node
                nodes[nodes.Count - 1].flink = null;
            }
        }

        public void SortAsc()
        {
            if (header == null || header.flink == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = header.flink;

                while (current.flink != null)
                {
                    if (string.Compare(current.element.ToString(), current.flink.element.ToString(), StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // Swap elements
                        Swap(current.element, current.flink.element);
                        swapped = true;
                    }
                    current = current.flink;
                }
            } while (swapped);
        }
        public void SortDesc()
        {
            if (header == null || header.flink == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = header.flink;

                while (current.flink != null)
                {
                    if (string.Compare(current.element.ToString(), current.flink.element.ToString(), StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        // Swap elements
                        Swap(current.element, current.flink.element);
                        swapped = true;
                    }
                    current = current.flink;
                }
            } while (swapped);
        }
        public Node GetAt(int index)
        {
            Node current = header.flink;
            int count = 0;
            while (current != null && count < index)
            {
                current = current.flink;
                count++;
            }
            return current;
        }

    
    }
}
