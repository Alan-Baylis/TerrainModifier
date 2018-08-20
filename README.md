# TerrainModifier
- [中文手册](./README_ZH.md)

## Summary
- Unity Terrain modifier.

## Demand
- Occasionally, you may encounter a catastrophic problem in Unity project, example the terrain has
  been brushed but the demand change to brush a river or basin on the original terrain. if the
  terrain was created base on height zero, the river or basin cannot be brushed in this case, because
  Unity does not allow any part of the terrain is brushed to be negative. therefore, we hope that we
  can modify the heightmap data to raise whole terrian to continue brush landforms.

## Environment
- Unity 5.0 or above.
- .Net Framework 3.0 or above.

## Prerequisite
- Unity provide the API(GetHeights and SetHeights methods of TerrainData class) to modify TerrainData.

## Scheme
- Create extend editor window, select target TerrainData file and set raise height value.
- Add the raise height value to TerrainData heightmap.

## Achieve
- TerrainModifier : Draw extend editor window and modify(up or down) the terrain heightmap data.

## Preview
- TerrainModifier

![Terrain Modifier](./Attachments/README_Image/TerrainModifier.gif)

## Contact
- If you have any questions, feel free to contact me at mogoson@outlook.com.