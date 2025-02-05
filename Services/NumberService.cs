namespace NumberClassfierAPI.Services
{
    public class NumberService
    {
        public bool IsPrime(int number)
        {
            if(number <= 1) return false;
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0) return false;
            }
            return true;
        }
        public bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) sum += i;
            }
            return sum == number;
        }
        public List<string> GetNumberProperties(int number)
        {
            var properties = new List<string>();

            if (IsArmstrong(number)) properties.Add("armstrong");
            if (number % 2 != 0) properties.Add("odd");
            else properties.Add("even");

            return properties;
        }

        public bool IsArmstrong(int number)
        {
            int sum = 0, temp = number, remainder, digits = 0;
            while (temp != 0)
            {
                temp /= 10;
                digits++;
            }

            temp = number;
            while (temp != 0)
            {
                remainder = temp % 10;
                sum += (int)Math.Pow(remainder, digits);
                temp /= 10;
            }

            return sum == number;
        }

        public int GetDigitSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        public async Task<string> GetFunFact(int number)
        {
            using (var client = new HttpClient())
            {
                string url = $"http://numbersapi.com/{number}/math";
                var response = await client.GetStringAsync(url);
                return response; 
            }
        }
    }
}
