#region License
//
// (C) Copyright 2010 Patrick Cozzi and Kevin Ring
//
// Distributed under the Boost Software License, Version 1.0.
// See License.txt or http://www.boost.org/LICENSE_1_0.txt.
//
#endregion

namespace OpenGlobe.Scene.Terrain
{
    public class ChunkedTerrain
    {
        public ChunkedTerrain(string chuFilename, string tqtFilename) :
            this(new ChunkedTerrainTree(chuFilename))
        {

        }

        public ChunkedTerrain(ChunkedTerrainTree tree)
        {
            //_tree = tree;
        }

        //private ChunkedTerrainTree _tree;
    }
}