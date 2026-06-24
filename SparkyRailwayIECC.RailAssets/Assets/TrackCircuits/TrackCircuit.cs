using System;
using System.Collections.Generic;
using System.Text;

namespace SparkyRailwayIECC.Modules.RailAssets.Domain.Assets.TrackCircuits
{
    internal sealed class TrackCircuit
    {
        internal string Id { get;  }
        // The State of the track circuit, which can be either Clear or Occupied. This state is used to determine whether a train is present on the track circuit or not.
        internal TrackCircuitState State { get; private set; } = TrackCircuitState.Clear;
        // The line points that define the shape of the track circuit on the layout as Polyline in WPF.
        internal LinePoint[] LinePoints { get; private set; } = Array.Empty<LinePoint>();

        public TrackCircuit(string id)
        {
            Id = id;
        }

        internal void SetOccupied() => State = TrackCircuitState.Occupied;
        internal void SetClear() => State = TrackCircuitState.Clear;

    }
}
