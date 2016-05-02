namespace LinkedListSample
{
    /// <summary>
    /// Handles the details of the node.
    /// </summary>
    public class Node
    {
        /*
         * Properties:
         * [x] Data : object
         * [x] Next : Node
         */

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        public Node(object data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public Node Next { get; set; }        
    }
}
