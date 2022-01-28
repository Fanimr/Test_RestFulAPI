using System;

namespace API.Domain.Models
{
    public class BaseModel
    {
        private Guid _id;

        private string _name;

        private string _description;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
