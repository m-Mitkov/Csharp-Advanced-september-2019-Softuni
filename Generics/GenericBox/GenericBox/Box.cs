

namespace GenericBox
{
    public class Box<T>
    {
        private T items;

        public Box(T item)
        {
            this.items = item;
        }

        public override string ToString()
        {
            return $"{this.items.GetType()}: {this.items}";
        }
    }
}
