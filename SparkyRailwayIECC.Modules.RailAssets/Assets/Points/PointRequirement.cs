using System;
using System.Collections.Generic;
using System.Text;

namespace SparkyRailwayIECC.Modules.RailAssets.Domain.Assets.Points
{
    internal sealed record PointRequirement(Point Point, PointLie RequiredPosition);
}
