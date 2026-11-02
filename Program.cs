namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.
        Console.WriteLine("Welcome to our temperature converter. Tell us which way you want to convert.");
        Console.WriteLine("Type 1 for C° to F°, 2 for F° to C°"); 
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 1)
        {
            Console.WriteLine("Converting from Celsius to Fahrenheit... Enter the temperature.");
            float temperatureCelsius = Convert.ToSingle(Console.ReadLine());
            float conversionFahrenheit = (temperatureCelsius * 9 / 5 + 32);
            Console.WriteLine("Converted to Fahrenheit... " + temperatureCelsius + "°Celsius makes " + conversionFahrenheit + "° Fahrenheit.");
        }
        else if (answer == 2)
        {
            Console.WriteLine("Converting from Fahrenheit to Celsius... Enter the temperature.");
            float temperatureFahrenheit = Convert.ToSingle(Console.ReadLine());
            float conversionCelsius = ((temperatureFahrenheit - 32) * 5 / 9);
            Console.WriteLine("Converted to Celsius... " + temperatureFahrenheit + "° Fahrenheit makes " + conversionCelsius + "° Celsius.");
        }
    }
}