public class DynamicArr
{
    private double[] arr;
    private int capacity;
    public int Size { get; private set; }
    public int Capacity { get { return capacity; } }    
    public DynamicArr()
    {
        arr = Array.Empty<double>();
        Size = capacity = 0;
    }
    public DynamicArr(int capacity)
    {
        this.capacity = capacity;
        Size = 0;
        arr = new double[capacity];
    }
    public DynamicArr(double[] arr)
    {  
        capacity = arr.Length * 2;
        Size = arr.Length;
        this.arr = new double[capacity];
        arr.CopyTo(this.arr, 0);
    }
    public void Input()
    {
        for (int i = 0; i < capacity; i++)
            arr[i] = Convert.ToDouble(Console.ReadLine());
        Size = capacity;
    }
    public override string ToString()
    {
        string array = "";
        for (int i = 0; i < Size; i++) { array = array + arr[i] + " "; }
        return array;
    }
    private void MoreCapacity()
    {
        if (Size == capacity)
        {
            double[] tmp = new double[capacity];
            arr.CopyTo(tmp, 0);
            if (Size != 0) capacity *= 2;
            else capacity = 1;
            arr = new double[capacity];
            tmp.CopyTo(arr, 0);
        }
    }
    private void LessCapacity()
    {
        if (Size == Math.Ceiling(capacity / 2.0) - 1)
        {
            capacity /= 2;
            double[] tmp = new double[capacity];
            Array.Copy(arr, tmp, capacity);
            arr = new double[capacity];
            tmp.CopyTo(arr, 0);
        }
    }
    public double Read(int index) { return arr[index]; }
    public void Write(double value, int index) { arr[index] = value; }
    public void Append(double value)
    {
        MoreCapacity();
        arr[Size++] = value;
    }
    public void Remove() {
        Size--;
        LessCapacity();
    }
    public void AppendAt(double element, int index)
    {
        MoreCapacity();
        for (int i = Size++; i > index; i--)
            arr[i] = arr[i - 1];
        arr[index] = element;
    }
    public void RemoveAt(int index)
    {
        for (int i = index; i < Size - 1; i++)
            arr[i] = arr[i + 1];
        Size--;
        LessCapacity();
    }
    public int MaxIndex()
    {
        int index = 0;
        for (int i = 1; i < Size; i++)
        {
            if (arr[i] > arr[index]) index = i;
        }
        return index;
    }
}

