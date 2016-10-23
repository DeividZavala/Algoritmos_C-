using System;

namespace checarCupon
{
	class MainClass
	{
		/*public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
		{
			return enteredCode == correctCode && DateTime.Parse(currentDate) <= DateTime.Parse(expirationDate);
		}*/

		public static bool CheckCoupon(string enteredCode, string correctCode, string currentDateString, string expirationDateString)
		{        
			var currentDate = DateTime.Parse(currentDateString);
			var expirationDate = DateTime.Parse(expirationDateString);

			bool isNotExpired = currentDate <= expirationDate;

			bool isCouponValid = enteredCode == correctCode;

			if (isCouponValid && isNotExpired) {
				Console.WriteLine ("True");
			} else {
				Console.WriteLine ("False");
			}
			return isCouponValid && isNotExpired;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			CheckCoupon ("123","123","September 5, 2014","October 1, 2014");
		}
	}
}
