using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test : MonoBehaviour {

	public int _exp = 0;

	void Start () {
		List<Dictionary<string,object>> data = CSVReader.Read("exp");

		_exp = (int)data[0]["EXP"];
		Debug.Log(_exp);
	}
}
