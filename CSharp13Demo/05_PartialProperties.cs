using System.Text.RegularExpressions;

namespace PartialProperties;

public partial class Demo
{
	// one declaring declaration of the property
	public partial string PropertyValue { get; set; }
}

public partial class Demo
{
	// one implementing declaration of the property
	public partial string PropertyValue
	{
		get => _propertyValue;
		set => _propertyValue = value;
	}
	private string _propertyValue;
}

// mostly used for generated code in practice, such as regexes
public partial class MyRegExs
{
	[GeneratedRegex(".*")]
	public partial Regex AnyString { get; }

	[GeneratedRegex("^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$")]
	public partial Regex Email { get; }
}
