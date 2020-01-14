﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Modelling
    {
        public List<Item> Records { get; set; }

        public class Item {
            public string First { get; set; }
            public string Last { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Zip { get; set; }
            public long Number { get; set; }
        }
        
        /*private string first;
        private string last;
        private string address;
        private string city;
        private string state;
        private int zip;
        private long number;

        /// <summary>
        /// Initializes a new instance of the <see cref="Modelling"/> class.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="last">The last.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="number">The number.</param>
        public Modelling(string first, string last, string address, string city, string state, int zip, long number) {
            this.first = first;
            this.last = last;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.number = number;
        }

        /// <summary>
        /// Gets or sets the first.
        /// </summary>
        /// <value>
        /// The first.
        /// </value>
        public string First {
            get { return this.first; }
            set { this.first = value; }
        }

        /// <summary>
        /// Gets or sets the last.
        /// </summary>
        /// <value>
        /// The last.
        /// </value>
        public string Last {
            get { return this.last; }
            set { this.last = value; }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address {
            get { return this.address; }
            set { this.address = value; }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City {
            get { return this.city; }
            set { this.city = value; }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public int Zip {
            get { return this.zip; }
            set { this.zip = value; }
        }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public long Number {
            get { return this.number; }
            set { this.number = value; }
        }*/
    }
}