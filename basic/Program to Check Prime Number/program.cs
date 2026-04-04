Console.Write("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                count++;
        }

        if (count == 2)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not Prime");
    }
}
