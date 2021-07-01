public class Many {

	private int _countMany = 0;

	public Many(int value) {
		SetMany (value);
	}
	public Many(){}

 
	public void SetMany(int value){
		_countMany = value;
	}
	public void AddMany(){
		_countMany++;	 
	}
	public int countMany {
		get {
			return _countMany;
		}
	}
}
