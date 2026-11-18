import json
from collections import Counter
import UnityPy

BUNDLE = "extracted/newhouse.unity3d"
env = UnityPy.load(BUNDLE)

counts = Counter()
renderers = []
meshes = []
colliders = []
gameobjects = []

for obj in env.objects:
    t = obj.type.name
    counts[t] += 1
    try:
        if t == "GameObject":
            d = obj.parse_as_object()
            gameobjects.append({"path_id": obj.path_id, "name": d.m_Name,
                                "components": [str(x.path_id) for x in d.m_Components]})
        elif t in ("MeshRenderer", "SkinnedMeshRenderer"):
            d = obj.parse_as_object()
            go = getattr(d, "m_GameObject", None)
            renderers.append({
                "path_id": obj.path_id, "type": t,
                "gameobject_path_id": getattr(go, "path_id", None),
                "cast_shadows": getattr(d, "m_CastShadows", None),
                "receive_shadows": getattr(d, "m_ReceiveShadows", None),
                "enabled": getattr(d, "m_Enabled", None),
                "materials": len(getattr(d, "m_Materials", []) or [])
            })
        elif t == "Mesh":
            d = obj.parse_as_object()
            meshes.append({"path_id": obj.path_id, "name": getattr(d, "m_Name", ""),
                           "vertex_count": getattr(d, "m_VertexCount", None),
                           "submeshes": len(getattr(d, "m_SubMeshes", []) or [])})
        elif t.endswith("Collider"):
            d = obj.parse_as_object()
            go = getattr(d, "m_GameObject", None)
            colliders.append({"path_id": obj.path_id, "type": t,
                              "gameobject_path_id": getattr(go, "path_id", None),
                              "enabled": getattr(d, "m_Enabled", None)})
    except Exception as e:
        print("PARSE_WARNING", t, obj.path_id, repr(e))

go_by_id = {g["path_id"]: g["name"] for g in gameobjects}
for r in renderers:
    r["gameobject_name"] = go_by_id.get(r["gameobject_path_id"], "")
for c in colliders:
    c["gameobject_name"] = go_by_id.get(c["gameobject_path_id"], "")

report = {
    "object_counts": dict(counts),
    "renderer_count": len(renderers),
    "renderer_shadow_counts": dict(Counter((str(r["cast_shadows"]), str(r["receive_shadows"])) for r in renderers)),
    "mesh_count": len(meshes),
    "mesh_vertex_total": sum(m["vertex_count"] or 0 for m in meshes),
    "collider_count": len(colliders),
    "renderers": renderers,
    "meshes": meshes,
    "colliders": colliders,
    "gameobjects": gameobjects
}
with open("newhouse-asset-report.json", "w", encoding="utf-8") as f:
    json.dump(report, f, ensure_ascii=False, indent=2)
print("OBJECT_COUNTS", json.dumps(dict(counts), ensure_ascii=False))
print("RENDERER_SHADOW_COUNTS", json.dumps(report["renderer_shadow_counts"]))
print("TOTAL_MESH_VERTICES", report["mesh_vertex_total"])
print("GAMEOBJECTS", len(gameobjects), "RENDERERS", len(renderers), "COLLIDERS", len(colliders))
