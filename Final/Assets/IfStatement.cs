using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class IfStatement : MonoBehaviour
{
	public bool LightOn;
	public string Password;
	public int A, B, C;

	public FloatData WizardPower, PawnPower;
	public NameID Lock, Key;
	
	void Update()
	{
		
		if (Lock == Key)
		{
			print("Open Door");
		}
		
		if (WizardPower.Value > PawnPower.Value)
		{
			print("Wizard wins.");
		}
		
		if(LightOn)
		{
			print("The Light Is On.");
		}
		else
		{
			print("The Light is off.");
		}

		if (Password == "0U812")
		{
			print("You are correct!");
		}
		
		if (C == A + B)
		{
			print(C);
		}
	}
}