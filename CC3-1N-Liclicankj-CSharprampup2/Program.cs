namespace CC3_1N_Liclicankj_CSharprampup2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pounds to Kilograms");
            int weight_in_pounds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Weight in Pounds = " + weight_in_pounds);
            Console.WriteLine("Weight in Kilograms = " + (weight_in_pounds * 0.45359237));

            Console.WriteLine("Miles to Kilometers");
            int distance_in_miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Distance in Miles (mi) = " + distance_in_miles);
            Console.WriteLine("Distance in Kilometers (km) = " + (distance_in_miles * 1.6));

            Console.WriteLine("Fahrenheit to Celsius");
            int fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fahrenheit (°F) = " + fahrenheit);
            Console.WriteLine("Celsius (°C) = " + ((fahrenheit - 32) * 5 / 9));

            Console.WriteLine("Enter the students ages = ");
            Console.WriteLine("Student 1 = ");
            int age_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 2 = ");
            int age_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 3 = ");
            int age_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 4 = ");
            int age_4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 5 = ");
            int age_5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 6 = ");
            int age_6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 7 = ");
            int age_7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 8 = ");
            int age_8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 9 = ");
            int age_9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student 10 = ");
            int age_10 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Age of Student 1 = " + age_1);
            Console.WriteLine("Age os Student 2 = " + age_2);
            Console.WriteLine("Age of Student 3 = " + age_3);
            Console.WriteLine("Age os Student 4 = " + age_4);
            Console.WriteLine("Age of Student 5 = " + age_5);
            Console.WriteLine("Age of Student 6 = " + age_6);
            Console.WriteLine("Age of Student 7 = " + age_7);
            Console.WriteLine("Age of Student 8 = " + age_8);
            Console.WriteLine("Age of Student 9 = " + age_9);
            Console.WriteLine("Age of Student 10 = " + age_10);

            var ages = new int[] { age_1, age_2, age_3, age_4, age_5, age_6, age_7, age_8, age_9, age_10 };
            double average = Queryable.Average(ages.AsQueryable());
            Console.WriteLine("The Average Age of the Students is = " + average);

            string hero = "Luci";
            string villain = "Zack";
            string companionName = "Elfo";
            string companion2Name = "Map Girl";
            string companion3Name = "Merkimen";

            string heroWeapon = "Trident";
            string villainWeapon = "Axe";
            string companion1Weapon = "Magical Staff";
            string companion2Weapon = "Almighty Map";
            string companion3Weapon = "Excalibur";

            string heroAbility = "Lightning Strike";
            string villainAbility = "Berserk";
            string companionAbility = "Fireball";
            string companion2Ability = "Locate";
            string companion3Ability = "Multi Slash";

            Console.WriteLine($"Once upon a time, there were 5 heroes in the distant land called Fantasy Land. Their names are {hero}, {companionName}, {companion2Name}, {companion3Name}, and {villain}");
            Console.WriteLine($"{hero} had his weapon called {heroWeapon} and has a skill called {heroAbility}, {companionName} is an elf and has a {companion1Weapon} with the magic capable of summoning {companionAbility}, {companion2Name} has a tool called {companion2Weapon} which could help them find the demon lord called {companion2Ability}");
            Console.WriteLine($"{companion3Name} has a sword called {companion3Weapon} with a skill called {companion3Ability} and lastly, {villain} the demon lord holds the {villainWeapon} which has the power to use {villainAbility}. {hero}, {companionName}, and {companion2Name} set on an adventure to defeat the demon king {villain}.");
            Console.WriteLine($"{companion2Name} used {companion2Ability} to {villain}, now they are on their way to go to {villain}. After a tremendous amount of journey, they finally found {villain}. {hero} suddenly used his skill {heroAbility} damaging {villain} tremendously. {villain} was badly hurt and used his skill {villainAbility}.");
            Console.WriteLine($"The group suddenly got frightened but they still could not back down. {hero}, {companionName}, and {companion3Name} used all their skills and killed the demon lord {villain}");

            Console.Write("Enter a Number ");
            int pattern1N = int.Parse(Console.ReadLine());

            if (pattern1N <= 0)
            {
                Console.WriteLine("Invalid input for Pattern 1");
            }
            else
            {
                Console.WriteLine("Pattern 1:");
                for (int i = 1; i <= pattern1N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }


            Console.Write("Enter A Number");
            int pattern2N = int.Parse(Console.ReadLine());

            if (pattern2N <= 0)
            {
                Console.WriteLine("Invalid input for Pattern 2");
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= pattern2N; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Pattern 2: Sum of numbers from 1 to {pattern2N} is: {sum}");
            }


            Console.Write("Enter a Number");
            int pattern3N = int.Parse(Console.ReadLine());

            if (pattern3N <= 0)
            {
                Console.WriteLine("Invalid input for Pattern 3");
            }
            else
            {
                Console.WriteLine("Pattern 3:");
                for (int i = pattern3N; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
