using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tuple<T, U, V>
{
    public Tuple(T item1, U item2, V item3)
    {
        this.Item1 = item1;
        this.Item2 = item2;
        this.item3 = item3;
    }

    public T Item1 { get; private set; }
    public U Item2 { get; private set; }
    public V item3 { get; private set; }

    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2} -> {this.item3}";
    }
}
