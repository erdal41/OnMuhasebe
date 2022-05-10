using System;

namespace Muhasebe.Model.Attributes
{
    public class Kod : Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        public Kod(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}