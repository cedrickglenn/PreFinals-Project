using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Calculations
    {
        public int GetPrice(decimal price, decimal discount, int weight)
        {
            return Convert.ToInt32((price * weight) - (price * weight * (discount / 100)));
        }

        public void GetReceiptNumber()
        {
            bool isUnique = true;
            Random random = new Random();
            do
            {
                int receiptNumber = random.Next(10000000, 99999999);
                if (DataStorage.receiptNumberList.Count != 0)
                {
                    for (int counter = 0; counter < DataStorage.receiptNumberList.Count; counter++)
                    {
                        if (receiptNumber == DataStorage.receiptNumberList[counter])
                            isUnique = false;
                        else
                            DataStorage.receiptNumberList.Add(receiptNumber);
                        isUnique = true;
                    }
                }
                else
                {
                    DataStorage.receiptNumberList.Add(receiptNumber);
                }
            } while (!isUnique);
        }
        public decimal CalculateMonthsElapsed(DateTime birthDate)
        {
            int age;

            DateTime now = DateTime.Now;
            DateTime past = Convert.ToDateTime(birthDate);

            age = ((now.Year - past.Year)* 12) + (now.Month - past.Month);
            return age;
        }
        
        public decimal GetAccumulatedAmount(decimal loanAmount, decimal interestRate, DateTime date)
        {
            return (loanAmount * (interestRate / 100) * CalculateMonthsElapsed(date));
        }
        
    }
   
}
