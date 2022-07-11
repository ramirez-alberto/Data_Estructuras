
namespace LinkedList
{
    internal class LinkedListExample<T>
    {
        private Node<T>? head;

        public LinkedListExample()
        {
            head = null;
        }

        public void Append(T value)
        {
            if (head == null) head = new Node<T>(value, null);
            else
            {
                var currentNode = this.Tail();
                currentNode.nextNode = new Node<T>(value, null);
            }
        }

        public void Prepend(T value)
        {
            head = new Node<T>(value, head);
        }

        public int Size()
        {
            var counter = 0;
            var currentNode = head;
            while (currentNode is not null)
            {
                currentNode = currentNode.nextNode;
                counter++;
            }
            return counter;
        }

        public Node<T> Head()
        {
            if (head == null) throw new ArgumentNullException();
            return head;

        }
        public Node<T> Tail()
        {
            if (head == null) throw new ArgumentNullException();

            var currentNode = head;
            while (currentNode.nextNode is not null)
            {
                currentNode = currentNode.nextNode;
            }
            return currentNode;

        }

        public Node<T> At(int index)
        {
            if (head == null) throw new IndexOutOfRangeException();

            var currentNode = head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.nextNode;
                if (currentNode == null) throw new IndexOutOfRangeException();
            }
            return currentNode;
        }

        public T Pop()
        {
            if (head == null) throw new ArgumentNullException();
            if (head.nextNode is null)
                head = null;
            var currentNode = At(Size() - 2);
            currentNode.nextNode = null;
            return currentNode.value;
        }

        public void Next()
        {

        }

        public class Node<T>
        {
            public Node<T>? nextNode;
            public T value;

            public Node(T value, Node<T>? nextNode)
            {
                this.nextNode = nextNode;
                this.value = value;
            }
        }
    }
}
