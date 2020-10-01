# asp.net-core-console-program-to-generate-api-key-in-csharp
asp.net core console program to generate api key in c#

```

 var key = new byte[32];

            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(key);
            }
            string apiKey = Convert.ToBase64String(key);
            Console.WriteLine("Your API KEY IS :    " + apiKey);

```
