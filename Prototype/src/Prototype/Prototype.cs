using System;

namespace Prototype
{
    public abstract class Prototype
    {
        private string _id;

        public int Counter { get; set; } = 0;

        // Constructor

        public Prototype(string id)
        {
            this._id = id;
        }

        // Gets id

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

}
