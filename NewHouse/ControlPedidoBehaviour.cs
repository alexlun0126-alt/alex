using System.Collections.Generic;
using MSCLoader;
using UnityEngine;

namespace NewHouse;

public class ControlPedidoBehaviour : MonoBehaviour
{
	public class SaveData
	{
		public List<SaveDataList> save = new List<SaveDataList>();
	}

	public class SaveDataList
	{
		public bool compramesa;

		public bool compramesa2;

		public bool comprasilla;

		public bool comprasilla2;

		public bool comprasofa;

		public bool comprapouf;

		public bool compraalfombra;

		public bool compranightstand;

		public float precio;

		public float posX;

		public float posY;

		public float posZ;

		public float rotX;

		public float rotY;

		public float rotZ;

		public bool pedidobuzon;

		public float tiempopedido;

		public bool aycarta;
	}

	private CompraObjetosBehaviour compras;

	private void Start()
	{
		Load();
	}

	public void Save()
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		compras = Object.FindObjectOfType<CompraObjetosBehaviour>();
		SaveData saveData = new SaveData();
		if ((Object)(object)compras.pedido != (Object)null)
		{
			PedidoBehaviour pedido = compras.pedido;
			SaveDataList item = new SaveDataList
			{
				compramesa = pedido.compramesa,
				compramesa2 = pedido.compramesa2,
				comprasilla = pedido.comprasilla,
				comprasilla2 = pedido.comprasilla2,
				comprasofa = pedido.comprasofa,
				comprapouf = pedido.comprapouf,
				compraalfombra = pedido.compraalfombra,
				compranightstand = pedido.compranightstand,
				posX = ((Component)pedido).transform.position.x,
				posY = ((Component)pedido).transform.position.y,
				posZ = ((Component)pedido).transform.position.z,
				rotX = ((Component)pedido).transform.eulerAngles.x,
				rotY = ((Component)pedido).transform.eulerAngles.y,
				rotZ = ((Component)pedido).transform.eulerAngles.z,
				precio = pedido.precio,
				pedidobuzon = compras.pedidobuzon,
				tiempopedido = compras.tiempopedido,
				aycarta = true
			};
			saveData.save.Add(item);
		}
		if ((Object)(object)compras.pedido == (Object)null)
		{
			if ((Object)(object)Object.FindObjectOfType<PedidoPapelBehaviour>() != (Object)null)
			{
				PedidoPapelBehaviour pedidoPapelBehaviour = Object.FindObjectOfType<PedidoPapelBehaviour>();
				SaveDataList item2 = new SaveDataList
				{
					precio = pedidoPapelBehaviour.precio,
					compramesa = pedidoPapelBehaviour.compramesa,
					compramesa2 = pedidoPapelBehaviour.compramesa2,
					comprasilla = pedidoPapelBehaviour.comprasilla,
					comprasilla2 = pedidoPapelBehaviour.comprasilla2,
					comprasofa = pedidoPapelBehaviour.comprasofa,
					comprapouf = pedidoPapelBehaviour.comprapouf,
					compraalfombra = pedidoPapelBehaviour.compraalfombra,
					compranightstand = pedidoPapelBehaviour.compranightstand,
					pedidobuzon = compras.pedidobuzon,
					tiempopedido = compras.tiempopedido,
					aycarta = false
				};
				saveData.save.Add(item2);
			}
			if ((Object)(object)Object.FindObjectOfType<PedidoPapelBehaviour>() == (Object)null)
			{
				SaveDataList item3 = new SaveDataList
				{
					aycarta = false
				};
				saveData.save.Add(item3);
			}
		}
		SaveLoad.SerializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, saveData, "NewHouse-order.save");
	}

	private void Load()
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		SaveData saveData = SaveLoad.DeserializeSaveFile<SaveData>((Mod)(object)NewHouse.Instance, "NewHouse-order.save");
		if (saveData == null)
		{
			return;
		}
		compras = Object.FindObjectOfType<CompraObjetosBehaviour>();
		compras.pedidobuzon = saveData.save[0].pedidobuzon;
		compras.tiempopedido = saveData.save[0].tiempopedido;
		if (saveData.save[0].pedidobuzon)
		{
			compras.pedido = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("PedidoPrefab")).AddComponent<PedidoBehaviour>();
			((Component)compras.pedido).transform.position = new Vector3(saveData.save[0].posX, saveData.save[0].posY, saveData.save[0].posZ);
			compras.pedido.compramesa = saveData.save[0].compramesa;
			compras.pedido.compramesa2 = saveData.save[0].compramesa2;
			compras.pedido.comprasilla = saveData.save[0].comprasilla;
			compras.pedido.comprasilla2 = saveData.save[0].comprasilla2;
			compras.pedido.comprapouf = saveData.save[0].comprapouf;
			compras.pedido.comprasofa = saveData.save[0].comprasofa;
			compras.pedido.compranightstand = saveData.save[0].compranightstand;
			compras.pedido.compraalfombra = saveData.save[0].compraalfombra;
			compras.pedido.precio = saveData.save[0].precio;
			((Component)compras.pedido).gameObject.SetActive(false);
		}
		if (!saveData.save[0].pedidobuzon)
		{
			if (saveData.save[0].aycarta)
			{
				compras.pedido = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("PedidoPrefab")).AddComponent<PedidoBehaviour>();
				((Component)compras.pedido).transform.position = new Vector3(saveData.save[0].posX, saveData.save[0].posY, saveData.save[0].posZ);
				((Component)compras.pedido).transform.eulerAngles = new Vector3(saveData.save[0].rotX, saveData.save[0].rotY, saveData.save[0].rotZ);
				compras.pedido.compramesa = saveData.save[0].compramesa;
				compras.pedido.compramesa2 = saveData.save[0].compramesa2;
				compras.pedido.comprasilla = saveData.save[0].comprasilla;
				compras.pedido.comprasilla2 = saveData.save[0].comprasilla2;
				compras.pedido.comprapouf = saveData.save[0].comprapouf;
				compras.pedido.comprasofa = saveData.save[0].comprasofa;
				compras.pedido.compranightstand = saveData.save[0].compranightstand;
				compras.pedido.compraalfombra = saveData.save[0].compraalfombra;
				compras.pedido.precio = saveData.save[0].precio;
			}
			if (saveData.save[0].precio > 0f && !saveData.save[0].aycarta)
			{
				PedidoPapelBehaviour pedidoPapelBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("pedidoespecial")).AddComponent<PedidoPapelBehaviour>();
				GameObject gameObject = GameObject.Find("STORE/LOD/Post/PostOffice").gameObject;
				((Component)pedidoPapelBehaviour).transform.SetParent(gameObject.transform);
				((Component)pedidoPapelBehaviour).transform.localPosition = new Vector3(0.338f, 0.849f, 0.743f);
				((Component)pedidoPapelBehaviour).transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				pedidoPapelBehaviour.precio = saveData.save[0].precio;
				pedidoPapelBehaviour.compramesa = saveData.save[0].compramesa;
				pedidoPapelBehaviour.compramesa2 = saveData.save[0].compramesa2;
				pedidoPapelBehaviour.comprasilla = saveData.save[0].comprasilla;
				pedidoPapelBehaviour.comprasilla2 = saveData.save[0].comprasilla2;
				pedidoPapelBehaviour.comprapouf = saveData.save[0].comprapouf;
				pedidoPapelBehaviour.comprasofa = saveData.save[0].comprasofa;
				pedidoPapelBehaviour.compranightstand = saveData.save[0].compranightstand;
				pedidoPapelBehaviour.compraalfombra = saveData.save[0].compraalfombra;
			}
		}
	}

	private void Update()
	{
	}
}
