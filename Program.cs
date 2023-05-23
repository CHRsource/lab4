DynamicArr a = new();
Console.WriteLine(a);
Console.WriteLine("Выделенная память = " + a.Capacity);
Console.WriteLine("Размер массива = " + a.Size);

DynamicArr b = new(5);
Console.WriteLine(b);
Console.WriteLine("Выделенная память = " + b.Capacity);
Console.WriteLine("Размер массива = " + b.Size);

Console.WriteLine("Введите массив:");
b.Input();
Console.WriteLine("Массив: " + b);
Console.WriteLine("Выделенная память = " + b.Capacity);
Console.WriteLine("Размер массива = " + b.Size);

DynamicArr c = new(new double[] { 8, -4, 2.12, -6.7, -20 });
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

int ind = 1;
Console.WriteLine($"Элемент массива C с индексом {ind} = " + c.Read(1));
c.Write(100.3, ind);
Console.WriteLine($"Массив С с измененным элементом по индексу {ind}: " + c);

double elem = 0;
c.Append(elem);
Console.WriteLine("Массив: " + c);

Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.Remove();
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.Remove();
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.AppendAt(20, 2);
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

c.RemoveAt(2);
Console.WriteLine("Массив: " + c);
Console.WriteLine("Выделенная память = " + c.Capacity);
Console.WriteLine("Размер массива = " + c.Size);

Console.WriteLine("Индекс максимального элемента = " + c.MaxIndex());