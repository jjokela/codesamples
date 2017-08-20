namespace Adapter
{
    public class MapAdpater : ITarget
    {
        public string Get3DMap()
        {
            var legacyMap = new LegacyMap();
            var twoDmap = legacyMap.Get2DMap();
            string threeDmap = twoDmap + ", z: 0.0";

            return threeDmap;
        }
    }
}