using System;

namespace Muhasebe.Model.Attributes
{
    public class ZorunluAlan : Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        public ZorunluAlan(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}