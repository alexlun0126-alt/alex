using System;
using System.Collections.Generic;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class CompraObjetosBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public float[] posx;

		public float[] posy;

		public float[] posz;

		public float[] rotx;

		public float[] roty;

		public float[] rotz;

		public bool[] color1;

		public bool[] color2;

		public bool[] color3;

		public bool[] blanco;

		public bool[] verde;

		public bool[] azul;

		public bool[] raro;

		public bool[] naranja;

		public bool[] rojo;
	}

	private Vector3 spawnmesa;

	private Vector3 spawnmesa2;

	private Vector3 spawnsilla;

	private Vector3 spawnsilla2;

	private Vector3 spawnpouf;

	private Vector3 spawnsofa;

	private Vector3 spawnmesita;

	private Vector3 spawnalfombra;

	private Collider postbox;

	public PedidoBehaviour pedido;

	private GameObject post;

	public bool compramesa;

	public bool compramesa2;

	public bool comprasilla;

	public bool comprasilla2;

	public bool comprasofa;

	public bool comprapouf;

	public bool compraalfombra;

	public bool compranightstand;

	public bool pedidobuzon;

	public float tiempopedido;

	public float maxtiempopedido = 400f;

	private ControlPedidoBehaviour control;

	private ControlCajasBehaviour control2;

	private void Start()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		spawnmesa = new Vector3(-1556.937f, 4.6f, 1183.737f);
		spawnmesa2 = new Vector3(-1555.84f, 4.6f, 1182.514f);
		spawnsilla = new Vector3(-1554.751f, 4.6f, 1181.491f);
		spawnsilla2 = new Vector3(-1553.734f, 4.6f, 1180.021f);
		spawnpouf = new Vector3(-1557.717f, 4.6f, 1183.048f);
		spawnsofa = new Vector3(-1556.901f, 4.6f, 1181.49f);
		spawnmesita = new Vector3(-1556.191f, 4.6f, 1180.156f);
		spawnalfombra = new Vector3(-1552.608f, 4.6f, 1179.149f);
		control = ((Component)this).gameObject.AddComponent<ControlPedidoBehaviour>();
		control2 = ((Component)this).gameObject.AddComponent<ControlCajasBehaviour>();
		post = GameObject.Find("STORE/LOD/ActivateStore/PostOffice").gameObject;
		postbox = GameObject.Find("STORE/LOD/Post Box/OrderTrigger").GetComponent<Collider>();
		TriggerCallback triggerCallback = ((Component)postbox).gameObject.AddComponent<TriggerCallback>();
		triggerCallback.onTriggerEnter = (Action<Collider>)Delegate.Combine(triggerCallback.onTriggerEnter, new Action<Collider>(OnBagTriggerStay2));
		Loads();
	}

	private void OnBagTriggerStay2(Collider collider)
	{
		if ((Object)(object)collider == (Object)(object)((Component)pedido).GetComponent<Collider>())
		{
			pedidobuzon = true;
			((Component)pedido).gameObject.SetActive(false);
		}
	}

	private void Loads()
	{
		Load();
		Load2();
		Load3();
		Load4();
		Load5();
		Load6();
		Load7();
		Load8();
	}

	public void CompraCajaMesa()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaMesaPrefab")).AddComponent<CajaMesaBehaviour>()).transform.position = spawnmesa;
		compramesa = false;
	}

	public void CompraCajaPouf()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaPoufPrefab")).AddComponent<CajaPoufBehaviour>()).transform.position = spawnpouf;
		comprapouf = false;
	}

	public void CompraCajaSofa()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaSofaPrefab")).AddComponent<CajaSofaBehaviour>()).transform.position = spawnsofa;
		comprasofa = false;
	}

	public void CompraCajaSilla()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaSillaPrefab")).AddComponent<CajaSillaBehaviour>()).transform.position = spawnsilla;
		comprasilla = false;
	}

	public void CompraCajaAlfombra()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaAlfombraPrefab")).AddComponent<CajaAlfombraBehaviour>()).transform.position = spawnalfombra;
		compraalfombra = false;
	}

	public void CompraCajaMesa2()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaMesa2Prefab")).AddComponent<CajaMesa2Behaviour>()).transform.position = spawnmesa2;
		compramesa2 = false;
	}

	public void CompraCajaSilla2()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaSilla2Prefab")).AddComponent<CajaSilla2Behaviour>()).transform.position = spawnsilla2;
		comprasilla2 = false;
	}

	public void CompraCajaNightStand()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Component)Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("CajaNightStandPrefab")).AddComponent<CajaNightStandBehaviour>()).transform.position = spawnmesita;
		compranightstand = false;
	}

	public void PedidoCajaMesa()
	{
		compramesa = true;
	}

	public void PedidoCajaPouf()
	{
		comprapouf = true;
	}

	public void PedidoCajaSofa()
	{
		comprasofa = true;
	}

	public void PedidoCajaSilla()
	{
		comprasilla = true;
	}

	public void PedidoCajaAlfombra()
	{
		compraalfombra = true;
	}

	public void PedidoCajaMesa2()
	{
		compramesa2 = true;
	}

	public void PedidoCajaSilla2()
	{
		comprasilla2 = true;
	}

	public void PedidoCajaNightStand()
	{
		compranightstand = true;
	}

	public void SacarPedido(Vector3 pos, float valor)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		pedido = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("PedidoPrefab")).AddComponent<PedidoBehaviour>();
		((Component)pedido).transform.position = pos;
		pedido.compramesa = compramesa;
		pedido.compramesa2 = compramesa2;
		pedido.comprasilla = comprasilla;
		pedido.comprasilla2 = comprasilla2;
		pedido.comprapouf = comprapouf;
		pedido.comprasofa = comprasofa;
		pedido.compranightstand = compranightstand;
		pedido.compraalfombra = compraalfombra;
		pedido.precio = valor;
	}

	public void Save()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
		control.Save();
		control2.Save();
		MesaBehaviour[] array = Object.FindObjectsOfType<MesaBehaviour>();
		Quaternion rotation;
		if (array != null)
		{
			SaveData saveData = new SaveData();
			SaveDataList saveDataList = new SaveDataList
			{
				posx = new float[array.Length],
				posy = new float[array.Length],
				posz = new float[array.Length],
				rotx = new float[array.Length],
				roty = new float[array.Length],
				rotz = new float[array.Length],
				color1 = new bool[array.Length],
				color2 = new bool[array.Length],
				color3 = new bool[array.Length]
			};
			for (int i = 0; i < array.Length; i++)
			{
				saveDataList.posx[i] = ((Component)array[i]).transform.position.x;
				saveDataList.posy[i] = ((Component)array[i]).transform.position.y;
				saveDataList.posz[i] = ((Component)array[i]).transform.position.z;
				float[] rotx = saveDataList.rotx;
				int num = i;
				rotation = ((Component)array[i]).transform.rotation;
				rotx[num] = rotation.eulerAngles.x;
				float[] roty = saveDataList.roty;
				int num2 = i;
				rotation = ((Component)array[i]).transform.rotation;
				roty[num2] = rotation.eulerAngles.y;
				float[] rotz = saveDataList.rotz;
				int num3 = i;
				rotation = ((Component)array[i]).transform.rotation;
				rotz[num3] = rotation.eulerAngles.z;
				saveDataList.color1[i] = array[i].color1;
				saveDataList.color2[i] = array[i].color2;
				saveDataList.color3[i] = array[i].color3;
			}
			saveData.save.Add(saveDataList);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-tables.save");
		}
		PoufBehaviour[] array2 = Object.FindObjectsOfType<PoufBehaviour>();
		if (array2 != null)
		{
			SaveData saveData2 = new SaveData();
			SaveDataList saveDataList2 = new SaveDataList
			{
				posx = new float[array2.Length],
				posy = new float[array2.Length],
				posz = new float[array2.Length],
				rotx = new float[array2.Length],
				roty = new float[array2.Length],
				rotz = new float[array2.Length],
				blanco = new bool[array2.Length],
				verde = new bool[array2.Length],
				azul = new bool[array2.Length],
				raro = new bool[array2.Length]
			};
			for (int j = 0; j < array2.Length; j++)
			{
				saveDataList2.posx[j] = ((Component)array2[j]).transform.position.x;
				saveDataList2.posy[j] = ((Component)array2[j]).transform.position.y;
				saveDataList2.posz[j] = ((Component)array2[j]).transform.position.z;
				float[] rotx2 = saveDataList2.rotx;
				int num4 = j;
				rotation = ((Component)array2[j]).transform.rotation;
				rotx2[num4] = rotation.eulerAngles.x;
				float[] roty2 = saveDataList2.roty;
				int num5 = j;
				rotation = ((Component)array2[j]).transform.rotation;
				roty2[num5] = rotation.eulerAngles.y;
				float[] rotz2 = saveDataList2.rotz;
				int num6 = j;
				rotation = ((Component)array2[j]).transform.rotation;
				rotz2[num6] = rotation.eulerAngles.z;
				saveDataList2.blanco[j] = array2[j].blanco;
				saveDataList2.verde[j] = array2[j].verde;
				saveDataList2.azul[j] = array2[j].azul;
				saveDataList2.raro[j] = array2[j].raro;
			}
			saveData2.save.Add(saveDataList2);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData2, "NewHouse-poufs.save");
		}
		SofaBehaviour[] array3 = Object.FindObjectsOfType<SofaBehaviour>();
		if (array3 != null)
		{
			SaveData saveData3 = new SaveData();
			SaveDataList saveDataList3 = new SaveDataList
			{
				posx = new float[array3.Length],
				posy = new float[array3.Length],
				posz = new float[array3.Length],
				rotx = new float[array3.Length],
				roty = new float[array3.Length],
				rotz = new float[array3.Length],
				blanco = new bool[array3.Length],
				verde = new bool[array3.Length],
				azul = new bool[array3.Length],
				raro = new bool[array3.Length]
			};
			for (int k = 0; k < array3.Length; k++)
			{
				saveDataList3.posx[k] = ((Component)array3[k]).transform.position.x;
				saveDataList3.posy[k] = ((Component)array3[k]).transform.position.y;
				saveDataList3.posz[k] = ((Component)array3[k]).transform.position.z;
				float[] rotx3 = saveDataList3.rotx;
				int num7 = k;
				rotation = ((Component)array3[k]).transform.rotation;
				rotx3[num7] = rotation.eulerAngles.x;
				float[] roty3 = saveDataList3.roty;
				int num8 = k;
				rotation = ((Component)array3[k]).transform.rotation;
				roty3[num8] = rotation.eulerAngles.y;
				float[] rotz3 = saveDataList3.rotz;
				int num9 = k;
				rotation = ((Component)array3[k]).transform.rotation;
				rotz3[num9] = rotation.eulerAngles.z;
				saveDataList3.blanco[k] = array3[k].blanco;
				saveDataList3.verde[k] = array3[k].verde;
				saveDataList3.azul[k] = array3[k].azul;
				saveDataList3.raro[k] = array3[k].raro;
			}
			saveData3.save.Add(saveDataList3);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData3, "NewHouse-couchs.save");
		}
		SillaBehaviour[] array4 = Object.FindObjectsOfType<SillaBehaviour>();
		if (array4 != null)
		{
			SaveData saveData4 = new SaveData();
			SaveDataList saveDataList4 = new SaveDataList
			{
				posx = new float[array4.Length],
				posy = new float[array4.Length],
				posz = new float[array4.Length],
				rotx = new float[array4.Length],
				roty = new float[array4.Length],
				rotz = new float[array4.Length],
				blanco = new bool[array4.Length],
				verde = new bool[array4.Length],
				azul = new bool[array4.Length],
				raro = new bool[array4.Length]
			};
			for (int l = 0; l < array4.Length; l++)
			{
				saveDataList4.posx[l] = ((Component)array4[l]).transform.position.x;
				saveDataList4.posy[l] = ((Component)array4[l]).transform.position.y;
				saveDataList4.posz[l] = ((Component)array4[l]).transform.position.z;
				float[] rotx4 = saveDataList4.rotx;
				int num10 = l;
				rotation = ((Component)array4[l]).transform.rotation;
				rotx4[num10] = rotation.eulerAngles.x;
				float[] roty4 = saveDataList4.roty;
				int num11 = l;
				rotation = ((Component)array4[l]).transform.rotation;
				roty4[num11] = rotation.eulerAngles.y;
				float[] rotz4 = saveDataList4.rotz;
				int num12 = l;
				rotation = ((Component)array4[l]).transform.rotation;
				rotz4[num12] = rotation.eulerAngles.z;
				saveDataList4.blanco[l] = array4[l].blanco;
				saveDataList4.verde[l] = array4[l].verde;
				saveDataList4.azul[l] = array4[l].azul;
				saveDataList4.raro[l] = array4[l].raro;
			}
			saveData4.save.Add(saveDataList4);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData4, "NewHouse-deskchairs.save");
		}
		AlfombraBehaviour[] array5 = Object.FindObjectsOfType<AlfombraBehaviour>();
		if (array5 != null)
		{
			SaveData saveData5 = new SaveData();
			SaveDataList saveDataList5 = new SaveDataList
			{
				posx = new float[array5.Length],
				posy = new float[array5.Length],
				posz = new float[array5.Length],
				rotx = new float[array5.Length],
				roty = new float[array5.Length],
				rotz = new float[array5.Length],
				naranja = new bool[array5.Length],
				verde = new bool[array5.Length],
				azul = new bool[array5.Length],
				rojo = new bool[array5.Length]
			};
			for (int m = 0; m < array5.Length; m++)
			{
				saveDataList5.posx[m] = ((Component)array5[m]).transform.position.x;
				saveDataList5.posy[m] = ((Component)array5[m]).transform.position.y;
				saveDataList5.posz[m] = ((Component)array5[m]).transform.position.z;
				float[] rotx5 = saveDataList5.rotx;
				int num13 = m;
				rotation = ((Component)array5[m]).transform.rotation;
				rotx5[num13] = rotation.eulerAngles.x;
				float[] roty5 = saveDataList5.roty;
				int num14 = m;
				rotation = ((Component)array5[m]).transform.rotation;
				roty5[num14] = rotation.eulerAngles.y;
				float[] rotz5 = saveDataList5.rotz;
				int num15 = m;
				rotation = ((Component)array5[m]).transform.rotation;
				rotz5[num15] = rotation.eulerAngles.z;
				saveDataList5.naranja[m] = array5[m].naranja;
				saveDataList5.verde[m] = array5[m].verde;
				saveDataList5.azul[m] = array5[m].azul;
				saveDataList5.rojo[m] = array5[m].rojo;
			}
			saveData5.save.Add(saveDataList5);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData5, "NewHouse-carpets.save");
		}
		Mesa2Behaviour[] array6 = Object.FindObjectsOfType<Mesa2Behaviour>();
		if (array6 != null)
		{
			SaveData saveData6 = new SaveData();
			SaveDataList saveDataList6 = new SaveDataList
			{
				posx = new float[array6.Length],
				posy = new float[array6.Length],
				posz = new float[array6.Length],
				rotx = new float[array6.Length],
				roty = new float[array6.Length],
				rotz = new float[array6.Length],
				color1 = new bool[array6.Length],
				color2 = new bool[array6.Length],
				color3 = new bool[array6.Length]
			};
			for (int n = 0; n < array6.Length; n++)
			{
				saveDataList6.posx[n] = ((Component)array6[n]).transform.position.x;
				saveDataList6.posy[n] = ((Component)array6[n]).transform.position.y;
				saveDataList6.posz[n] = ((Component)array6[n]).transform.position.z;
				float[] rotx6 = saveDataList6.rotx;
				int num16 = n;
				rotation = ((Component)array6[n]).transform.rotation;
				rotx6[num16] = rotation.eulerAngles.x;
				float[] roty6 = saveDataList6.roty;
				int num17 = n;
				rotation = ((Component)array6[n]).transform.rotation;
				roty6[num17] = rotation.eulerAngles.y;
				float[] rotz6 = saveDataList6.rotz;
				int num18 = n;
				rotation = ((Component)array6[n]).transform.rotation;
				rotz6[num18] = rotation.eulerAngles.z;
				saveDataList6.color1[n] = array6[n].color1;
				saveDataList6.color2[n] = array6[n].color2;
				saveDataList6.color3[n] = array6[n].color3;
			}
			saveData6.save.Add(saveDataList6);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData6, "NewHouse-tables2.save");
		}
		Silla2Behaviour[] array7 = Object.FindObjectsOfType<Silla2Behaviour>();
		if (array7 != null)
		{
			SaveData saveData7 = new SaveData();
			SaveDataList saveDataList7 = new SaveDataList
			{
				posx = new float[array7.Length],
				posy = new float[array7.Length],
				posz = new float[array7.Length],
				rotx = new float[array7.Length],
				roty = new float[array7.Length],
				rotz = new float[array7.Length],
				color1 = new bool[array7.Length],
				color2 = new bool[array7.Length],
				color3 = new bool[array7.Length]
			};
			for (int num19 = 0; num19 < array7.Length; num19++)
			{
				saveDataList7.posx[num19] = ((Component)array7[num19]).transform.position.x;
				saveDataList7.posy[num19] = ((Component)array7[num19]).transform.position.y;
				saveDataList7.posz[num19] = ((Component)array7[num19]).transform.position.z;
				float[] rotx7 = saveDataList7.rotx;
				int num20 = num19;
				rotation = ((Component)array7[num19]).transform.rotation;
				rotx7[num20] = rotation.eulerAngles.x;
				float[] roty7 = saveDataList7.roty;
				int num21 = num19;
				rotation = ((Component)array7[num19]).transform.rotation;
				roty7[num21] = rotation.eulerAngles.y;
				float[] rotz7 = saveDataList7.rotz;
				int num22 = num19;
				rotation = ((Component)array7[num19]).transform.rotation;
				rotz7[num22] = rotation.eulerAngles.z;
				saveDataList7.color1[num19] = array7[num19].color1;
				saveDataList7.color2[num19] = array7[num19].color2;
				saveDataList7.color3[num19] = array7[num19].color3;
			}
			saveData7.save.Add(saveDataList7);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData7, "NewHouse-chairs.save");
		}
		NightStandBehaviour[] array8 = Object.FindObjectsOfType<NightStandBehaviour>();
		if (array8 != null)
		{
			SaveData saveData8 = new SaveData();
			SaveDataList saveDataList8 = new SaveDataList
			{
				posx = new float[array8.Length],
				posy = new float[array8.Length],
				posz = new float[array8.Length],
				rotx = new float[array8.Length],
				roty = new float[array8.Length],
				rotz = new float[array8.Length]
			};
			for (int num23 = 0; num23 < array8.Length; num23++)
			{
				saveDataList8.posx[num23] = ((Component)array8[num23]).transform.position.x;
				saveDataList8.posy[num23] = ((Component)array8[num23]).transform.position.y;
				saveDataList8.posz[num23] = ((Component)array8[num23]).transform.position.z;
				float[] rotx8 = saveDataList8.rotx;
				int num24 = num23;
				rotation = ((Component)array8[num23]).transform.rotation;
				rotx8[num24] = rotation.eulerAngles.x;
				float[] roty8 = saveDataList8.roty;
				int num25 = num23;
				rotation = ((Component)array8[num23]).transform.rotation;
				roty8[num25] = rotation.eulerAngles.y;
				float[] rotz8 = saveDataList8.rotz;
				int num26 = num23;
				rotation = ((Component)array8[num23]).transform.rotation;
				rotz8[num26] = rotation.eulerAngles.z;
			}
			saveData8.save.Add(saveDataList8);
			SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData8, "NewHouse-nightstands.save");
		}
	}

	private void Load()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-tables.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posx.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (saveData.save[0].color1[i])
			{
				MesaBehaviour mesaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa1Prefab")).AddComponent<MesaBehaviour>();
				array[i] = ((Component)mesaBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<MesaBehaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<MesaBehaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<MesaBehaviour>().color3 = saveData.save[0].color3[i];
			}
			if (saveData.save[0].color2[i])
			{
				MesaBehaviour mesaBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa2Prefab")).AddComponent<MesaBehaviour>();
				array[i] = ((Component)mesaBehaviour2).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<MesaBehaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<MesaBehaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<MesaBehaviour>().color3 = saveData.save[0].color3[i];
			}
			if (saveData.save[0].color3[i])
			{
				MesaBehaviour mesaBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa3Prefab")).AddComponent<MesaBehaviour>();
				array[i] = ((Component)mesaBehaviour3).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<MesaBehaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<MesaBehaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<MesaBehaviour>().color3 = saveData.save[0].color3[i];
			}
		}
	}

	private void Load2()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-poufs.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posx.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (saveData.save[0].blanco[i])
			{
				PoufBehaviour poufBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("PoufBlancoPrefab")).AddComponent<PoufBehaviour>();
				array[i] = ((Component)poufBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<PoufBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<PoufBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<PoufBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<PoufBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].verde[i])
			{
				PoufBehaviour poufBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("PoufVerdePrefab")).AddComponent<PoufBehaviour>();
				array[i] = ((Component)poufBehaviour2).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<PoufBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<PoufBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<PoufBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<PoufBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].azul[i])
			{
				PoufBehaviour poufBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("PoufAzulPrefab")).AddComponent<PoufBehaviour>();
				array[i] = ((Component)poufBehaviour3).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<PoufBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<PoufBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<PoufBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<PoufBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].raro[i])
			{
				PoufBehaviour poufBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("PoufRaroPrefab")).AddComponent<PoufBehaviour>();
				array[i] = ((Component)poufBehaviour4).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<PoufBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<PoufBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<PoufBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<PoufBehaviour>().raro = saveData.save[0].raro[i];
			}
		}
	}

	private void Load3()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-couchs.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posx.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (saveData.save[0].blanco[i])
			{
				SofaBehaviour sofaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaBlancoPrefab")).AddComponent<SofaBehaviour>();
				array[i] = ((Component)sofaBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SofaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SofaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SofaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SofaBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].verde[i])
			{
				SofaBehaviour sofaBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaVerdePrefab")).AddComponent<SofaBehaviour>();
				array[i] = ((Component)sofaBehaviour2).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SofaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SofaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SofaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SofaBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].azul[i])
			{
				SofaBehaviour sofaBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaAzulPrefab")).AddComponent<SofaBehaviour>();
				array[i] = ((Component)sofaBehaviour3).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SofaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SofaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SofaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SofaBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].raro[i])
			{
				SofaBehaviour sofaBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SofaRaroPrefab")).AddComponent<SofaBehaviour>();
				array[i] = ((Component)sofaBehaviour4).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SofaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SofaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SofaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SofaBehaviour>().raro = saveData.save[0].raro[i];
			}
		}
	}

	private void Load4()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-deskchairs.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posx.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (saveData.save[0].blanco[i])
			{
				SillaBehaviour sillaBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaBlancaPrefab")).AddComponent<SillaBehaviour>();
				array[i] = ((Component)sillaBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SillaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SillaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SillaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SillaBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].verde[i])
			{
				SillaBehaviour sillaBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaVerdePrefab")).AddComponent<SillaBehaviour>();
				array[i] = ((Component)sillaBehaviour2).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SillaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SillaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SillaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SillaBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].azul[i])
			{
				SillaBehaviour sillaBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaAzulPrefab")).AddComponent<SillaBehaviour>();
				array[i] = ((Component)sillaBehaviour3).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SillaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SillaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SillaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SillaBehaviour>().raro = saveData.save[0].raro[i];
			}
			if (saveData.save[0].raro[i])
			{
				SillaBehaviour sillaBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("SillaRaraPrefab")).AddComponent<SillaBehaviour>();
				array[i] = ((Component)sillaBehaviour4).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<SillaBehaviour>().blanco = saveData.save[0].blanco[i];
				array[i].GetComponent<SillaBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<SillaBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<SillaBehaviour>().raro = saveData.save[0].raro[i];
			}
		}
	}

	private void Load5()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-carpets.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posx.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (saveData.save[0].naranja[i])
			{
				AlfombraBehaviour alfombraBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraNaranjaPrefab")).AddComponent<AlfombraBehaviour>();
				array[i] = ((Component)alfombraBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<AlfombraBehaviour>().naranja = saveData.save[0].naranja[i];
				array[i].GetComponent<AlfombraBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<AlfombraBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<AlfombraBehaviour>().rojo = saveData.save[0].rojo[i];
			}
			if (saveData.save[0].verde[i])
			{
				AlfombraBehaviour alfombraBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraVerdePrefab")).AddComponent<AlfombraBehaviour>();
				array[i] = ((Component)alfombraBehaviour2).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<AlfombraBehaviour>().naranja = saveData.save[0].naranja[i];
				array[i].GetComponent<AlfombraBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<AlfombraBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<AlfombraBehaviour>().rojo = saveData.save[0].rojo[i];
			}
			if (saveData.save[0].azul[i])
			{
				AlfombraBehaviour alfombraBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraAzulPrefab")).AddComponent<AlfombraBehaviour>();
				array[i] = ((Component)alfombraBehaviour3).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<AlfombraBehaviour>().naranja = saveData.save[0].naranja[i];
				array[i].GetComponent<AlfombraBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<AlfombraBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<AlfombraBehaviour>().rojo = saveData.save[0].rojo[i];
			}
			if (saveData.save[0].rojo[i])
			{
				AlfombraBehaviour alfombraBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("AlfombraRojaPrefab")).AddComponent<AlfombraBehaviour>();
				array[i] = ((Component)alfombraBehaviour4).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<AlfombraBehaviour>().naranja = saveData.save[0].naranja[i];
				array[i].GetComponent<AlfombraBehaviour>().verde = saveData.save[0].verde[i];
				array[i].GetComponent<AlfombraBehaviour>().azul = saveData.save[0].azul[i];
				array[i].GetComponent<AlfombraBehaviour>().rojo = saveData.save[0].rojo[i];
			}
		}
	}

	private void Load6()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-tables2.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posx.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (saveData.save[0].color1[i])
			{
				Mesa2Behaviour mesa2Behaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa21Prefab")).AddComponent<Mesa2Behaviour>();
				array[i] = ((Component)mesa2Behaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<Mesa2Behaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<Mesa2Behaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<Mesa2Behaviour>().color3 = saveData.save[0].color3[i];
			}
			if (saveData.save[0].color2[i])
			{
				Mesa2Behaviour mesa2Behaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa22Prefab")).AddComponent<Mesa2Behaviour>();
				array[i] = ((Component)mesa2Behaviour2).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<Mesa2Behaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<Mesa2Behaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<Mesa2Behaviour>().color3 = saveData.save[0].color3[i];
			}
			if (saveData.save[0].color3[i])
			{
				Mesa2Behaviour mesa2Behaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Mesa23Prefab")).AddComponent<Mesa2Behaviour>();
				array[i] = ((Component)mesa2Behaviour3).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<Mesa2Behaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<Mesa2Behaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<Mesa2Behaviour>().color3 = saveData.save[0].color3[i];
			}
		}
	}

	private void Load7()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-chairs.save");
		if (saveData == null)
		{
			return;
		}
		GameObject[] array = new GameObject[saveData.save[0].posx.Length];
		for (int i = 0; i < array.Length; i++)
		{
			if (saveData.save[0].color1[i])
			{
				Silla2Behaviour silla2Behaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Silla21Prefab")).AddComponent<Silla2Behaviour>();
				array[i] = ((Component)silla2Behaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<Silla2Behaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<Silla2Behaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<Silla2Behaviour>().color3 = saveData.save[0].color3[i];
			}
			if (saveData.save[0].color2[i])
			{
				Silla2Behaviour silla2Behaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Silla22Prefab")).AddComponent<Silla2Behaviour>();
				array[i] = ((Component)silla2Behaviour2).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<Silla2Behaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<Silla2Behaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<Silla2Behaviour>().color3 = saveData.save[0].color3[i];
			}
			if (saveData.save[0].color3[i])
			{
				Silla2Behaviour silla2Behaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("Silla23Prefab")).AddComponent<Silla2Behaviour>();
				array[i] = ((Component)silla2Behaviour3).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
				array[i].GetComponent<Silla2Behaviour>().color1 = saveData.save[0].color1[i];
				array[i].GetComponent<Silla2Behaviour>().color2 = saveData.save[0].color2[i];
				array[i].GetComponent<Silla2Behaviour>().color3 = saveData.save[0].color3[i];
			}
		}
	}

	private void Load8()
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-nightstands.save");
		if (saveData != null)
		{
			GameObject[] array = new GameObject[saveData.save[0].posx.Length];
			for (int i = 0; i < array.Length; i++)
			{
				NightStandBehaviour nightStandBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("NightStandPrefab")).AddComponent<NightStandBehaviour>();
				array[i] = ((Component)nightStandBehaviour).gameObject;
				array[i].transform.position = new Vector3(saveData.save[0].posx[i], saveData.save[0].posy[i], saveData.save[0].posz[i]);
				array[i].transform.eulerAngles = new Vector3(saveData.save[0].rotx[i], saveData.save[0].roty[i], saveData.save[0].rotz[i]);
			}
		}
	}

	public void PedidoPagado(PedidoPapelBehaviour ped)
	{
		if (ped.compraalfombra)
		{
			CompraCajaAlfombra();
		}
		if (ped.compramesa)
		{
			CompraCajaMesa();
		}
		if (ped.compramesa2)
		{
			CompraCajaMesa2();
		}
		if (ped.compranightstand)
		{
			CompraCajaNightStand();
		}
		if (ped.comprapouf)
		{
			CompraCajaPouf();
		}
		if (ped.comprasilla)
		{
			CompraCajaSilla();
		}
		if (ped.comprasilla2)
		{
			CompraCajaSilla2();
		}
		if (ped.comprasofa)
		{
			CompraCajaSofa();
		}
	}

	private void Update()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameObject.Find("PLAYER") != (Object)null && pedidobuzon && (Object)(object)pedido != (Object)null)
		{
			tiempopedido += Time.deltaTime;
			if (tiempopedido > maxtiempopedido)
			{
				PedidoPapelBehaviour pedidoPapelBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("pedidoespecial")).AddComponent<PedidoPapelBehaviour>();
				pedidoPapelBehaviour.precio = pedido.precio;
				((Component)pedidoPapelBehaviour).transform.SetParent(post.transform);
				((Component)pedidoPapelBehaviour).transform.localPosition = new Vector3(0.338f, 0.849f, 0.743f);
				((Component)pedidoPapelBehaviour).transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				pedidoPapelBehaviour.compraalfombra = pedido.compraalfombra;
				pedidoPapelBehaviour.compramesa = pedido.compramesa;
				pedidoPapelBehaviour.compramesa2 = pedido.compramesa2;
				pedidoPapelBehaviour.compranightstand = pedido.compranightstand;
				pedidoPapelBehaviour.comprapouf = pedido.comprapouf;
				pedidoPapelBehaviour.comprasilla = pedido.comprasilla;
				pedidoPapelBehaviour.comprasilla2 = pedido.comprasilla2;
				pedidoPapelBehaviour.comprasofa = pedido.comprasofa;
				((Component)((Component)this).gameObject.GetComponent<TelefonoBehaviour>().fsm2origi).gameObject.SetActive(true);
				((Component)this).gameObject.GetComponent<TelefonoBehaviour>().fsm2origi.FsmVariables.FindFsmString("Topic").Value = "ORDER";
				Object.Destroy((Object)(object)pedido);
				pedidobuzon = false;
				tiempopedido = 0f;
			}
		}
	}
}
