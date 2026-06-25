using SparkyRailwayIECC.Modules.RailAssets.Domain.Assets.Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace SparkyRailwayIECC.Modules.RailAssets.Domain.Assets.Routes
{
    internal sealed class Route
    {
        internal string Id { get; }

        internal Signal EntrySignal { get; }
        internal Signal ExitSignal { get; }

        internal IReadOnlyList<TrackCircuit> TrackCircuits { get; }
        internal IReadOnlyList<PointRequirement> RequiredPoints { get; }
        internal IReadOnlyList<TrackCircuit> OverlapTrackCircuits { get; }

        public Route(
            string id,
            Signal entrySignal,
            Signal exitSignal,
            IReadOnlyList<TrackCircuit> trackCircuits,
            IReadOnlyList<PointRequirement> requiredPoints,
            IReadOnlyList<TrackCircuit> overlapTrackCircuits)
        {
            Id = id;
            EntrySignal = entrySignal;
            ExitSignal = exitSignal;
            TrackCircuits = trackCircuits;
            RequiredPoints = requiredPoints;
            OverlapTrackCircuits = overlapTrackCircuits;
        }

    }
}
