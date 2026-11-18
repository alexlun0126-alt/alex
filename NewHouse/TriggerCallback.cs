using System;
using UnityEngine;

namespace NewHouse;

public class TriggerCallback : MonoBehaviour
{
	public Action<Collider> onTriggerEnter;

	public Action<Collider> onTriggerExit;

	public Action<Collider> onTriggerStay;

	private void OnTriggerEnter(Collider other)
	{
		onTriggerEnter(other);
	}

	private void OnTriggerExit(Collider other)
	{
		onTriggerExit(other);
	}

	private void OnTriggerStay(Collider other)
	{
		onTriggerStay(other);
	}
}
