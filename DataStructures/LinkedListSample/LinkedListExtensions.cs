namespace LinkedListSample    
{
    using static System.Console;
    /// <summary>
    /// Linked list extensions.
    /// </summary>
    public static class LinkedListExtensions
    {
        /// <summary>
        /// Prints to console.
        /// </summary>
        /// <param name="linkedList">The linked list.</param>
        public static void PrintToConsole(this LinkedList linkedList)
        {
            var currentNode = linkedList.Head;

            while (currentNode != null)
            {
                WriteLine(currentNode.Data.ToString());
                currentNode = currentNode.Next;
            }
        }
    }
}
