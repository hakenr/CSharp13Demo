namespace PartialIndexers;

public partial class Demo
{
	public partial string this[int index] { get; set; }
}

public partial class Demo
{
	private List<string> _items = ["one", "two", "three", "four", "five"];

	public partial string this[int index]
	{
		get => _items[index];
		set => _items[index] = value;
	}
}
