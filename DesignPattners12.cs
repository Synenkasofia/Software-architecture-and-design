using System;

// Ітератор
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

// Колекція
public class NumberCollection
{
    private int[] _numbers;

    public NumberCollection(int[] numbers) => _numbers = numbers;

    public IIterator<int> GetIterator() => new NumberIterator(this);

    public int GetItem(int index) => _numbers[index];

    public int Count => _numbers.Length;
}

// Конкретний ітератор
public class NumberIterator : IIterator<int>
{
    private NumberCollection _collection;
    private int _position = 0;

    public NumberIterator(NumberCollection collection) => _collection = collection;

    public bool HasNext() => _position < _collection.Count;

    public int Next() => _collection.GetItem(_position++);
}

// Клієнтський код
class Program
{
    static void Main()
    {
        var numbers = new NumberCollection(new int[] { 1, 2, 3, 4 });

        var iterator = numbers.GetIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
