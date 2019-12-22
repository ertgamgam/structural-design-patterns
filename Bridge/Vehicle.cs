using System.Collections.Generic;

namespace Bridge
{
    public abstract class Vehicle
    {
        protected List<IWorkshop> _workshops;

        protected Vehicle(List<IWorkshop> workshops) => _workshops = workshops;

        abstract public void Manufacture();
    }
}