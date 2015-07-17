namespace Robot
{
	public class Robot
	{
		Machine _location;
		string _bin;

		public Robot() { }

		public Machine Location { get { return _location; } }
		public void MoveTo(Machine location) { _location = location; }

		public void Pick() { _bin = _location.Take(); }
		public string Bin { get { return _bin; } }

		public void Release()
		{
			_location.Put(_bin);
			_bin = null;
		}
	}
}
