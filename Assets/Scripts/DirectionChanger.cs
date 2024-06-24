using UnityEngine;
using System.Collections;

public class DirectionChanger: MonoBehaviour
{
	public enum Changer {Horizontal, Vertical};
	public Changer direction;

	void Start ()
	{
		GameManager.OnDuckShot += TurnOff;
		GameManager.OnDuckMiss += TurnOff;
		GameManager.OnSpawnDucks += TurnOn;
	}

	public void OnCollisionEnter(Collision hit)
	{
		if (hit.transform.tag == "Duck")
		{

			if (direction == Changer.Horizontal)
			{
				Vector3 = (new Vector3(-1f, 1, 0));
			}
			else if (direction == Changer.Vertical)
			{
				Vector3 = (new Vector3(1, -1f, 0));
			}
		}
	}

	public void TurnOff()
	{
		gameObject.SetActive (false);
	}

	public void TurnOn()
	{
		gameObject.SetActive (true);
	}
}
