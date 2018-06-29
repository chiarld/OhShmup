template <typename T> void RegisterClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_CloudWebServices();
	RegisterModule_CloudWebServices();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_PerformanceReporting();
	RegisterModule_PerformanceReporting();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_TLS();
	RegisterModule_TLS();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

}

class EditorExtension; template <> void RegisterClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterClass<Behaviour>(const char*);
class Animation; 
class Animator; template <> void RegisterClass<Animator>(const char*);
class AudioBehaviour; template <> void RegisterClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterClass<AudioListener>(const char*);
class AudioSource; template <> void RegisterClass<AudioSource>(const char*);
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterClass<UI::CanvasGroup>(const char*);
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterClass<Collider2D>(const char*);
class BoxCollider2D; template <> void RegisterClass<BoxCollider2D>(const char*);
class CapsuleCollider2D; 
class CircleCollider2D; 
class CompositeCollider2D; 
class EdgeCollider2D; template <> void RegisterClass<EdgeCollider2D>(const char*);
class PolygonCollider2D; 
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; template <> void RegisterClass<FlareLayer>(const char*);
class GUIElement; template <> void RegisterClass<GUIElement>(const char*);
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterClass<GUILayer>(const char*);
class GridLayout; 
class Grid; 
class Tilemap; 
class Halo; 
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; 
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterClass<MonoBehaviour>(const char*);
class NavMeshAgent; 
class NavMeshObstacle; 
class OffMeshLink; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; 
class Skybox; 
class SortingGroup; template <> void RegisterClass<SortingGroup>(const char*);
class Terrain; 
class VideoPlayer; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterClass<UI::CanvasRenderer>(const char*);
class Collider; 
class BoxCollider; 
class CapsuleCollider; 
class CharacterController; 
class MeshCollider; 
class SphereCollider; 
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleAnimator; 
class ParticleEmitter; 
class EllipsoidParticleEmitter; 
class MeshParticleEmitter; 
class ParticleSystem; 
class Renderer; template <> void RegisterClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; 
class MeshRenderer; template <> void RegisterClass<MeshRenderer>(const char*);
class ParticleRenderer; 
class ParticleSystemRenderer; 
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; template <> void RegisterClass<SpriteRenderer>(const char*);
class SpriteShapeRenderer; 
class TilemapRenderer; 
class TrailRenderer; 
class Rigidbody; 
class Rigidbody2D; template <> void RegisterClass<Rigidbody2D>(const char*);
namespace TextRenderingPrivate { class TextMesh; } 
class Transform; template <> void RegisterClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterClass<UI::RectTransform>(const char*);
class Tree; 
class WorldParticleCollider; 
class GameObject; template <> void RegisterClass<GameObject>(const char*);
class NamedObject; template <> void RegisterClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class AssetImporterLog; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; 
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterClass<TextRendering::Font>(const char*);
class GameObjectRecorder; 
class LightProbes; 
class Material; template <> void RegisterClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterClass<Mesh>(const char*);
class Motion; 
class AnimationClip; 
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterClass<PreloadData>(const char*);
class RuntimeAnimatorController; template <> void RegisterClass<RuntimeAnimatorController>(const char*);
class AnimatorController; 
class AnimatorOverrideController; template <> void RegisterClass<AnimatorOverrideController>(const char*);
class SampleClip; template <> void RegisterClass<SampleClip>(const char*);
class AudioClip; template <> void RegisterClass<AudioClip>(const char*);
class Shader; template <> void RegisterClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterClass<Sprite>(const char*);
class SpriteAtlas; 
class SubstanceArchive; 
class TerrainData; 
class TextAsset; template <> void RegisterClass<TextAsset>(const char*);
class CGProgram; 
class MonoScript; template <> void RegisterClass<MonoScript>(const char*);
class Texture; template <> void RegisterClass<Texture>(const char*);
class BaseVideoTexture; 
class WebCamTexture; 
class CubemapArray; 
class LowerResBlitTexture; template <> void RegisterClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterClass<Texture3D>(const char*);
class VideoClip; 
class GameManager; template <> void RegisterClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterClass<BuildSettings>(const char*);
class CloudWebServicesManager; template <> void RegisterClass<CloudWebServicesManager>(const char*);
class CrashReportManager; 
class DelayedCallManager; template <> void RegisterClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterClass<InputManager>(const char*);
class MonoManager; template <> void RegisterClass<MonoManager>(const char*);
class NavMeshProjectSettings; 
class PerformanceReportingManager; template <> void RegisterClass<PerformanceReportingManager>(const char*);
class Physics2DSettings; template <> void RegisterClass<Physics2DSettings>(const char*);
class PhysicsManager; 
class PlayerSettings; template <> void RegisterClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterClass<ScriptMapper>(const char*);
class TagManager; template <> void RegisterClass<TagManager>(const char*);
class TimeManager; template <> void RegisterClass<TimeManager>(const char*);
class UnityAnalyticsManager; template <> void RegisterClass<UnityAnalyticsManager>(const char*);
class UnityConnectSettings; template <> void RegisterClass<UnityConnectSettings>(const char*);
class LevelGameManager; template <> void RegisterClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterClass<LightmapSettings>(const char*);
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterClass<RenderSettings>(const char*);
class RenderPassAttachment; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 72 non stripped classes
	//0. AudioClip
	RegisterClass<AudioClip>("Audio");
	//1. SampleClip
	RegisterClass<SampleClip>("Audio");
	//2. NamedObject
	RegisterClass<NamedObject>("Core");
	//3. EditorExtension
	RegisterClass<EditorExtension>("Core");
	//4. AudioListener
	RegisterClass<AudioListener>("Audio");
	//5. AudioBehaviour
	RegisterClass<AudioBehaviour>("Audio");
	//6. Behaviour
	RegisterClass<Behaviour>("Core");
	//7. Unity::Component
	RegisterClass<Unity::Component>("Core");
	//8. AudioSource
	RegisterClass<AudioSource>("Audio");
	//9. Camera
	RegisterClass<Camera>("Core");
	//10. Renderer
	RegisterClass<Renderer>("Core");
	//11. Shader
	RegisterClass<Shader>("Core");
	//12. Mesh
	RegisterClass<Mesh>("Core");
	//13. MonoBehaviour
	RegisterClass<MonoBehaviour>("Core");
	//14. Material
	RegisterClass<Material>("Core");
	//15. Texture
	RegisterClass<Texture>("Core");
	//16. Texture2D
	RegisterClass<Texture2D>("Core");
	//17. RenderTexture
	RegisterClass<RenderTexture>("Core");
	//18. Sprite
	RegisterClass<Sprite>("Core");
	//19. GameObject
	RegisterClass<GameObject>("Core");
	//20. GUIElement
	RegisterClass<GUIElement>("Core");
	//21. GUILayer
	RegisterClass<GUILayer>("Core");
	//22. Transform
	RegisterClass<Transform>("Core");
	//23. UI::RectTransform
	RegisterClass<UI::RectTransform>("Core");
	//24. Rigidbody2D
	RegisterClass<Rigidbody2D>("Physics2D");
	//25. BoxCollider2D
	RegisterClass<BoxCollider2D>("Physics2D");
	//26. Collider2D
	RegisterClass<Collider2D>("Physics2D");
	//27. Animator
	RegisterClass<Animator>("Animation");
	//28. AnimatorOverrideController
	RegisterClass<AnimatorOverrideController>("Animation");
	//29. RuntimeAnimatorController
	RegisterClass<RuntimeAnimatorController>("Animation");
	//30. TextRendering::Font
	RegisterClass<TextRendering::Font>("TextRendering");
	//31. UI::Canvas
	RegisterClass<UI::Canvas>("UI");
	//32. UI::CanvasGroup
	RegisterClass<UI::CanvasGroup>("UI");
	//33. UI::CanvasRenderer
	RegisterClass<UI::CanvasRenderer>("UI");
	//34. PreloadData
	RegisterClass<PreloadData>("Core");
	//35. Cubemap
	RegisterClass<Cubemap>("Core");
	//36. Texture3D
	RegisterClass<Texture3D>("Core");
	//37. Texture2DArray
	RegisterClass<Texture2DArray>("Core");
	//38. MeshFilter
	RegisterClass<MeshFilter>("Core");
	//39. MeshRenderer
	RegisterClass<MeshRenderer>("Core");
	//40. LowerResBlitTexture
	RegisterClass<LowerResBlitTexture>("Core");
	//41. GameManager
	RegisterClass<GameManager>("Core");
	//42. TagManager
	RegisterClass<TagManager>("Core");
	//43. GlobalGameManager
	RegisterClass<GlobalGameManager>("Core");
	//44. GraphicsSettings
	RegisterClass<GraphicsSettings>("Core");
	//45. DelayedCallManager
	RegisterClass<DelayedCallManager>("Core");
	//46. QualitySettings
	RegisterClass<QualitySettings>("Core");
	//47. InputManager
	RegisterClass<InputManager>("Core");
	//48. TimeManager
	RegisterClass<TimeManager>("Core");
	//49. BuildSettings
	RegisterClass<BuildSettings>("Core");
	//50. ResourceManager
	RegisterClass<ResourceManager>("Core");
	//51. RuntimeInitializeOnLoadManager
	RegisterClass<RuntimeInitializeOnLoadManager>("Core");
	//52. ScriptMapper
	RegisterClass<ScriptMapper>("Core");
	//53. MonoManager
	RegisterClass<MonoManager>("Core");
	//54. MonoScript
	RegisterClass<MonoScript>("Core");
	//55. TextAsset
	RegisterClass<TextAsset>("Core");
	//56. AudioManager
	RegisterClass<AudioManager>("Audio");
	//57. PlayerSettings
	RegisterClass<PlayerSettings>("Core");
	//58. MasterServerInterface
	//Skipping MasterServerInterface
	//59. CloudWebServicesManager
	RegisterClass<CloudWebServicesManager>("CloudWebServices");
	//60. PerformanceReportingManager
	RegisterClass<PerformanceReportingManager>("PerformanceReporting");
	//61. Physics2DSettings
	RegisterClass<Physics2DSettings>("Physics2D");
	//62. UnityAnalyticsManager
	RegisterClass<UnityAnalyticsManager>("UnityAnalytics");
	//63. UnityConnectSettings
	RegisterClass<UnityConnectSettings>("UnityConnect");
	//64. SortingGroup
	RegisterClass<SortingGroup>("Core");
	//65. FlareLayer
	RegisterClass<FlareLayer>("Core");
	//66. RenderSettings
	RegisterClass<RenderSettings>("Core");
	//67. LevelGameManager
	RegisterClass<LevelGameManager>("Core");
	//68. LightmapSettings
	RegisterClass<LightmapSettings>("Core");
	//69. SpriteRenderer
	RegisterClass<SpriteRenderer>("Core");
	//70. EdgeCollider2D
	RegisterClass<EdgeCollider2D>("Physics2D");
	//71. NetworkManager
	//Skipping NetworkManager

}
