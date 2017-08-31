/*************************************************************************
 *  Copyright (C), 2017-2018, Mogoson tech. Co., Ltd.
 *  FileName: TerrainModifier.cs
 *  Author: Mogoson   Version: 1.0   Date: 8/31/2017
 *  Version Description:
 *    Internal develop version,mainly to achieve its function.
 *  File Description:
 *    Ignore.
 *  Class List:
 *    <ID>           <name>             <description>
 *     1.        TerrainModifier           Ignore.
 *  Function List:
 *    <class ID>     <name>             <description>
 *     1.
 *  History:
 *    <ID>    <author>      <time>      <version>      <description>
 *     1.     Mogoson     8/31/2017       1.0        Build this file.
 *************************************************************************/

namespace Developer.TerrainModifier
{
    using UnityEditor;
    using UnityEngine;

    public class TerrainModifier : ScriptableWizard
    {
        #region Property and Field
        [Tooltip("Target terrain data.")]
        public TerrainData terrainData;

        [Tooltip("Add height base on current.")]
        public float addHeight = 0;
        #endregion

        #region Private Method
        [MenuItem("Tool/Terrain Modifier &T")]
        private static void ShowEditor()
        {
            DisplayWizard("Terrain Modifier", typeof(TerrainModifier), "Modify");
        }

        private void OnWizardUpdate()
        {
            if (terrainData)
                isValid = true;
            else
                isValid = false;
        }

        private void OnWizardCreate()
        {
            var modify = EditorUtility.DisplayDialog(
                "Modify Confirm",
                "Modify operate can not be recovered!\n"
                + "Make sure you have a backup of target terrain data.\n"
                + "Don't set a negative value to the \"Add Height\" unless you know terrain data inside out.",
                "Modify",
                "Cancle");
            if (modify)
            {
                var heights = terrainData.GetHeights(0, 0, terrainData.heightmapWidth, terrainData.heightmapHeight);
                var normalizedHeight = addHeight / terrainData.size.y;
                for (int w = 0; w < terrainData.heightmapWidth; w++)
                {
                    for (int h = 0; h < terrainData.heightmapHeight; h++)
                    {
                        heights[w, h] += normalizedHeight;
                    }
                }
                terrainData.SetHeights(0, 0, heights);
            }
        }
        #endregion
    }
}