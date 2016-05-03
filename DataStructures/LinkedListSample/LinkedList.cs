﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSample
{
    public class LinkedList
    {
        /*
         * Class level variables:
         * 
         * Properties:
         * [x] Head : Node - Holds the reference to the first node in the list.
         * [x] Count : int - Holds the count / size of the items in the list .
         * [x] Empty : bool - Whether the list is empty.
         * 
         * Methods:
         * [x] Insert(int position, object data):void - Inserts the given object at the respective position.
         * [x] Add(object data):void - Adds the object to the end of the list.
         * [x] AddFirst(object data):void - Inserts the oobject to the beginining of the list.
         * [] Remove(int position):Node - Removes the object from the specified position.
         * [] IndexOf(object data):int - Retrieves the position of the data from the list.
         * [] Get(int position):object - Fetches the data from the specified position in the list.
         * [] Contains(object data):bool - Returns whther the object is present in the list.
         */
                 
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList"/> class.
        /// </summary>
        public LinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }

        /// <summary>
        /// Gets the head.
        /// </summary>
        /// <value>
        /// The head.
        /// </value>
        public Node Head { get; private set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is empty.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </value>
        public bool IsEmpty { get { return this.Count == 0; } }

        /// <summary>
        /// Inserts the data in the specified position. Zero based index.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="data">The data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Insert(int position, object data)
        {
            // Check for position not falling below the start range.
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(position));
            }

            // Check for position not exceeding the end range. If so reset the position to the end ransge.
            if (position > this.Count)
            {
                position = this.Count;
            }

            if (this.IsEmpty || position == 0)
            {
                // Handling the case of the node to be added at the begining. 
                // 2 possible scenarios: 1)If the list is empty, 2)If the new node to be added at the beginining.
                this.Head = new Node(data, this.Head);
            }
            else
            {
                Node current = null;
                Node next = this.Head;

                // Iterate the nodes till one level before the position so that Next can be assigned with new Node 
                // and the existing next to be passed as paramter for new node.
                for (int i = 0; i < position; i++)
                {
                    current = next;
                    next = current.Next;
                }

                current.Next = new Node(data, next);
            }

            this.Count++;
        }

        /// <summary>
        /// Adds the specified data to the end of the linked list.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(object data)
        {
            this.Insert(this.Count, data);
        }

        /// <summary>
        /// Adds the first.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddFirst(object data)
        {
            this.Insert(0, data);
        }

    }
}
