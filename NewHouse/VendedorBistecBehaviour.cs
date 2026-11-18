using System;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class VendedorBistecBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public int[] ecantidadchuleta;

		public bool[] espawneado;

		public float[] posX;

		public float[] posY;

		public float[] posZ;

		public float[] rotX;

		public float[] rotY;

		public float[] rotZ;
	}

	private GameObject chuletavendor1;

	private GameObject chuletavendor2;

	private GameObject chuletavendor3;

	private GameObject chuletavendor4;

	private GameObject estante;

	private GameObject bolsa;

	public float preciochuleta = 15f;

	private bool m_isBeingBought;

	private float[] tiempo;

	private float tiemporeventa = 500f;

	public GameObject register;

	public int cantidadchuleta;

	private FsmString m_guiInteractString;

	private FsmBool m_guiBuyBool;

	private void Start()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		tiempo = new float[20];
		for (int i = 0; i < tiempo.Length; i++)
		{
			tiempo[i] = 0f;
		}
		estante = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("estantecarnenevera")).gameObject;
		estante.transform.parent = null;
		estante.transform.position = new Vector3(-1545.42f, 4.529792f, 1182.82f);
		estante.transform.eulerAngles = new Vector3(0f, 237f, 0f);
		estante.transform.localScale = new Vector3(1.1f, 1f, 1f);
		chuletavendor1 = ((Component)estante.transform.FindChild("chuleta1")).gameObject;
		((Object)chuletavendor1).name = "Raw Steak";
		chuletavendor2 = ((Component)estante.transform.FindChild("chuleta2")).gameObject;
		((Object)chuletavendor2).name = "Raw Steak";
		chuletavendor3 = ((Component)estante.transform.FindChild("chuleta3")).gameObject;
		((Object)chuletavendor3).name = "Raw Steak";
		chuletavendor4 = ((Component)estante.transform.FindChild("chuleta4")).gameObject;
		((Object)chuletavendor4).name = "Raw Steak";
		register = GameObject.Find("STORE/StoreCashRegister/Register").gameObject;
		register.GetComponent<PlayMakerFSM>().FsmInject("Purchase", (Action)OnBuyHook);
		m_guiBuyBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIbuy");
		m_guiInteractString = PlayMakerGlobals.Instance.Variables.FindFsmString("GUIinteraction");
		Load();
	}

	public void Save()
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		BolsaNewBehaviour[] array = Object.FindObjectsOfType<BolsaNewBehaviour>();
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				SaveData saveData = new SaveData();
				SaveDataList saveDataList = new SaveDataList
				{
					espawneado = new bool[array.Length],
					ecantidadchuleta = new int[array.Length],
					posX = new float[array.Length],
					posY = new float[array.Length],
					posZ = new float[array.Length],
					rotX = new float[array.Length],
					rotY = new float[array.Length],
					rotZ = new float[array.Length]
				};
				for (int j = 0; j < saveDataList.espawneado.Length; j++)
				{
					saveDataList.espawneado[j] = array[j].spawneado;
					saveDataList.ecantidadchuleta[j] = array[j].cantidadchuleta;
					saveDataList.posX[j] = ((Component)array[j]).transform.position.x;
					saveDataList.posY[j] = ((Component)array[j]).transform.position.y;
					saveDataList.posZ[j] = ((Component)array[j]).transform.position.z;
					float[] rotX = saveDataList.rotX;
					int num = j;
					Quaternion rotation = ((Component)array[j]).transform.rotation;
					rotX[num] = rotation.eulerAngles.x;
					float[] rotY = saveDataList.rotY;
					int num2 = j;
					rotation = ((Component)array[j]).transform.rotation;
					rotY[num2] = rotation.eulerAngles.y;
					float[] rotZ = saveDataList.rotZ;
					int num3 = j;
					rotation = ((Component)array[j]).transform.rotation;
					rotZ[num3] = rotation.eulerAngles.z;
				}
				saveData.save.Add(saveDataList);
				SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-bags.save");
			}
		}
		else
		{
			NewHouse.Testing3();
		}
	}

	private void Load()
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-bags.save");
		if (saveData != null)
		{
			BolsaNewBehaviour[] array = new BolsaNewBehaviour[saveData.save[0].espawneado.Length];
			for (int i = 0; i < array.Length; i++)
			{
				BolsaNewBehaviour bolsaNewBehaviour = Object.Instantiate<GameObject>(Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("bolsaa")).gameObject).AddComponent<BolsaNewBehaviour>();
				array[i] = bolsaNewBehaviour;
				((Component)array[i]).gameObject.SetActive(true);
				((Behaviour)((Component)array[i]).gameObject.GetComponent<PlayMakerFSM>()).enabled = false;
				array[i].cantidadchuleta = saveData.save[0].ecantidadchuleta[i];
				((Component)array[i]).transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				((Component)array[i]).transform.rotation = Quaternion.Euler(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Update()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		RaycastHit val = default;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out val, 1f) && register.GetComponent<PlayMakerFSM>().FsmVariables.FindFsmBool("StoreOpen").Value)
		{
			if ((Object)(object)((Component)val.collider).gameObject == (Object)(object)chuletavendor1)
			{
				if (Input.GetKeyDown((KeyCode)323))
				{
					cantidadchuleta++;
					m_isBeingBought = true;
					PlayMakerFSM component = register.GetComponent<PlayMakerFSM>();
					FsmFloat fsmFloat = component.FsmVariables.GetFsmFloat("PriceTotal");
					fsmFloat.Value += preciochuleta;
					component.SendEvent("PURCHASE");
					chuletavendor1.SetActive(false);
				}
				m_guiBuyBool.Value = true;
				m_guiInteractString.Value = ((Object)chuletavendor1).name + " " + preciochuleta.ToString("F") + " MK";
			}
			if ((Object)(object)((Component)val.collider).gameObject == (Object)(object)chuletavendor2)
			{
				if (Input.GetKeyDown((KeyCode)323))
				{
					cantidadchuleta++;
					m_isBeingBought = true;
					PlayMakerFSM component2 = register.GetComponent<PlayMakerFSM>();
					FsmFloat fsmFloat2 = component2.FsmVariables.GetFsmFloat("PriceTotal");
					fsmFloat2.Value += preciochuleta;
					component2.SendEvent("PURCHASE");
					chuletavendor2.SetActive(false);
				}
				m_guiBuyBool.Value = true;
				m_guiInteractString.Value = ((Object)chuletavendor2).name + " " + preciochuleta.ToString("F") + " MK";
			}
			if ((Object)(object)((Component)val.collider).gameObject == (Object)(object)chuletavendor3)
			{
				if (Input.GetKeyDown((KeyCode)323))
				{
					cantidadchuleta++;
					m_isBeingBought = true;
					PlayMakerFSM component3 = register.GetComponent<PlayMakerFSM>();
					FsmFloat fsmFloat3 = component3.FsmVariables.GetFsmFloat("PriceTotal");
					fsmFloat3.Value += preciochuleta;
					component3.SendEvent("PURCHASE");
					chuletavendor3.SetActive(false);
				}
				m_guiBuyBool.Value = true;
				m_guiInteractString.Value = ((Object)chuletavendor3).name + " " + preciochuleta.ToString("F") + " MK";
			}
			if ((Object)(object)((Component)val.collider).gameObject == (Object)(object)chuletavendor4)
			{
				if (Input.GetKeyDown((KeyCode)323))
				{
					cantidadchuleta++;
					m_isBeingBought = true;
					PlayMakerFSM component4 = register.GetComponent<PlayMakerFSM>();
					FsmFloat fsmFloat4 = component4.FsmVariables.GetFsmFloat("PriceTotal");
					fsmFloat4.Value += preciochuleta;
					component4.SendEvent("PURCHASE");
					chuletavendor4.SetActive(false);
				}
				m_guiBuyBool.Value = true;
				m_guiInteractString.Value = ((Object)chuletavendor4).name + " " + preciochuleta.ToString("F") + " MK";
			}
		}
		if (!chuletavendor1.activeInHierarchy && !m_isBeingBought)
		{
			Activalo(chuletavendor1, 1);
		}
		if (!chuletavendor2.activeInHierarchy && !m_isBeingBought)
		{
			Activalo(chuletavendor2, 2);
		}
		if (!chuletavendor3.activeInHierarchy && !m_isBeingBought)
		{
			Activalo(chuletavendor3, 3);
		}
		if (!chuletavendor4.activeInHierarchy && !m_isBeingBought)
		{
			Activalo(chuletavendor4, 4);
		}
	}

	private void Activalo(GameObject este, int num)
	{
		tiempo[num] += Time.deltaTime;
		if (tiempo[num] > tiemporeventa)
		{
			este.SetActive(true);
			tiempo[num] = 0f;
		}
	}

	private void OnBuyHook()
	{
		if (m_isBeingBought)
		{
			m_isBeingBought = false;
			Pagado();
		}
	}

	private void Pagado()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		bolsa = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("bolsaa")).gameObject;
		BolsaNewBehaviour bolsaNewBehaviour = bolsa.AddComponent<BolsaNewBehaviour>();
		Vector3 position = new Vector3(-1551.1f, 5f, 1182.8f);
		Quaternion rotation = Quaternion.Euler(0f, 0f, 0f);
		((Component)bolsaNewBehaviour).gameObject.SetActive(true);
		bolsaNewBehaviour.spawneado = true;
		bolsaNewBehaviour.cantidadchuleta = cantidadchuleta;
		((Component)bolsaNewBehaviour).transform.position = position;
		((Component)bolsaNewBehaviour).transform.rotation = rotation;
		cantidadchuleta = 0;
	}
}
