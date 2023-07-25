namespace SL.VehicleMaintenance.Domain.DomainObjects
{
	public class Validations
	{
		public static void Required(string value, string message)
		{
			if (string.IsNullOrWhiteSpace(value))
				throw new Exception(message);
		}

		public static void MaxLength(string value, int max, string message)
		{
			var len = value.Trim().Length;
			if (len > max)
				throw new Exception(message);
		}

		public static void MinMaxLength(string? value, int min, int max, string message)
		{
			if (value is null) return;

			var len = value.Trim().Length;
			if (len < min || len > max)
				throw new Exception(message);
		}

		public static void IsEquals(object obj1, object obj2, string message)
		{
			if (obj1.Equals(obj2))
				throw new Exception(message);
		}

		public static void LessThan(int val1, int val2, string message)
		{
			if (val1 < val2)
				throw new Exception(message);
		}
	}
}
