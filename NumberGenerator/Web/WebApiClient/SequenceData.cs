using Newtonsoft.Json;
using System;

namespace Web.WebApiClient
{
    public class SequenceData
    {
        /// <summary>
        /// Invoke web api client to get all numbers and format the data returned
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetAllNumbers(int number)
        {
            string allNumbers = "";
            
            try
            {
                SequenceApiClient numericSequenceApiClient = new SequenceApiClient();

                string requestUrl = "http://localhost:10827/api/Numbers/AllNumbers/" + number;

                string response = numericSequenceApiClient.GetSequence(requestUrl);

                dynamic allnumbers = JsonConvert.DeserializeObject(response);
                int count = 1;
                int length = allnumbers.Count;
                foreach (var allnumber in allnumbers)
                {
                    string punc = "";
                    if (count < length)
                        punc = ", ";

                    allNumbers = allNumbers + allnumber + punc;
                    count++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allNumbers;
        }

        /// <summary>
        /// Invoke web api client to get all even numbers and format the data returned
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetAllEvenNumbers(int number)
        {
            string allEvenNumbers = "";

            try
            {
                SequenceApiClient numericSequenceApiClient = new SequenceApiClient();

                string requestUrl = "http://localhost:10827/api/Numbers/AllEvenNumbers/" + number;

                string response = numericSequenceApiClient.GetSequence(requestUrl);

                dynamic evennumbers = JsonConvert.DeserializeObject(response);
                int count = 1;
                int length = evennumbers.Count;
                foreach (var evennumber in evennumbers)
                {
                    string punc = "";
                    if (count < length)
                        punc = ", ";

                    allEvenNumbers = allEvenNumbers + evennumber + punc;
                    count++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allEvenNumbers;
        }

        /// <summary>
        /// Invoke web api client to get all odd numbers and format the data returned
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetAllOddNumbers(int number)
        {
            string allOddNumbers = "";

            try
            {
                SequenceApiClient numericSequenceApiClient = new SequenceApiClient();

                string requestUrl = "http://localhost:10827/api/Numbers/AllOddNumbers/" + number;

                string response = numericSequenceApiClient.GetSequence(requestUrl);

                dynamic oddnumbers = JsonConvert.DeserializeObject(response);
                int count = 1;
                int length = oddnumbers.Count;
                foreach (var oddnumber in oddnumbers)
                {
                    string punc = "";
                    if (count < length)
                        punc = ", ";

                    allOddNumbers = allOddNumbers + oddnumber + punc;
                    count++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allOddNumbers;
        }

        /// <summary>
        /// Invoke web api client to get all extended fizz buzzs and format the data returned
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetAllExtendedFizzBuzzs(int number)
        {
            string allExtendedFizzBuzzs = "";
            
            try
            {
                SequenceApiClient numericSequenceApiClient = new SequenceApiClient();

                string requestUrl = "http://localhost:10827/api/Numbers/AllExtendedFizzBuzzs/" + number;

                string response = numericSequenceApiClient.GetSequence(requestUrl);

                dynamic fizzbuzzs = JsonConvert.DeserializeObject(response);
                int count = 1;
                int length = fizzbuzzs.Count;
                foreach(var fizzBuzz in fizzbuzzs)
                {
                    string punc = "";
                    if (count < length)
                        punc = ", ";
                    
                    allExtendedFizzBuzzs = allExtendedFizzBuzzs + fizzBuzz + punc;
                    count++;
                }
                              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allExtendedFizzBuzzs;
        }

        /// <summary>
        /// Invoke web api client to get all fibonacci series and format the data returned
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetAllFibonacciNumbers(int number)
        {
            string allFibonacciNumbers = "";

            try
            {
                SequenceApiClient numericSequenceApiClient = new SequenceApiClient();

                string requestUrl = "http://localhost:10827/api/Numbers/AllFibonacciNumbers/" + number;

                string response = numericSequenceApiClient.GetSequence(requestUrl);

                dynamic fibonaccinumbers = JsonConvert.DeserializeObject(response);
                int count = 1;
                int length = fibonaccinumbers.Count;
                foreach (var fibonaccinumber in fibonaccinumbers)
                {
                    string punc = "";
                    if (count < length)
                        punc = ", ";

                    allFibonacciNumbers = allFibonacciNumbers + fibonaccinumber + punc;
                    count++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return allFibonacciNumbers;
        }
    }
}
