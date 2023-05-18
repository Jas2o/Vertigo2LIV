namespace Vertigo2LIV
{
	public enum GameLayer
	{
        Default = 0,
        TransparentFX = 1,
        IgnoreRaycast = 2,
        Water = 4,
        UI = 5,
        Character = 11,
        PlayerBody = 22,
        VRRenderingOnly = 29,

        // Custom layers to use in the mod.
        LivOnly = 31 //Postprocessing
    }
}