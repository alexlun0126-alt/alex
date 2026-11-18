using HutongGames.PlayMaker;
using UnityEngine;

namespace NewHouse;

public class BolsaNewBehaviour : MonoBehaviour
{
	public bool spawneado;

	public int cantidadchuleta;

	private FsmBool m_guiUseBool;

	private void Start()
	{
		((Object)((Component)this).gameObject).name = "Shopping Bag(Clone)";
		((Component)this).gameObject.layer = LayerMask.NameToLayer("Parts");
		((Component)this).gameObject.tag = "PART";
		m_guiUseBool = PlayMakerGlobals.Instance.Variables.FindFsmBool("GUIuse");
	}

	private void Update()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1009: Unknown result type (might be due to invalid IL or missing references)
		//IL_100e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1016: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1036: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_106e: Unknown result type (might be due to invalid IL or missing references)
		//IL_107d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Unknown result type (might be due to invalid IL or missing references)
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Unknown result type (might be due to invalid IL or missing references)
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1162: Unknown result type (might be due to invalid IL or missing references)
		//IL_1167: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176: Unknown result type (might be due to invalid IL or missing references)
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_1208: Unknown result type (might be due to invalid IL or missing references)
		//IL_120d: Unknown result type (might be due to invalid IL or missing references)
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Unknown result type (might be due to invalid IL or missing references)
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_1315: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		if (!((Object)(object)GameObject.Find("PLAYER") != (Object)null) || !Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), ref val, 1f) || !((Object)(object)((Component)val.collider).gameObject == (Object)(object)((Component)this).gameObject))
		{
			return;
		}
		m_guiUseBool.Value = true;
		if (cInput.GetButtonDown("Use"))
		{
			if (cantidadchuleta == 0)
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 1)
			{
				FileteBehaviour fileteBehaviour = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position = ((Component)this).transform.position;
				Quaternion rotation = ((Component)this).transform.rotation;
				fileteBehaviour.spawned = true;
				((Component)fileteBehaviour).transform.position = position;
				((Component)fileteBehaviour).transform.rotation = rotation;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 2)
			{
				FileteBehaviour fileteBehaviour2 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position2 = ((Component)this).transform.position;
				Quaternion rotation2 = ((Component)this).transform.rotation;
				fileteBehaviour2.spawned = true;
				((Component)fileteBehaviour2).transform.position = position2;
				((Component)fileteBehaviour2).transform.rotation = rotation2;
				FileteBehaviour fileteBehaviour3 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position3 = ((Component)this).transform.position;
				Quaternion rotation3 = ((Component)this).transform.rotation;
				fileteBehaviour3.spawned = true;
				((Component)fileteBehaviour3).transform.position = position3;
				((Component)fileteBehaviour3).transform.rotation = rotation3;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 3)
			{
				FileteBehaviour fileteBehaviour4 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position4 = ((Component)this).transform.position;
				Quaternion rotation4 = ((Component)this).transform.rotation;
				fileteBehaviour4.spawned = true;
				((Component)fileteBehaviour4).transform.position = position4;
				((Component)fileteBehaviour4).transform.rotation = rotation4;
				FileteBehaviour fileteBehaviour5 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position5 = ((Component)this).transform.position;
				Quaternion rotation5 = ((Component)this).transform.rotation;
				fileteBehaviour5.spawned = true;
				((Component)fileteBehaviour5).transform.position = position5;
				((Component)fileteBehaviour5).transform.rotation = rotation5;
				FileteBehaviour fileteBehaviour6 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position6 = ((Component)this).transform.position;
				Quaternion rotation6 = ((Component)this).transform.rotation;
				fileteBehaviour6.spawned = true;
				((Component)fileteBehaviour6).transform.position = position6;
				((Component)fileteBehaviour6).transform.rotation = rotation6;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 4)
			{
				FileteBehaviour fileteBehaviour7 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position7 = ((Component)this).transform.position;
				Quaternion rotation7 = ((Component)this).transform.rotation;
				fileteBehaviour7.spawned = true;
				((Component)fileteBehaviour7).transform.position = position7;
				((Component)fileteBehaviour7).transform.rotation = rotation7;
				FileteBehaviour fileteBehaviour8 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position8 = ((Component)this).transform.position;
				Quaternion rotation8 = ((Component)this).transform.rotation;
				fileteBehaviour8.spawned = true;
				((Component)fileteBehaviour8).transform.position = position8;
				((Component)fileteBehaviour8).transform.rotation = rotation8;
				FileteBehaviour fileteBehaviour9 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position9 = ((Component)this).transform.position;
				Quaternion rotation9 = ((Component)this).transform.rotation;
				fileteBehaviour9.spawned = true;
				((Component)fileteBehaviour9).transform.position = position9;
				((Component)fileteBehaviour9).transform.rotation = rotation9;
				FileteBehaviour fileteBehaviour10 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position10 = ((Component)this).transform.position;
				Quaternion rotation10 = ((Component)this).transform.rotation;
				fileteBehaviour10.spawned = true;
				((Component)fileteBehaviour10).transform.position = position10;
				((Component)fileteBehaviour10).transform.rotation = rotation10;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 5)
			{
				FileteBehaviour fileteBehaviour11 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position11 = ((Component)this).transform.position;
				Quaternion rotation11 = ((Component)this).transform.rotation;
				fileteBehaviour11.spawned = true;
				((Component)fileteBehaviour11).transform.position = position11;
				((Component)fileteBehaviour11).transform.rotation = rotation11;
				FileteBehaviour fileteBehaviour12 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position12 = ((Component)this).transform.position;
				Quaternion rotation12 = ((Component)this).transform.rotation;
				fileteBehaviour12.spawned = true;
				((Component)fileteBehaviour12).transform.position = position12;
				((Component)fileteBehaviour12).transform.rotation = rotation12;
				FileteBehaviour fileteBehaviour13 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position13 = ((Component)this).transform.position;
				Quaternion rotation13 = ((Component)this).transform.rotation;
				fileteBehaviour13.spawned = true;
				((Component)fileteBehaviour13).transform.position = position13;
				((Component)fileteBehaviour13).transform.rotation = rotation13;
				FileteBehaviour fileteBehaviour14 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position14 = ((Component)this).transform.position;
				Quaternion rotation14 = ((Component)this).transform.rotation;
				fileteBehaviour14.spawned = true;
				((Component)fileteBehaviour14).transform.position = position14;
				((Component)fileteBehaviour14).transform.rotation = rotation14;
				FileteBehaviour fileteBehaviour15 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position15 = ((Component)this).transform.position;
				Quaternion rotation15 = ((Component)this).transform.rotation;
				fileteBehaviour15.spawned = true;
				((Component)fileteBehaviour15).transform.position = position15;
				((Component)fileteBehaviour15).transform.rotation = rotation15;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 6)
			{
				FileteBehaviour fileteBehaviour16 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position16 = ((Component)this).transform.position;
				Quaternion rotation16 = ((Component)this).transform.rotation;
				fileteBehaviour16.spawned = true;
				((Component)fileteBehaviour16).transform.position = position16;
				((Component)fileteBehaviour16).transform.rotation = rotation16;
				FileteBehaviour fileteBehaviour17 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position17 = ((Component)this).transform.position;
				Quaternion rotation17 = ((Component)this).transform.rotation;
				fileteBehaviour17.spawned = true;
				((Component)fileteBehaviour17).transform.position = position17;
				((Component)fileteBehaviour17).transform.rotation = rotation17;
				FileteBehaviour fileteBehaviour18 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position18 = ((Component)this).transform.position;
				Quaternion rotation18 = ((Component)this).transform.rotation;
				fileteBehaviour18.spawned = true;
				((Component)fileteBehaviour18).transform.position = position18;
				((Component)fileteBehaviour18).transform.rotation = rotation18;
				FileteBehaviour fileteBehaviour19 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position19 = ((Component)this).transform.position;
				Quaternion rotation19 = ((Component)this).transform.rotation;
				fileteBehaviour19.spawned = true;
				((Component)fileteBehaviour19).transform.position = position19;
				((Component)fileteBehaviour19).transform.rotation = rotation19;
				FileteBehaviour fileteBehaviour20 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position20 = ((Component)this).transform.position;
				Quaternion rotation20 = ((Component)this).transform.rotation;
				fileteBehaviour20.spawned = true;
				((Component)fileteBehaviour20).transform.position = position20;
				((Component)fileteBehaviour20).transform.rotation = rotation20;
				FileteBehaviour fileteBehaviour21 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position21 = ((Component)this).transform.position;
				Quaternion rotation21 = ((Component)this).transform.rotation;
				fileteBehaviour21.spawned = true;
				((Component)fileteBehaviour21).transform.position = position21;
				((Component)fileteBehaviour21).transform.rotation = rotation21;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 7)
			{
				FileteBehaviour fileteBehaviour22 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position22 = ((Component)this).transform.position;
				Quaternion rotation22 = ((Component)this).transform.rotation;
				fileteBehaviour22.spawned = true;
				((Component)fileteBehaviour22).transform.position = position22;
				((Component)fileteBehaviour22).transform.rotation = rotation22;
				FileteBehaviour fileteBehaviour23 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position23 = ((Component)this).transform.position;
				Quaternion rotation23 = ((Component)this).transform.rotation;
				fileteBehaviour23.spawned = true;
				((Component)fileteBehaviour23).transform.position = position23;
				((Component)fileteBehaviour23).transform.rotation = rotation23;
				FileteBehaviour fileteBehaviour24 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position24 = ((Component)this).transform.position;
				Quaternion rotation24 = ((Component)this).transform.rotation;
				fileteBehaviour24.spawned = true;
				((Component)fileteBehaviour24).transform.position = position24;
				((Component)fileteBehaviour24).transform.rotation = rotation24;
				FileteBehaviour fileteBehaviour25 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position25 = ((Component)this).transform.position;
				Quaternion rotation25 = ((Component)this).transform.rotation;
				fileteBehaviour25.spawned = true;
				((Component)fileteBehaviour25).transform.position = position25;
				((Component)fileteBehaviour25).transform.rotation = rotation25;
				FileteBehaviour fileteBehaviour26 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position26 = ((Component)this).transform.position;
				Quaternion rotation26 = ((Component)this).transform.rotation;
				fileteBehaviour26.spawned = true;
				((Component)fileteBehaviour26).transform.position = position26;
				((Component)fileteBehaviour26).transform.rotation = rotation26;
				FileteBehaviour fileteBehaviour27 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position27 = ((Component)this).transform.position;
				Quaternion rotation27 = ((Component)this).transform.rotation;
				fileteBehaviour27.spawned = true;
				((Component)fileteBehaviour27).transform.position = position27;
				((Component)fileteBehaviour27).transform.rotation = rotation27;
				FileteBehaviour fileteBehaviour28 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position28 = ((Component)this).transform.position;
				Quaternion rotation28 = ((Component)this).transform.rotation;
				fileteBehaviour28.spawned = true;
				((Component)fileteBehaviour28).transform.position = position28;
				((Component)fileteBehaviour28).transform.rotation = rotation28;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 8)
			{
				FileteBehaviour fileteBehaviour29 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position29 = ((Component)this).transform.position;
				Quaternion rotation29 = ((Component)this).transform.rotation;
				fileteBehaviour29.spawned = true;
				((Component)fileteBehaviour29).transform.position = position29;
				((Component)fileteBehaviour29).transform.rotation = rotation29;
				FileteBehaviour fileteBehaviour30 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position30 = ((Component)this).transform.position;
				Quaternion rotation30 = ((Component)this).transform.rotation;
				fileteBehaviour30.spawned = true;
				((Component)fileteBehaviour30).transform.position = position30;
				((Component)fileteBehaviour30).transform.rotation = rotation30;
				FileteBehaviour fileteBehaviour31 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position31 = ((Component)this).transform.position;
				Quaternion rotation31 = ((Component)this).transform.rotation;
				fileteBehaviour31.spawned = true;
				((Component)fileteBehaviour31).transform.position = position31;
				((Component)fileteBehaviour31).transform.rotation = rotation31;
				FileteBehaviour fileteBehaviour32 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position32 = ((Component)this).transform.position;
				Quaternion rotation32 = ((Component)this).transform.rotation;
				fileteBehaviour32.spawned = true;
				((Component)fileteBehaviour32).transform.position = position32;
				((Component)fileteBehaviour32).transform.rotation = rotation32;
				FileteBehaviour fileteBehaviour33 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position33 = ((Component)this).transform.position;
				Quaternion rotation33 = ((Component)this).transform.rotation;
				fileteBehaviour33.spawned = true;
				((Component)fileteBehaviour33).transform.position = position33;
				((Component)fileteBehaviour33).transform.rotation = rotation33;
				FileteBehaviour fileteBehaviour34 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position34 = ((Component)this).transform.position;
				Quaternion rotation34 = ((Component)this).transform.rotation;
				fileteBehaviour34.spawned = true;
				((Component)fileteBehaviour34).transform.position = position34;
				((Component)fileteBehaviour34).transform.rotation = rotation34;
				FileteBehaviour fileteBehaviour35 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position35 = ((Component)this).transform.position;
				Quaternion rotation35 = ((Component)this).transform.rotation;
				fileteBehaviour35.spawned = true;
				((Component)fileteBehaviour35).transform.position = position35;
				((Component)fileteBehaviour35).transform.rotation = rotation35;
				FileteBehaviour fileteBehaviour36 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position36 = ((Component)this).transform.position;
				Quaternion rotation36 = ((Component)this).transform.rotation;
				fileteBehaviour36.spawned = true;
				((Component)fileteBehaviour36).transform.position = position36;
				((Component)fileteBehaviour36).transform.rotation = rotation36;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 9)
			{
				FileteBehaviour fileteBehaviour37 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position37 = ((Component)this).transform.position;
				Quaternion rotation37 = ((Component)this).transform.rotation;
				fileteBehaviour37.spawned = true;
				((Component)fileteBehaviour37).transform.position = position37;
				((Component)fileteBehaviour37).transform.rotation = rotation37;
				FileteBehaviour fileteBehaviour38 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position38 = ((Component)this).transform.position;
				Quaternion rotation38 = ((Component)this).transform.rotation;
				fileteBehaviour38.spawned = true;
				((Component)fileteBehaviour38).transform.position = position38;
				((Component)fileteBehaviour38).transform.rotation = rotation38;
				FileteBehaviour fileteBehaviour39 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position39 = ((Component)this).transform.position;
				Quaternion rotation39 = ((Component)this).transform.rotation;
				fileteBehaviour39.spawned = true;
				((Component)fileteBehaviour39).transform.position = position39;
				((Component)fileteBehaviour39).transform.rotation = rotation39;
				FileteBehaviour fileteBehaviour40 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position40 = ((Component)this).transform.position;
				Quaternion rotation40 = ((Component)this).transform.rotation;
				fileteBehaviour40.spawned = true;
				((Component)fileteBehaviour40).transform.position = position40;
				((Component)fileteBehaviour40).transform.rotation = rotation40;
				FileteBehaviour fileteBehaviour41 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position41 = ((Component)this).transform.position;
				Quaternion rotation41 = ((Component)this).transform.rotation;
				fileteBehaviour41.spawned = true;
				((Component)fileteBehaviour41).transform.position = position41;
				((Component)fileteBehaviour41).transform.rotation = rotation41;
				FileteBehaviour fileteBehaviour42 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position42 = ((Component)this).transform.position;
				Quaternion rotation42 = ((Component)this).transform.rotation;
				fileteBehaviour42.spawned = true;
				((Component)fileteBehaviour42).transform.position = position42;
				((Component)fileteBehaviour42).transform.rotation = rotation42;
				FileteBehaviour fileteBehaviour43 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position43 = ((Component)this).transform.position;
				Quaternion rotation43 = ((Component)this).transform.rotation;
				fileteBehaviour43.spawned = true;
				((Component)fileteBehaviour43).transform.position = position43;
				((Component)fileteBehaviour43).transform.rotation = rotation43;
				FileteBehaviour fileteBehaviour44 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position44 = ((Component)this).transform.position;
				Quaternion rotation44 = ((Component)this).transform.rotation;
				fileteBehaviour44.spawned = true;
				((Component)fileteBehaviour44).transform.position = position44;
				((Component)fileteBehaviour44).transform.rotation = rotation44;
				FileteBehaviour fileteBehaviour45 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position45 = ((Component)this).transform.position;
				Quaternion rotation45 = ((Component)this).transform.rotation;
				fileteBehaviour45.spawned = true;
				((Component)fileteBehaviour45).transform.position = position45;
				((Component)fileteBehaviour45).transform.rotation = rotation45;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			if (cantidadchuleta == 10)
			{
				FileteBehaviour fileteBehaviour46 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position46 = ((Component)this).transform.position;
				Quaternion rotation46 = ((Component)this).transform.rotation;
				fileteBehaviour46.spawned = true;
				((Component)fileteBehaviour46).transform.position = position46;
				((Component)fileteBehaviour46).transform.rotation = rotation46;
				FileteBehaviour fileteBehaviour47 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position47 = ((Component)this).transform.position;
				Quaternion rotation47 = ((Component)this).transform.rotation;
				fileteBehaviour47.spawned = true;
				((Component)fileteBehaviour47).transform.position = position47;
				((Component)fileteBehaviour47).transform.rotation = rotation47;
				FileteBehaviour fileteBehaviour48 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position48 = ((Component)this).transform.position;
				Quaternion rotation48 = ((Component)this).transform.rotation;
				fileteBehaviour48.spawned = true;
				((Component)fileteBehaviour48).transform.position = position48;
				((Component)fileteBehaviour48).transform.rotation = rotation48;
				FileteBehaviour fileteBehaviour49 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position49 = ((Component)this).transform.position;
				Quaternion rotation49 = ((Component)this).transform.rotation;
				fileteBehaviour49.spawned = true;
				((Component)fileteBehaviour49).transform.position = position49;
				((Component)fileteBehaviour49).transform.rotation = rotation49;
				FileteBehaviour fileteBehaviour50 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position50 = ((Component)this).transform.position;
				Quaternion rotation50 = ((Component)this).transform.rotation;
				fileteBehaviour50.spawned = true;
				((Component)fileteBehaviour50).transform.position = position50;
				((Component)fileteBehaviour50).transform.rotation = rotation50;
				FileteBehaviour fileteBehaviour51 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position51 = ((Component)this).transform.position;
				Quaternion rotation51 = ((Component)this).transform.rotation;
				fileteBehaviour51.spawned = true;
				((Component)fileteBehaviour51).transform.position = position51;
				((Component)fileteBehaviour51).transform.rotation = rotation51;
				FileteBehaviour fileteBehaviour52 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position52 = ((Component)this).transform.position;
				Quaternion rotation52 = ((Component)this).transform.rotation;
				fileteBehaviour52.spawned = true;
				((Component)fileteBehaviour52).transform.position = position52;
				((Component)fileteBehaviour52).transform.rotation = rotation52;
				FileteBehaviour fileteBehaviour53 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position53 = ((Component)this).transform.position;
				Quaternion rotation53 = ((Component)this).transform.rotation;
				fileteBehaviour53.spawned = true;
				((Component)fileteBehaviour53).transform.position = position53;
				((Component)fileteBehaviour53).transform.rotation = rotation53;
				FileteBehaviour fileteBehaviour54 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position54 = ((Component)this).transform.position;
				Quaternion rotation54 = ((Component)this).transform.rotation;
				fileteBehaviour54.spawned = true;
				((Component)fileteBehaviour54).transform.position = position54;
				((Component)fileteBehaviour54).transform.rotation = rotation54;
				FileteBehaviour fileteBehaviour55 = Object.Instantiate<GameObject>(ModBehaviour.m_bundle.LoadAsset<GameObject>("chuleta")).AddComponent<FileteBehaviour>();
				Vector3 position55 = ((Component)this).transform.position;
				Quaternion rotation55 = ((Component)this).transform.rotation;
				fileteBehaviour55.spawned = true;
				((Component)fileteBehaviour55).transform.position = position55;
				((Component)fileteBehaviour55).transform.rotation = rotation55;
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
	}
}
