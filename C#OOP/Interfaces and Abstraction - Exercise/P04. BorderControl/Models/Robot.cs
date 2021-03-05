using P04._BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04._BorderControl.Models
{
    class Robot :  IIdentifiable
    {
        private string model;
        private string id;
        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }
        //public string Model { get; }

        //public string Id { get; }

        public string GetId()
        {
            return this.id;
        }
    }
}
