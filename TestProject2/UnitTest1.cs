using DoublyLinkedListWithErrors;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        // Test cases for adding nodes to the head of the doubly linked list
        [TestMethod]
        public void Test_Add_to_Head_1()
        {
            DLList dll1 = new DLList(); 
            DLLNode node = new DLLNode(10);  
            dll1.addToHead(node);
           
            Assert.AreEqual(10,dll1.head.num);
        }

        [TestMethod]
        public void Test_Add_to_Head_2()
        {
            DLList dll1 = new DLList();
            DLLNode node = new DLLNode(12);
            dll1.addToHead(node);
           
            Assert.AreEqual(12, dll1.head.num);
        }

        [TestMethod]
        public void Test_Add_to_Head_3()
        {
            DLList dll1 = new DLList();
            DLLNode node = new DLLNode(20);
            dll1.addToHead(node);
            
            Assert.AreNotEqual(12, dll1.head.num);
        }

        [TestMethod]
        public void Test_Add_to_Head_4()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(20);
            DLLNode node2 = new DLLNode(30);
            DLLNode node3 = new DLLNode(40);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);

            Assert.AreNotEqual(10, dll1.head.num);
            Assert.AreEqual(40, dll1.head.num);
        }

        // Test cases for adding nodes to the tail of the doubly linked list
        [TestMethod]
        public void Test_Add_to_Tail_1()
        {
            DLList dll1 = new DLList();
            DLLNode node = new DLLNode(20);
            dll1.addToTail(node);

            Assert.AreEqual(20, dll1.tail.num);
        }

        [TestMethod]
        public void Test_Add_to_Tail_2()
        {
            DLList dll1 = new DLList();
            DLLNode node = new DLLNode(50);
            dll1.addToTail(node);

            Assert.AreNotEqual(20, dll1.tail.num);
        }

        [TestMethod]
        public void Test_Add_to_Tail_3()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);
            
            dll1.addToTail(node1);
            dll1.addToTail(node2);
            dll1.addToTail(node3);

            Assert.AreNotEqual(10, dll1.tail.num);
            Assert.AreNotEqual(50, dll1.tail.num);
            Assert.AreEqual(70, dll1.tail.num);
        }

        // Test cases for checking head and tail with a single node added to the head
        [TestMethod]
        public void Test_Head_Tail_Check_with_1_node()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            
            dll1.addToHead(node1);

            Assert.AreEqual(50, dll1.tail.num);
            Assert.AreEqual(50, dll1.head.num);

        }

        // Test cases for checking head and tail with multiple nodes added to the head
        [TestMethod]
        public void Test_Head_Tail_Check_with_multiple_node_addToHeadMethod()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);

            Assert.AreEqual(50, dll1.tail.num);
            Assert.AreEqual(70, dll1.head.num);

        }

        // Test cases for checking head and tail with multiple nodes added to the tail
        [TestMethod]
        public void Test_Head_Tail_Check_with_multiple_node_addToTailMethod()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToTail(node1);
            dll1.addToTail(node2);
            dll1.addToTail(node3);

            Assert.AreEqual(70, dll1.tail.num);
            Assert.AreEqual(50, dll1.head.num);

        }

        // Test cases for removing a node from the head
        [TestMethod]
        public void Test_remove_Head_1()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.removHead();

            Assert.IsNull(node2.previous);
            Assert.IsNull(node1.next);
        }

        [TestMethod]
        public void Test_remove_Head_2()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);
            dll1.removHead();

            Assert.IsNull(node2.previous);
            Assert.IsNull(node1.next);
            Assert.IsNotNull(node1.previous);
        }

        // Test cases for removing a node from the tail
        [TestMethod]
        public void Test_remove_Tail_1()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);

            dll1.addToTail(node1);
            dll1.addToTail(node2);
            dll1.removeTail();

            Assert.IsNull(node2.next);
            Assert.IsNull(node1.previous);
        }

        [TestMethod]
        public void Test_remove_Tail_2()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToTail(node1);
            dll1.addToTail(node2);
            dll1.addToTail(node3);
            dll1.removeTail();

            Assert.IsNotNull(node2.next);
            Assert.IsNull(node1.previous);
            Assert.IsNotNull(node1.next);
        }

        // Test cases for removing a specific node
        [TestMethod]
        public void Test_remove_node_1()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);

            dll1.removeNode(node2);
            Assert.AreEqual(node3, dll1.head);
            Assert.AreEqual(node1, dll1.tail);
            Assert.AreEqual(node3.next,node1);
        }

        [TestMethod]
        public void Test_remove_node_2()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToTail(node1);
            dll1.addToTail(node2);
            dll1.addToTail(node3);

            dll1.removeNode(node2);
            Assert.AreEqual(node1, dll1.head);
            Assert.AreEqual(node3, dll1.tail);
            Assert.AreEqual(node1.next,node3.previous);

        }
        /*
        [TestMethod]
        public void Test_remove_node_3()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
           
            dll1.addToTail(node1);
            
            dll1.removeNode(node1);
            Assert.AreEqual(null, node1.previous);
            Assert.AreEqual(null,node1.next);

        }  */

        // Test cases for searching for a node in the list
        [TestMethod]
        public void Test_search_node_1()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);

            //dll1.removeNode(node2);

            DLLNode s1 = dll1.search(60);
            Assert.AreEqual(node2.num, s1.num);
        }

        [TestMethod]
        public void Test_search_node_2()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);

            dll1.removeNode(node2);

            DLLNode s1 = dll1.search(60);
            Assert.IsNull(s1);
        }

        [TestMethod]
        public void Test_search_node_3()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);

            dll1.removeNode(node2);

            DLLNode s1 = dll1.search(60);
            DLLNode s2 = dll1.search(90);
            DLLNode s3 = dll1.search(50);
            Assert.IsNull(s1);
            Assert.IsNull(s2);
            Assert.IsNotNull(s3);
        }

        //Test cases for calculating the total value of nodes
        [TestMethod]
        public void Test_Total_node()
        {
            DLList dll1 = new DLList();
            DLLNode node1 = new DLLNode(50);
            DLLNode node2 = new DLLNode(60);
            DLLNode node3 = new DLLNode(70);

            dll1.addToHead(node1);
            dll1.addToHead(node2);
            dll1.addToHead(node3);

            int s1 = dll1.total();
            Assert.AreEqual(180,s1);
        }

        // Test cases for the isPrime method
        [TestMethod]
        public void Test_IsPrime()
        {
            DLLNode node = new DLLNode(0); // For testing isPrime method

            Assert.IsFalse(node.isPrime(-1)); // Negative number
            Assert.IsFalse(node.isPrime(0));  // Zero
            Assert.IsFalse(node.isPrime(1));  // One
            Assert.IsTrue(node.isPrime(2));   // Prime number
            Assert.IsTrue(node.isPrime(23));   // Prime number
            Assert.IsFalse(node.isPrime(25));
            Assert.IsFalse(node.isPrime(49));
        }
    }
}