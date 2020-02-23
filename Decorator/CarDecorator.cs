namespace Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar _car;

        protected CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual void Assemble()
        {
            this._car.Assemble();
        }
    }
}