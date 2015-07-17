namespace Robot
{
	public class Machine
	{
		string _name;
		string _location;
		string _bin;

		public Machine(string name, string location)
		{
			_name = name;
			_location = location;
		}

		public string Take()
		{
			string result = _bin;
			_bin = null;
			return result;
		}

		public string Bin
		{
			get { return _bin; }
		}

		public void Put(string bin)
		{
			_bin = bin;
		}

		public string Name
		{
			get { return _name; }
		}
	}
}

