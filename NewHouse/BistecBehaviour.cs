using System;
using System.Collections;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class BistecBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public int troncos;

		public bool añadidop;

		public bool[] spawned;

		public bool[] enbuenestado;

		public bool[] crudo;

		public bool[] hecho;

		public bool[] quemado;

		public bool[] podrido;

		public float[] tiempopodrir;

		public Color[] toshow;

		public float[] posX;

		public float[] posY;

		public float[] posZ;

		public float[] rotX;

		public float[] rotY;

		public float[] rotZ;
	}

	private FileteBehaviour[] bistecs = new FileteBehaviour[50];

	private GameObject storechuleta;

	private Transform posileña;

	private GameObject chuleton;

	private Transform posichuleton;

	private TriggerCallback tiggerparrilla;

	private TriggerCallback tiggerparrillaleña;

	private AudioSource tiggerparrillaleñaaudio;

	private TriggerCallback tiggerguardaleña;

	private AudioSource tiggerguardaleñaaudio;

	private GameObject triggerparrilla;

	private GameObject triggerparrillaleña;

	private GameObject triggerguardaleña;

	public int troncosañadidos = -1;

	private GameObject leña1;

	private GameObject leña2;

	private GameObject leña3;

	private GameObject leña4;

	private GameObject leña5;

	private GameObject leña6;

	private GameObject leña7;

	private GameObject leña8;

	private GameObject leña9;

	private GameObject leña10;

	private GameObject leña11;

	private GameObject leña12;

	private GameObject leña13;

	private GameObject leña14;

	private GameObject leña15;

	private GameObject leña16;

	private GameObject leña17;

	public bool encendido;

	public bool añadidoparrilla;

	public bool añadidocarne;

	private FsmBool m_guiUseBool;

	public float timerfuego;

	private GameObject particula;

	private Material real;

	private Material noreal;

	public Color toshow;

	public float duration = 20f;

	public float smoothness = 0.01f;

	public bool comienzachicha;

	public float timermaxfuego = 120f;

	public float timermaxpodrir = 900f;

	public bool renueva;

	private GameObject trasgob;

	private FsmString m_guiInteractString;

	private GameObject sitioleñaguardar;

	private void Start()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		trasgob = ModBehaviour.m_bundle.LoadAsset<GameObject>("firewood(itemx)").gameObject;
		((Object)trasgob).name = "firewood(Clone)";
		trasgob.layer = LayerMask.NameToLayer("Parts");
		trasgob.tag = "ITEM";
		m_guiInteractString = PlayMakerGlobals.Instance.Variables.FindFsmString("GUIinteraction");
		trasgob.transform.localScale = new Vector3(1f, 1f, 1f);
		renueva = true;
		sitioleñaguardar = ((Component)((Component)this).transform.FindChild("sitioleñaguardar")).gameObject;
		triggerparrilla = ((Component)((Component)this).transform.FindChild("parrilla/triggerparrilla")).gameObject;
		chuleton = ((Component)triggerparrilla.transform.FindChild("chuleton")).gameObject;
		posichuleton = ((Component)triggerparrilla.transform.FindChild("posichuleton")).transform;
		posileña = ((Component)sitioleñaguardar.transform.FindChild("posileña")).transform;
		noreal = chuleton.GetComponent<Renderer>().material;
		leña1 = ((Component)sitioleñaguardar.transform.FindChild("leña1")).gameObject;
		leña2 = ((Component)sitioleñaguardar.transform.FindChild("leña2")).gameObject;
		leña3 = ((Component)sitioleñaguardar.transform.FindChild("leña3")).gameObject;
		leña4 = ((Component)sitioleñaguardar.transform.FindChild("leña4")).gameObject;
		leña5 = ((Component)sitioleñaguardar.transform.FindChild("leña5")).gameObject;
		leña6 = ((Component)sitioleñaguardar.transform.FindChild("leña6")).gameObject;
		leña7 = ((Component)sitioleñaguardar.transform.FindChild("leña7")).gameObject;
		leña8 = ((Component)sitioleñaguardar.transform.FindChild("leña8")).gameObject;
		leña9 = ((Component)sitioleñaguardar.transform.FindChild("leña13")).gameObject;
		leña10 = ((Component)sitioleñaguardar.transform.FindChild("leña14")).gameObject;
		leña11 = ((Component)sitioleñaguardar.transform.FindChild("leña15")).gameObject;
		leña12 = ((Component)sitioleñaguardar.transform.FindChild("leña16")).gameObject;
		leña13 = ((Component)sitioleñaguardar.transform.FindChild("leña9")).gameObject;
		leña14 = ((Component)sitioleñaguardar.transform.FindChild("leña10")).gameObject;
		leña15 = ((Component)sitioleñaguardar.transform.FindChild("leña11")).gameObject;
		leña16 = ((Component)sitioleñaguardar.transform.FindChild("leña12")).gameObject;
		triggerparrillaleña = ((Component)((Component)this).transform.FindChild("parrilla/triggerparrillaleña")).gameObject;
		leña17 = ((Component)triggerparrillaleña.transform.FindChild("leña17")).gameObject;
		tiggerparrillaleñaaudio = triggerparrillaleña.GetComponent<AudioSource>();
		triggerguardaleña = ((Component)sitioleñaguardar.transform.FindChild("triggerguardaleña")).gameObject;
		tiggerguardaleñaaudio = triggerguardaleña.GetComponent<AudioSource>();
		tiggerparrilla = triggerparrilla.AddComponent<TriggerCallback>();
		TriggerCallback triggerCallback = tiggerparrilla;
		triggerCallback.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback.onTriggerStay, new Action<Collider>(OnTriggerStayparrilla));
		tiggerparrillaleña = triggerparrillaleña.AddComponent<TriggerCallback>();
		TriggerCallback triggerCallback2 = tiggerparrillaleña;
		triggerCallback2.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback2.onTriggerStay, new Action<Collider>(OnTriggerStayparrillaleña));
		tiggerguardaleña = triggerguardaleña.AddComponent<TriggerCallback>();
		TriggerCallback triggerCallback3 = tiggerguardaleña;
		triggerCallback3.onTriggerStay = (Action<Collider>)Delegate.Combine(triggerCallback3.onTriggerStay, new Action<Collider>(OnTriggerStayleña));
		particula = ((Component)triggerparrillaleña.transform.FindChild("fuegoleña")).gameObject;
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
		particula.SetActive(false);
		Load();
		Load2();
	}

	public void Save()
	{
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = new SaveData();
		SaveDataList item = new SaveDataList
		{
			troncos = troncosañadidos,
			añadidop = añadidoparrilla
		};
		saveData.save.Add(item);
		SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-barbecue.save");
		bistecs = Object.FindObjectsOfType<FileteBehaviour>();
		if (bistecs == null)
		{
			return;
		}
		for (int i = 0; i < bistecs.Length; i++)
		{
			SaveData saveData2 = new SaveData();
			SaveDataList saveDataList = new SaveDataList
			{
				spawned = new bool[bistecs.Length],
				enbuenestado = new bool[bistecs.Length],
				crudo = new bool[bistecs.Length],
				hecho = new bool[bistecs.Length],
				quemado = new bool[bistecs.Length],
				podrido = new bool[bistecs.Length],
				tiempopodrir = new float[bistecs.Length],
				toshow = new Color[bistecs.Length],
				posX = new float[bistecs.Length],
				posY = new float[bistecs.Length],
				posZ = new float[bistecs.Length],
				rotX = new float[bistecs.Length],
				rotY = new float[bistecs.Length],
				rotZ = new float[bistecs.Length]
			};
			for (int j = 0; j < saveDataList.spawned.Length; j++)
			{
				saveDataList.spawned[j] = bistecs[j].spawned;
				saveDataList.enbuenestado[j] = bistecs[j].enbuenestado;
				saveDataList.crudo[j] = bistecs[j].crudo;
				saveDataList.hecho[j] = bistecs[j].hecho;
				saveDataList.quemado[j] = bistecs[j].quemado;
				saveDataList.podrido[j] = bistecs[j].podrido;
				saveDataList.tiempopodrir[j] = bistecs[j].tiempopodrir;
				saveDataList.toshow[j] = bistecs[j].toshow;
				saveDataList.posY[j] = ((Component)bistecs[j]).transform.position.y;
				saveDataList.posZ[j] = ((Component)bistecs[j]).transform.position.z;
				float[] rotX = saveDataList.rotX;
				int num = j;
				Quaternion rotation = ((Component)bistecs[j]).transform.rotation;
				rotX[num] = rotation.eulerAngles.x;
				float[] rotY = saveDataList.rotY;
				int num2 = j;
				rotation = ((Component)bistecs[j]).transform.rotation;
				rotY[num2] = rotation.eulerAngles.y;
				float[] rotZ = saveDataList.rotZ;
				int num3 = j;
				rotation = ((Component)bistecs[j]).transform.rotation;
				rotZ[num3] = rotation.eulerAngles.z;
				saveDataList.posX[j] = ((Component)bistecs[j]).transform.position.x;
			}
			saveData2.save.Add(saveDataList);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData2, "NewHouse-steaks.save");
		}
	}

	private void Load()
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-steaks.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].spawned.Length];
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				FileteBehaviour fileteBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				array[i] = ((Component)fileteBehaviour).gameObject;
				array[i].GetComponent<FileteBehaviour>().spawned = saveData.save[0].spawned[i];
				array[i].GetComponent<FileteBehaviour>().enbuenestado = saveData.save[0].enbuenestado[i];
				array[i].GetComponent<FileteBehaviour>().crudo = saveData.save[0].crudo[i];
				array[i].GetComponent<FileteBehaviour>().hecho = saveData.save[0].hecho[i];
				array[i].GetComponent<FileteBehaviour>().quemado = saveData.save[0].quemado[i];
				array[i].GetComponent<FileteBehaviour>().podrido = saveData.save[0].podrido[i];
				((Component)array[i].transform.FindChild("Raw_meat")).GetComponent<Renderer>().material.color = saveData.save[0].toshow[i];
				array[i].GetComponent<FileteBehaviour>().tiempopodrir = saveData.save[0].tiempopodrir[i];
				array[i].transform.position = new Vector3(saveData.save[0].posX[i], saveData.save[0].posY[i], saveData.save[0].posZ[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotX[i], saveData.save[0].rotY[i], saveData.save[0].rotZ[i]);
			}
		}
	}

	private void Load2()
	{
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-barbecue.save");
		if (saveData != null)
		{
			troncosañadidos = saveData.save[0].troncos;
			añadidoparrilla = saveData.save[0].añadidop;
			return;
		}
		troncosañadidos = -1;
		añadidocarne = false;
		añadidoparrilla = false;
		encendido = false;
	}

	private void OnTriggerStayparrilla(Collider collider)
	{
		if (Object.op_Implicit((Object)(object)((Component)collider).gameObject.GetComponent<FileteBehaviour>()) && !añadidocarne && ((Component)collider).gameObject.GetComponent<FileteBehaviour>().crudo)
		{
			storechuleta = ((Component)collider).gameObject;
			((Component)collider).gameObject.SetActive(false);
			añadidocarne = true;
			if (encendido)
			{
				comienzachicha = true;
			}
		}
	}

	private void OnTriggerStayparrillaleña(Collider collider)
	{
		if (((Object)((Component)collider).gameObject).name == "firewood(Clone)" && !encendido && !añadidoparrilla)
		{
			Object.Destroy((Object)(object)((Component)collider).gameObject);
			añadidoparrilla = true;
		}
	}

	private void OnTriggerStayleña(Collider collider)
	{
		if (((Object)((Component)collider).gameObject).name == "firewood(Clone)" && troncosañadidos < 15)
		{
			troncosañadidos++;
			if (troncosañadidos == 0)
			{
				leña1.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 1)
			{
				leña2.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 2)
			{
				leña3.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 3)
			{
				leña4.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 4)
			{
				leña5.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 5)
			{
				leña6.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 6)
			{
				leña7.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 7)
			{
				leña8.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 8)
			{
				leña9.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 9)
			{
				leña10.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 10)
			{
				leña11.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 11)
			{
				leña12.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 12)
			{
				leña13.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 13)
			{
				leña14.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 14)
			{
				leña15.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
			if (troncosañadidos == 15)
			{
				leña16.SetActive(true);
				Object.Destroy((Object)(object)((Component)collider).gameObject);
			}
		}
	}

	private IEnumerator LerpColor()
	{
		float progress = 0f;
		float increment = smoothness / duration;
		real = ((Component)storechuleta.transform.FindChild("Raw_meat")).GetComponent<Renderer>().material;
		while (progress < 1f)
		{
			toshow = Color.Lerp(real.color, Color.black, progress);
			progress += increment;
			yield return (object)new WaitForSeconds(smoothness);
		}
		yield return true;
	}

	private void Update()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null))
		{
			return;
		}
		if (renueva)
		{
			((MonoBehaviour)this).StopCoroutine("LerpColor");
			toshow.b = 1f;
			toshow.g = 1f;
			toshow.r = 1f;
			toshow.a = 1f;
			noreal.SetColor("_Color", toshow);
			renueva = false;
		}
		if (añadidocarne && encendido)
		{
			if (comienzachicha && !renueva)
			{
				((MonoBehaviour)this).StartCoroutine("LerpColor");
				comienzachicha = false;
			}
			noreal.SetColor("_Color", toshow);
		}
		if (Vector3.Distance(GameObject.Find("PLAYER").transform.position, transform.position) <= 10f)
		{
		RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(Input.mousePosition), 1.5f);
		foreach (RaycastHit hit in array)
		{
			RayBistec(hit);
		}
		}
		if (añadidocarne)
		{
			chuleton.SetActive(true);
		}
		if (!añadidocarne)
		{
			chuleton.SetActive(false);
		}
		if (añadidoparrilla)
		{
			leña17.SetActive(true);
		}
		if (!añadidoparrilla)
		{
			leña17.SetActive(false);
		}
		if (troncosañadidos == -1)
		{
			leña1.SetActive(false);
			leña2.SetActive(false);
			leña3.SetActive(false);
			leña4.SetActive(false);
			leña5.SetActive(false);
			leña6.SetActive(false);
			leña7.SetActive(false);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 0)
		{
			leña1.SetActive(true);
			leña2.SetActive(false);
			leña3.SetActive(false);
			leña4.SetActive(false);
			leña5.SetActive(false);
			leña6.SetActive(false);
			leña7.SetActive(false);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 1)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(false);
			leña4.SetActive(false);
			leña5.SetActive(false);
			leña6.SetActive(false);
			leña7.SetActive(false);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 2)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(false);
			leña5.SetActive(false);
			leña6.SetActive(false);
			leña7.SetActive(false);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 3)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(false);
			leña6.SetActive(false);
			leña7.SetActive(false);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 4)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(false);
			leña7.SetActive(false);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 5)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(false);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 6)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(false);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 7)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(false);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 8)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(false);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 9)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(true);
			leña11.SetActive(false);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 10)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(true);
			leña11.SetActive(true);
			leña12.SetActive(false);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 11)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(true);
			leña11.SetActive(true);
			leña12.SetActive(true);
			leña13.SetActive(false);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 12)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(true);
			leña11.SetActive(true);
			leña12.SetActive(true);
			leña13.SetActive(true);
			leña14.SetActive(false);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 13)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(true);
			leña11.SetActive(true);
			leña12.SetActive(true);
			leña13.SetActive(true);
			leña14.SetActive(true);
			leña15.SetActive(false);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 14)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(true);
			leña11.SetActive(true);
			leña12.SetActive(true);
			leña13.SetActive(true);
			leña14.SetActive(true);
			leña15.SetActive(true);
			leña16.SetActive(false);
		}
		if (troncosañadidos == 15)
		{
			leña1.SetActive(true);
			leña2.SetActive(true);
			leña3.SetActive(true);
			leña4.SetActive(true);
			leña5.SetActive(true);
			leña6.SetActive(true);
			leña7.SetActive(true);
			leña8.SetActive(true);
			leña9.SetActive(true);
			leña10.SetActive(true);
			leña11.SetActive(true);
			leña12.SetActive(true);
			leña13.SetActive(true);
			leña14.SetActive(true);
			leña15.SetActive(true);
			leña16.SetActive(true);
		}
		if (encendido)
		{
			particula.SetActive(true);
			if (!tiggerparrillaleñaaudio.isPlaying)
			{
				tiggerparrillaleñaaudio.Play();
			}
			timerfuego += Time.deltaTime;
			if (timerfuego > timermaxfuego)
			{
				if (tiggerparrillaleñaaudio.isPlaying)
				{
					tiggerparrillaleñaaudio.Stop();
				}
				particula.SetActive(false);
				encendido = false;
				((MonoBehaviour)this).StopCoroutine("LerpColor");
				añadidoparrilla = false;
				timerfuego = 0f;
			}
		}
		if (troncosañadidos <= -1)
		{
			troncosañadidos = -1;
		}
		else if (troncosañadidos >= 15)
		{
			troncosañadidos = 15;
		}
	}

	private void RayBistec(RaycastHit hit)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)((Component)hit.collider).gameObject == (Object)(object)triggerguardaleña && troncosañadidos <= 15 && troncosañadidos >= 0)
		{
			m_guiUseBool.Value = true;
			if (Input.GetMouseButtonDown(0))
			{
				if (troncosañadidos == 15)
				{
					GameObject val = Object.Instantiate<GameObject>(trasgob);
					((Object)val).name = "firewood(Clone)";
					val.transform.SetParent(posileña);
					val.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 14)
				{
					GameObject val2 = Object.Instantiate<GameObject>(trasgob);
					((Object)val2).name = "firewood(Clone)";
					val2.transform.SetParent(posileña);
					val2.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 13)
				{
					GameObject val3 = Object.Instantiate<GameObject>(trasgob);
					((Object)val3).name = "firewood(Clone)";
					val3.transform.SetParent(posileña);
					val3.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 12)
				{
					GameObject val4 = Object.Instantiate<GameObject>(trasgob);
					((Object)val4).name = "firewood(Clone)";
					val4.transform.SetParent(posileña);
					val4.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 11)
				{
					GameObject val5 = Object.Instantiate<GameObject>(trasgob);
					((Object)val5).name = "firewood(Clone)";
					val5.transform.SetParent(posileña);
					val5.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 10)
				{
					GameObject val6 = Object.Instantiate<GameObject>(trasgob);
					((Object)val6).name = "firewood(Clone)";
					val6.transform.SetParent(posileña);
					val6.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 9)
				{
					GameObject val7 = Object.Instantiate<GameObject>(trasgob);
					((Object)val7).name = "firewood(Clone)";
					val7.transform.SetParent(posileña);
					val7.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 8)
				{
					GameObject val8 = Object.Instantiate<GameObject>(trasgob);
					((Object)val8).name = "firewood(Clone)";
					val8.transform.SetParent(posileña);
					val8.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 7)
				{
					GameObject val9 = Object.Instantiate<GameObject>(trasgob);
					((Object)val9).name = "firewood(Clone)";
					val9.transform.SetParent(posileña);
					val9.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 6)
				{
					GameObject val10 = Object.Instantiate<GameObject>(trasgob);
					((Object)val10).name = "firewood(Clone)";
					val10.transform.SetParent(posileña);
					val10.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 5)
				{
					GameObject val11 = Object.Instantiate<GameObject>(trasgob);
					((Object)val11).name = "firewood(Clone)";
					val11.transform.SetParent(posileña);
					val11.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 4)
				{
					GameObject val12 = Object.Instantiate<GameObject>(trasgob);
					((Object)val12).name = "firewood(Clone)";
					val12.transform.SetParent(posileña);
					val12.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 3)
				{
					GameObject val13 = Object.Instantiate<GameObject>(trasgob);
					((Object)val13).name = "firewood(Clone)";
					val13.transform.SetParent(posileña);
					val13.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 2)
				{
					GameObject val14 = Object.Instantiate<GameObject>(trasgob);
					((Object)val14).name = "firewood(Clone)";
					val14.transform.SetParent(posileña);
					val14.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 1)
				{
					GameObject val15 = Object.Instantiate<GameObject>(trasgob);
					((Object)val15).name = "firewood(Clone)";
					val15.transform.SetParent(posileña);
					val15.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
				else if (troncosañadidos == 0)
				{
					GameObject val16 = Object.Instantiate<GameObject>(trasgob);
					((Object)val16).name = "firewood(Clone)";
					val16.transform.SetParent(posileña);
					val16.transform.localPosition = new Vector3(0f, 0f, 0f);
					troncosañadidos--;
				}
			}
		}
		if ((Object)(object)((Component)hit.collider).gameObject == (Object)(object)triggerparrillaleña && !encendido && añadidoparrilla)
		{
			m_guiUseBool.Value = true;
			m_guiInteractString.Value = "START A FIRE";
			if (Input.GetMouseButtonDown(0))
			{
				encendido = true;
				comienzachicha = true;
			}
		}
		if ((Object)(object)((Component)hit.collider).gameObject == (Object)(object)triggerparrilla && añadidocarne)
		{
			m_guiUseBool.Value = true;
			if (toshow.b > 0.5f && toshow.b <= 1f)
			{
				m_guiInteractString.Value = "RAW";
			}
			if (toshow.b > 0.3f && toshow.b <= 0.5f)
			{
				m_guiInteractString.Value = "COOKED";
			}
			if (toshow.b >= 0f && toshow.b <= 0.3f)
			{
				m_guiInteractString.Value = "BURNT";
			}
			if (Input.GetMouseButtonDown(0))
			{
				real = ((Component)storechuleta.transform.FindChild("Raw_meat")).GetComponent<Renderer>().material;
				real.SetColor("_Color", toshow);
				storechuleta.SetActive(true);
				storechuleta.transform.position = posichuleton.position;
				añadidocarne = false;
				renueva = true;
			}
		}
	}
}
