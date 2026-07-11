namespace IT_ELECTIVE_2_PRELIM_EXAM.Models;

// EXERCISE 2: Encapsulation - Validation in Property Setter
// The Ingredient class has basic properties, but the setter for 'Quantity'
// has no validation. Your task:
// - Ensure 'Quantity' cannot be set to a negative number (throw ArgumentOutOfRangeException)
// - Ensure 'Name' cannot be set to null or empty (throw ArgumentException)

public class Ingredient
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            name = value;
        }
    }
    public string Measure { get; set; }

    private double quantity;
    public double Quantity
    {
        get { return quantity; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Quantity cannot be negative.");
            }
            quantity = value;
        }
    }

    public Ingredient()
    {
        Name = "null";
        Measure = "";
        Quantity = 0;
    }

    public Ingredient(string name, string measure, double quantity)
    {
        Name = name;
        Measure = measure;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Quantity} {Measure} of {Name}";
    }
}
