using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityServices
{
    public class Issues
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFile { get; set; }

        public Issues(string location, string category, string description, string attachedFile)
        {
            Location = location;
            Category = category;
            Description = description;
            AttachedFile = attachedFile;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Attached File: {AttachedFile}";
        }
    }
}
